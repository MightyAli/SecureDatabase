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

namespace SecureDatabase
{
    public partial class New_Customer : Form
    {
        SqlConnection cnn;
        string Customer_ID;
        string s = ("Data Source = DESKTOP-FJRM1KO\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        public New_Customer(string Customer_ID)
        {
            InitializeComponent();
            this.Customer_ID = Customer_ID;
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            Hide();
            Movies f = new Movies();
            f.ShowDialog();
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDTestBox.Text != "" && FnameTextBox.Text != "" && LnameTextBox.Text != "" && MobileNumberTextBox.Text != "" && PassTestBox.Text != "" && ConfirmPassTestBox.Text != "")
            {
                if (PassTestBox.Text == ConfirmPassTestBox.Text)
                {
                    /*
                    1000 iterations.
                    8 bytes salt.
                    SHA256 (SHA2) is used. Otherwise, it defaults to SHA160 (SHA1).
                    SHA256 is more than enough. No need for SHA512
                    */
                    Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(PassTestBox.Text, 8, 1000, HashAlgorithmName.SHA256);
                    byte[] keyArray = obj.GetBytes(32); // 32 Bytes hash --> 256/8
                    byte[] saltArray = obj.Salt; // Byte = 8-bit unsigned integer

                    string hash = BitConverter.ToString(keyArray); // Converts to hexadecimal = 32 * 2 (every 2 hexas represent a byte) = 64 hexa numbers
                    hash = hash.Replace("-", "");
                    hash = hash.Insert(0, "0x");

                    string salt = BitConverter.ToString(saltArray); // Converts to hexadecimal = 8 * 4  = 16 hexa numbers
                    salt = salt.Replace("-", "");
                    salt = salt.Insert(0, "0x");

                    using (cnn = new SqlConnection(s))
                    {
                        cnn.Open();
                        string strsql = string.Format("INSERT INTO CUSTOMER VALUES({0},'{1}','{2}',{3},'{4}','{5}')", CustomerIDTestBox.Text, FnameTextBox.Text, LnameTextBox.Text, MobileNumberTextBox.Text, hash, salt);
                        SqlCommand cmd = new SqlCommand(strsql, cnn);
                        int R = cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer Was Added", "Customer Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please enter all of the required fields", "All fields are required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
