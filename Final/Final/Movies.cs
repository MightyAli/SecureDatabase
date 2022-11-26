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
        SqlConnection cnn;
        SqlCommand cmd;
        string s = ("Data Source = DESKTOP-FJRM1KO\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        /*
        Integrated Security = True
        When false, User ID and Password are specified in the connection.
        When true, the current Windows account credentials are used for authentication.  

        Initial Catalog --> Name of database.

        */
        string Customer_ID;
        string strsql;
        public Movies()
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
                using (cnn = new SqlConnection(s)) // The connection is closed automatically when the scope ends, else you need to use cnn.close()
                {
                    cnn.Open(); // Opens a connection to the database.

                    strsql = string.Format($"SELECT * FROM Customer WHERE Customer_ID = {CustomerIDTextBox.Text}");
                    cmd = new SqlCommand(strsql, cnn); // Queries, non-queries (insert, delete, update) and any SQL statement.
                    /*
                    - The ExecuteNonQuery() --> for (insert, update, and delete) statements.
                    - The ExecuteReader() method to perform the (select) statement and make manipulation on the returned rows.
                    - The ExecuteScalar() method when you need to check the result of (select). This method executes the (select), 
                    and returns the first column of the first row from the result set returned by the (select) (the additional columns or rows are ignored).      
                    */
                    object idCheck;
                    try
                    {
                        idCheck = cmd.ExecuteScalar(); // Throws an exception if ID is not an integer since the "CustomerID" attribute is an integer.
                    } 
                    catch
                    {
                        MessageBox.Show("Only numbers are allowed for the ID", "Illegal Characters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (idCheck == null) // If Customer's ID is not found
                    {
                        MessageBox.Show("Customer ID wasn't found, Please enter another one", "ID isn't found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        string hash = computeHash();

                        strsql = string.Format("SELECT * FROM Customer WHERE Customer_ID = {0} AND Password = '{1}'", CustomerIDTextBox.Text, hash);
                        cmd = new SqlCommand(strsql, cnn);
                        object passCheck = cmd.ExecuteScalar();
                        if (passCheck == null)
                        {
                            MessageBox.Show("Password is not correct, Please enter another one", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Customer_ID = CustomerIDTextBox.Text;
                            Hide(); // Hides the current window
                            OrderedCDs f = new OrderedCDs(Customer_ID); // Creates a new window
                            f.ShowDialog(); // Opens a new window
                            Close(); // Closes the previous window.
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
        private string computeHash()
        {
            strsql = string.Format("SELECT Salt FROM Customer WHERE Customer_ID = {0}", CustomerIDTextBox.Text);
            cmd = new SqlCommand(strsql, cnn);

            SqlDataReader reader = cmd.ExecuteReader();

            string saltDatabase = "";
            while (reader.Read())
            {
                saltDatabase = reader[0].ToString();
            }
            saltDatabase = saltDatabase.Remove(0, 2); // Removes "0x"

            for (int i = 2; i < saltDatabase.Length; i += 3)
            {
                saltDatabase = saltDatabase.Insert(i, "-"); // Need to insert some character so that I can split up the bytes.
            }

            string[] saltSplit = saltDatabase.Split('-'); // Each byte is split into its own string.
            byte[] salt = saltSplit.Select(value => Convert.ToByte(value, 16)).ToArray(); // Covert back to array of bytes.
            reader.Close();

            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(PasswordTextBox.Text, salt, 1000, HashAlgorithmName.SHA256); // Generate the hash again
            byte[] keyArray = obj.GetBytes(32);

            string hash = BitConverter.ToString(keyArray);
            hash = hash.Replace("-", "");
            hash = hash.Insert(0, "0x");

            return hash;
        }
    }
}
