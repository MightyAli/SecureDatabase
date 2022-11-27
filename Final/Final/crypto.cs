using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SecureDatabase
{
    internal class crypto
    {
        private byte[] getSalt(string text) // 8 bytes salt
        {
            byte[] saltTemp = Encoding.ASCII.GetBytes(text);
            byte[] salt = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            if (saltTemp.Length >= 8)
            {
                salt = saltTemp;
            }
            else
            {
                for (int i = 0; i < saltTemp.Length; i++) // Padding
                {
                    salt[i] = saltTemp[i];
                }
            }
            return salt;
        }
        public uint generateUserID(string email) // Every email will get a unique ID. Generating over and over gives the same ID for the same email.
        {
            byte[] salt = getSalt(email);         
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(email, salt, 5000, HashAlgorithmName.SHA512);
            byte[] IDByte = obj.GetBytes(4);
            uint ID = BitConverter.ToUInt32(IDByte, 0);
            return ID;
        }
        public string encryptData(string data, string pass, uint ID)
        {
            /*
            ID and password are used to generated the encryption key.            
            For AES, the legal key sizes are 128, 192, and 256 bits.
            For the IV, the size is a fixed 16 bytes.   
            The input size is unlimited.
            The output size.
            Uses Cipher-Block Chaining (CBC) mode by default.
            Output size = input size;
            */
            string stringID = ID.ToString();
            byte[] salt = getSalt(pass);
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(stringID, salt, 5000, HashAlgorithmName.SHA512);
            byte[] encryptedDataBytes;
            using (AesCng aes = new AesCng())
            {
                aes.Key = obj.GetBytes(32);
                aes.IV = obj.GetBytes(16); // Gets the next bytes after the first 32 bytes.
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = aes.CreateEncryptor();
                using (MemoryStream ms = new MemoryStream()) // Data in RAM
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(data);                       
                        }
                        encryptedDataBytes = ms.ToArray();
                    }              
                }
                
            }
            string encryptedData = Convert.ToBase64String(encryptedDataBytes);
            
            //string encryptedData = BitConverter.ToString(encryptedDataBytes);
            //encryptedData = encryptedData.Replace("-", "");
            //encryptedData = encryptedData.Insert(0, "0x");
            return encryptedData;
        }
        public string decryptData(string EncryptedData, string pass, uint ID)
        {
           // byte[] encryptedDataBytes = fixDataFormat(EncryptedData);
            byte[] encryptedDataBytes = Convert.FromBase64String(EncryptedData);
            string stringID = ID.ToString();
            byte[] salt = getSalt(pass);
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(stringID, salt, 5000, HashAlgorithmName.SHA512);
            string decryptedData = null;
            using (AesCng aes = new AesCng())
            {
                aes.Key = obj.GetBytes(32);
                aes.IV = obj.GetBytes(16); // Gets the next bytes after the first 32 bytes.
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = aes.CreateDecryptor();
                using (MemoryStream ms = new MemoryStream(encryptedDataBytes)) // Data in RAM
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader rw = new StreamReader(cs))
                        {
                            decryptedData = rw.ReadToEnd();
                        }
                    }
                   
                }
       
            }          
            return decryptedData;
        }
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
        public Dictionary<string, string> computePasswordHash(string pass)
        {
            /*
            5000 iterations.
            8 bytes salt.
            SHA512 (SHA2) is used. Otherwise, it defaults to SHA160 (SHA1).

            GetBytes() --> Combines a passed string (password for example), a salt, and some random number to create an input that is passed to the SHA512 to generate a key. This input to SHA512 can be of size up to 2^64 bits.
            If the salt is not defined (you specify the size only), then every time you run GetBytes(), a new salt will be created.
            If the salt value is fixed (you specify the array of bytes), then every time you run GetBytes(), the salt is used.

            The random number is derived from the passed string and the salt. 
            If these two are fixed, then every time you run GetBytes(), the same pattern of random numbers will be generated --> Same pattern of inputs --> Same patterns of keys generated from SHA512.
            If these two are different, then every time you run GetBytes(), a different random number will be generated --> Different inputs --> Different keys generated from SHA512.
            */
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(pass, 8, 5000, HashAlgorithmName.SHA512);
            byte[] keyArray = obj.GetBytes(64); // 64 Bytes hash --> 512/8
            byte[] saltArray = obj.Salt;

            string hash = BitConverter.ToString(keyArray); // Converts to hexadecimal = 64 * 2 (every 2 hexas represent a byte) = 128 hexa numbers or 128 string characters
            hash = hash.Replace("-", "");
            hash = hash.Insert(0, "0x"); // Now, we have 130 characters

            string salt = BitConverter.ToString(saltArray); // Converts to hexadecimal = 8 * 4  = 16 hexa numbers or 16 string characters
            salt = salt.Replace("-", "");
            salt = salt.Insert(0, "0x"); // Now, we have 18 characters

            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add(hash, salt);
            return d;
        }
        public string checkHash(uint ID, string pass)
        {
            /*
            Here, we compute the hash for the user's password and we compare it to the hash stored in the database.
            If they match, then the password is correct. Else, it is not correct.      
            */
            // Get Salt from database

            string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
            SqlConnection cnn;
            string hash;
            using (cnn = new SqlConnection(s)) // The connection is closed automatically when the scope ends, else you need to use cnn.close()
            {
                cnn.Open();
                string strsql = string.Format("SELECT Salt FROM Users WHERE UserID = {0}", ID);
                SqlCommand cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                string saltDatabase = "";
                while (reader.Read())
                {
                    saltDatabase = reader[0].ToString();
                }
                byte[] salt = fixDataFormat(saltDatabase);
                reader.Close();
                Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(pass, salt, 5000, HashAlgorithmName.SHA512); // Generate the hash.
                byte[] keyArray = obj.GetBytes(64);
                hash = BitConverter.ToString(keyArray);
                hash = hash.Replace("-", "");
                hash = hash.Insert(0, "0x");
            }
            return hash;
        }
        private byte[] fixDataFormat(string text)
        {
            text = text.Remove(0, 2); // Removes "0x"
            for (int i = 2; i < text.Length; i += 3)
            {
                text = text.Insert(i, "-"); // Need to insert some character so that I can split up the bytes.
            }
            string[] textSplit = text.Split('-'); // Each byte is split into its own string.
            byte[] texts = textSplit.Select(value => Convert.ToByte(value, 16)).ToArray(); // Covert back to array of bytes.
            return texts;
        }
    }
}


