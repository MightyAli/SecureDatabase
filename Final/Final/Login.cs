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
    public partial class Login : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string Customer_ID;
        string s = ("Data Source = localhost; Initial Catalog = shop; Integrated Security = True; Pooling=False");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                using (cnn = new SqlConnection(s))
                {
                    cnn.Open();
                    string strsql = string.Format("SELECT * FROM Customer WHERE Customer_ID = {0}", CustomerIDTextBox.Text);
                    cmd = new SqlCommand(strsql, cnn);
                    object idCheck;
                    try
                    {
                        idCheck = cmd.ExecuteScalar();
                    }
                    catch
                    {
                        MessageBox.Show("Only numbers are allowed for the ID", "Illegal Characters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (idCheck == null)
                    {
                        MessageBox.Show("Customer ID wasn't found, Please enter another one", "ID isn't found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string strsql2 = string.Format("SELECT * FROM Customer WHERE Customer_ID = {0} AND Password = '{1}'", CustomerIDTextBox.Text, PasswordTextBox.Text);
                        cmd = new SqlCommand(strsql2, cnn);
                        object passCheck = cmd.ExecuteScalar();
                        if (passCheck == null)
                        {
                            MessageBox.Show("Password is not correct, Please enter another one", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Customer_ID = CustomerIDTextBox.Text;
                            Hide();
                            OrderedCDs f = new OrderedCDs(Customer_ID);
                            f.ShowDialog();
                            Close();
                        }
                    }



                }
            }
            else
            {
                MessageBox.Show("Please enter all of the required fields", "StudentID and Password required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            Customer_ID = CustomerIDTextBox.Text;
            Hide();
            New_Customer f = new New_Customer(Customer_ID);
            f.ShowDialog();
            Close();
        }
    }
}
