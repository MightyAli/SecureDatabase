using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.IO;

namespace SecureDatabase
{
    public partial class Movies : Form
    {
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        /*
        Integrated Security = True
        When false, User ID and Password are specified in the connection.
        When true, the current Windows account credentials are used for authentication.  
        Initial Catalog --> Name of database.
        */
        SqlConnection cnn;
        SqlCommand cmd;
        string strsql;
        crypto cry = new crypto();
        public Movies()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                using (cnn = new SqlConnection(s)) // The connection is closed automatically when the scope ends, else you need to use cnn.close()
                {
                    cnn.Open(); // Opens a connection to the database.
                    uint ID = cry.generateUserID(EmailTextBox.Text);
                    strsql = string.Format($"SELECT UserID FROM Users WHERE UserID = {ID}");
                    cmd = new SqlCommand(strsql, cnn); // Queries, non-queries (insert, delete, update) and any SQL statement.
                    /*
                    - The ExecuteNonQuery() --> for (insert, update, and delete) statements.
                    - The ExecuteReader() method to perform the (select) statement and make manipulation on the returned rows.
                    - The ExecuteScalar() method when you need to check the result of (select). This method executes the (select), 
                    and returns the first column of the first row from the result set returned by the (select) (the additional columns or rows are ignored).      
                    */
                    object IDCheck = cmd.ExecuteScalar();
                    if (IDCheck == null) // If Customer's ID is not found
                    {
                        MessageBox.Show("Account was not found", "Account doesn't exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        strsql = string.Format($"SELECT User_Role FROM Users WHERE UserID = {ID}");
                        cmd = new SqlCommand(strsql, cnn);
                        object RoleCheck = cmd.ExecuteScalar();
                        string role = RoleCheck.ToString();

                        string hash = cry.checkHash(ID, PasswordTextBox.Text);
                        strsql = string.Format("SELECT Password FROM Users WHERE Password = '{0}'", hash);
                        cmd = new SqlCommand(strsql, cnn);
                        object passCheck = cmd.ExecuteScalar();
                        if (passCheck == null) // If the new computed hash is found, then the password was correct.
                        {
                            MessageBox.Show("Credentials are not correct", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (role == "customer")
                            {
                                Hide(); // Hides the current window
                                OrderedCDs f = new OrderedCDs(ID, PasswordTextBox.Text); // Creates a new window
                                f.ShowDialog(); // Opens a new window
                                Close(); // Closes the previous window.
                            }
                            else
                            {
                                Hide();
                                RBAC f = new RBAC(role);
                                f.ShowDialog();
                                Close();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter all of the required fields", "Fields required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            Hide();
            New_User f = new New_User();
            f.ShowDialog();
            Close();
        }
    }
}
