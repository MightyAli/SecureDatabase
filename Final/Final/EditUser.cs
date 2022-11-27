using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SecureDatabase
{
    public partial class EditUser : Form
    {
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        SqlConnection cnn;
        string strsql;
        SqlCommand cmd;
        uint ID;
        string pass;
        crypto cry = new crypto();
        string email;
        string fname;
        string lname;
        string phone;
        
        public EditUser(uint ID, string pass)
        {
            InitializeComponent();
            this.ID = ID;
            this.pass = pass;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(s))
            {
                cnn.Open();
                string strsql = string.Format($"SELECT * FROM Users WHERE UserID = '{ID}'");
                SqlCommand cmd = new SqlCommand(strsql, cnn);
                SqlDataReader R = cmd.ExecuteReader();
                R.Read();

                email = cry.decryptData(R[1].ToString(), pass, ID);
                fname = cry.decryptData(R[2].ToString(), pass, ID);
                lname = cry.decryptData(R[3].ToString(), pass, ID);
                phone = cry.decryptData(R[4].ToString(), pass, ID);

                EmailTestBox.Text = email;
                FnameTextBox.Text = fname;
                LnameTextBox.Text = lname;
                MobileNumberTextBox.Text = phone;
                R.Close();
            }
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (FnameTextBox.Text != "" && LnameTextBox.Text != "" && MobileNumberTextBox.Text != "" && PassTestBox.Text != "" && ConfirmPassTestBox.Text != "")
            {
                if (cry.IsDigitsOnly(MobileNumberTextBox.Text))
                {
                    if (PassTestBox.Text == ConfirmPassTestBox.Text)
                    {
                        if (PassTestBox.Text.Length >= 4)
                        {
                            if (FnameTextBox.Text != fname || LnameTextBox.Text != lname || MobileNumberTextBox.Text != phone)
                            {
                                using (cnn = new SqlConnection(s))
                                {
                                    email = cry.encryptData(EmailTestBox.Text, PassTestBox.Text, ID);
                                    fname = cry.encryptData(FnameTextBox.Text, PassTestBox.Text, ID);
                                    lname = cry.encryptData(LnameTextBox.Text, PassTestBox.Text, ID);
                                    phone = cry.encryptData(MobileNumberTextBox.Text, PassTestBox.Text, ID);
                                    Dictionary<string, string> d = cry.computePasswordHash(PassTestBox.Text);
                                    KeyValuePair<string, string> pair = d.First();

                                    cnn.Open();
                                    strsql = string.Format($"UPDATE Users SET Email = '{email}', Fname = '{fname}', Lname = '{lname}', Mobile_Num = '{phone}', Password = '{pair.Key}', Salt = '{pair.Value}' WHERE UserID = {ID}");
                                    cmd = new SqlCommand(strsql, cnn);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("User info was updated", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Hide();
                                    OrderedCDs f = new OrderedCDs(ID, PassTestBox.Text);
                                    f.ShowDialog();
                                    Close();

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
                        MessageBox.Show("New passwords don't match", "Password mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
            OrderedCDs f = new OrderedCDs(ID, pass);
            f.ShowDialog();
            Close();
        }


    }
}
