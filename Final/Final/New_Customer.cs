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
namespace Final
{
    public partial class New_Customer : Form
    {
        SqlConnection cnn;
        string Customer_ID;
        string s = ("Data Source = localhost; Initial Catalog = shop; Integrated Security = True; Pooling=False");
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
            Login f = new Login();
            f.ShowDialog();
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDTestBox.Text != "" && FnameTextBox.Text != "" && LnameTextBox.Text != "" && MobileNumberTextBox.Text != "" && PassTestBox.Text != "" && ConfirmPassTestBox.Text != "")
            {
                if (PassTestBox.Text == ConfirmPassTestBox.Text)
                {
                    using (cnn = new SqlConnection(s))
                    {
                        cnn.Open();
                        string strsql = string.Format("INSERT INTO CUSTOMER VALUES({0},'{1}','{2}',{3},'{4}')", CustomerIDTestBox.Text, FnameTextBox.Text, LnameTextBox.Text, MobileNumberTextBox.Text, PassTestBox.Text, ConfirmPassTestBox.Text);
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
