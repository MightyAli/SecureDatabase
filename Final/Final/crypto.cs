using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SecureDatabase
{
    internal class crypto
    {
        SqlConnection cnn;
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        public uint generateCustomerID(string email)
        {    
            byte[] saltTemp = Encoding.ASCII.GetBytes(email);
            byte[] salt = new byte[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
            if(saltTemp.Length >= 8)
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
            byte[] salt = Encoding.ASCII.GetBytes(pass);
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(stringID, salt, 5000, HashAlgorithmName.SHA512);

            AesCng aes = new AesCng();
            aes.Key = obj.GetBytes(32);
            aes.IV = obj.GetBytes(16); // Gets the next bytes after the first 32 bytes.
            ICryptoTransform encryptor = aes.CreateEncryptor();

            byte[] encryptedDataBytes;
            using (MemoryStream ms = new MemoryStream()) // Data in RAM
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(data);
                    }
                }
                encryptedDataBytes = ms.ToArray();
            }
            string encryptedData = BitConverter.ToString(encryptedDataBytes);
            encryptedData = encryptedData.Replace("-", "");
            encryptedData = encryptedData.Insert(0, "0x");
            return encryptedData;
        }
    }
}

