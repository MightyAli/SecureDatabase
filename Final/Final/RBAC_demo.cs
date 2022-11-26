using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDatabase
{
    public partial class RBAC_demo : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string s = ("Data Source = DESKTOP-FJRM1KO\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        string strsql;

        public RBAC_demo()
        {
            InitializeComponent();
        }

        private void sales_data_button_Click(object sender, EventArgs e)
        {
            //TODO: check for user's RBAC role.  The following using block will go in that if statement

            // for now, all roles can see both buttons.  simplest way to test the button-sql query connection.
            // later/more advanced would be to hide buttons that belong to a role that the user doesn't have
            richTextBox1.ResetText();

            using (cnn = new SqlConnection(s))
            {
                cnn.Open(); // Opens a connection to the database

                strsql = string.Format($"SELECT Movie_Name FROM CD WHERE Quantity > 10 ORDER BY Movie_Name");
                cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    richTextBox1.AppendText(reader[0].ToString());
                    richTextBox1.AppendText("\n");
                }

            }    

        }

        private void marketing_data_button_Click(object sender, EventArgs e)
        {

        }

        private void RBAC_demo_Load(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
