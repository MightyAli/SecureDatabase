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
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        /*
        Integrated Security = True
        When false, User ID and Password are specified in the connection.
        When true, the current Windows account credentials are used for authentication.  
        Initial Catalog --> Name of database.
        */
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
                    uint ID = cry.generateCustomerID(EmailTextBox.Text);
                    strsql = string.Format($"SELECT Customer_ID FROM Customer WHERE Customer_ID = {ID}");
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
                        string hash = computeHash();
                        strsql = string.Format("SELECT Password FROM Customer WHERE Password = '{0}'", hash);
                        cmd = new SqlCommand(strsql, cnn);
                        object passCheck = cmd.ExecuteScalar();
                        if (passCheck == null) // If the new computed hash is found, then the password was correct.
                        {
                            MessageBox.Show("Credentials are not correct", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Hide(); // Hides the current window
                            OrderedCDs f = new OrderedCDs(ID); // Creates a new window
                            f.ShowDialog(); // Opens a new window
                            Close(); // Closes the previous window.
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
            New_Customer f = new New_Customer();
            f.ShowDialog();
            Close();
        }

        private string computeHash()
        {
            /*
            Here, we compute the hash for the user's password and we compare it to the hash stored in the database.
            If they match, then the password is correct. Else, it is not correct.      
            */
            // Get Salt from database
           
            uint userID = cry.generateCustomerID(EmailTextBox.Text);

            strsql = string.Format("SELECT Salt FROM Customer WHERE Customer_ID = {0}", userID);
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

            Rfc2898DeriveBytes obj = new Rfc2898DeriveBytes(PasswordTextBox.Text, salt, 5000, HashAlgorithmName.SHA512); // Generate the hash.
            byte[] keyArray = obj.GetBytes(64);

            string hash = BitConverter.ToString(keyArray);
            hash = hash.Replace("-", "");
            hash = hash.Insert(0, "0x");

            return hash;
        }
    }
}
