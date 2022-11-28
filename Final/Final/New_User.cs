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
    public partial class New_User : Form
    { 
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        SqlConnection cnn;
        SqlCommand cmd;
        uint ID;
        crypto cry = new crypto();  
        public New_User()
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
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (EmailTestBox.Text != "" && FnameTextBox.Text != "" && LnameTextBox.Text != "" && MobileNumberTextBox.Text != "" && PassTestBox.Text != "" && ConfirmPassTestBox.Text != "")
            {
                if (cry.IsDigitsOnly(MobileNumberTextBox.Text))
                {
                    if (PassTestBox.Text == ConfirmPassTestBox.Text)
                    {
                        if (PassTestBox.Text.Length >= 8) 
                        {
                            using (cnn = new SqlConnection(s))
                            {
                                cnn.Open();
                                ID = cry.generateUserID(EmailTestBox.Text);
                                string strsql = string.Format($"SELECT UserID FROM Users WHERE UserID = '{ID}'");
                                cmd = new SqlCommand(strsql, cnn);
                                object R = cmd.ExecuteScalar();
                                if (R != null)
                                {
                                    MessageBox.Show("The email is already in use, please try a different Email", "Email Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {
                                    Dictionary<string, string> d = cry.computePasswordHash(PassTestBox.Text);
                                    KeyValuePair<string, string> pair = d.First();
                                   
                                    string email = cry.encryptData(EmailTestBox.Text, PassTestBox.Text, ID);
                                    string fname = cry.encryptData(FnameTextBox.Text, PassTestBox.Text, ID);
                                    string lname = cry.encryptData(LnameTextBox.Text, PassTestBox.Text, ID);
                                    string phone = cry.encryptData(MobileNumberTextBox.Text, PassTestBox.Text, ID);
                                    string role = "customer";
                                    using (cnn = new SqlConnection(s))
                                    {
                                        cnn.Open();
                                        strsql = string.Format("INSERT INTO Users VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", ID, email, fname, lname, phone, pair.Key, pair.Value, role);
                                        cmd = new SqlCommand(strsql, cnn);
                                        cmd.ExecuteNonQuery();
                                        MessageBox.Show("User Was Added", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
     
    }
}
