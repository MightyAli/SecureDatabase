using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //For DataBase functions
using System.Security.Cryptography;
using System.IO;

namespace SecureDatabase
{
    public partial class New_Customer : Form
    {
        SqlConnection cnn;
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        public New_Customer()
        {
            InitializeComponent();
        }
        private void New_Customer_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Movies f = new Movies();
            f.ShowDialog();
            Close();
        }
        string hash;
        string salt;
        byte[] saltArray;
        uint ID;
        crypto cry = new crypto();
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (EmailTestBox.Text != "" && FnameTextBox.Text != "" && LnameTextBox.Text != "" && MobileNumberTextBox.Text != "" && PassTestBox.Text != "" && ConfirmPassTestBox.Text != "")
            {
                if (IsDigitsOnly(MobileNumberTextBox.Text))
                {
                    if (PassTestBox.Text == ConfirmPassTestBox.Text)
                    {
                        if (PassTestBox.Text.Length >= 8)
                        {
                            using (cnn = new SqlConnection(s))
                            {
                                cnn.Open();
                                ID = cry.generateCustomerID(EmailTestBox.Text);                              
                                string strsql = string.Format($"SELECT Customer_ID FROM Customer WHERE Customer_ID = '{ID}'");
                                SqlCommand cmd = new SqlCommand(strsql, cnn);
                                object R = cmd.ExecuteScalar();
                                if (R != null)
                                {
                                    MessageBox.Show("The email is already in use, please try a different Email", "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {
                                    computePasswordHash();
                                    string email = encryptData(EmailTestBox.Text);
                                    string fname = encryptData(FnameTextBox.Text);
                                    string lname = encryptData(LnameTextBox.Text);
                                    string phone = encryptData(MobileNumberTextBox.Text);

                                    using (cnn = new SqlConnection(s))
                                    {
                                        cnn.Open();
                                        strsql = string.Format("INSERT INTO CUSTOMER VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}')", ID, email, fname, lname, phone, hash, salt);
                                        cmd = new SqlCommand(strsql, cnn);
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("Customer Was Added", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a longer password (Minimum 8 characters)", "Short Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match", "password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter all of the required fields", "All fields are required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void computePasswordHash()
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
            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(PassTestBox.Text, 8, 5000, HashAlgorithmName.SHA512);
            byte[] keyArray = obj.GetBytes(64); // 64 Bytes hash --> 512/8
            saltArray = obj.Salt;

            hash = BitConverter.ToString(keyArray); // Converts to hexadecimal = 64 * 2 (every 2 hexas represent a byte) = 128 hexa numbers or 128 string characters
            hash = hash.Replace("-", "");
            hash = hash.Insert(0, "0x"); // Now, we have 130 characters

            salt = BitConverter.ToString(saltArray); // Converts to hexadecimal = 8 * 4  = 16 hexa numbers or 16 string characters
            salt = salt.Replace("-", "");
            salt = salt.Insert(0, "0x"); // Now, we have 18 characters
        }

        private bool IsDigitsOnly(string str)
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

        private string encryptData(string data)
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
            byte[] salt = Encoding.ASCII.GetBytes(PassTestBox.Text);
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
