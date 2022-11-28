using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SecureDatabase
{
    public partial class RBAC : Form
    {
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        SqlConnection cnn;
        SqlCommand cmd;
        string strsql;
        string role;

        string[] allowed_marketing_roles = new string[] { "ADMIN", "MARKETING" };
        string[] allowed_sales_roles = new string[] { "ADMIN", "SALES" };
        public RBAC(string role)
        {
            InitializeComponent();
            this.role = role;
        }  
        private void RBAC_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (!allowed_marketing_roles.Contains(role))
            {
                MarketingDataButton.Hide();
            }
            if (!allowed_sales_roles.Contains(role))
            {
                SalesDataButton.Hide();
            }
        }
        private void SalesDataButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (allowed_sales_roles.Contains(role))
            {
                dataGridView1.Columns.Add("Mandatory column because reasons", "Sales Data");
                using (cnn = new SqlConnection(s))
                {
                    cnn.Open();
                    var com = cnn.CreateCommand();
                    com.CommandText = string.Format($"SELECT COUNT(Movie_Name) FROM CD");
                    var numberOfMovies = com.ExecuteScalar();
                    dataGridView1.Rows.Add($"Number Of Different Movies Available: {numberOfMovies}");
                    com.CommandText = string.Format($"SELECT Movie_Name, Unit_Price FROM CD");
                    dataGridView1.Rows.Add("Price Of Each Movie");
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add($"{reader.GetString(0)}:\t {reader[1]}");
                    }
                }
                cnn.Close();
            }
        }
        private void MarketingDataButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            if (allowed_marketing_roles.Contains(role))
            {
                dataGridView1.Columns.Add("Marketing_Data", "Marketing Data");

                using (cnn = new SqlConnection(s))
                {
                    cnn.Open();
                    var com = cnn.CreateCommand();
                    com.CommandText = string.Format($"SELECT COUNT(UserID) FROM Users WHERE User_Role = 'customer'");
                    var numCustomersQueryResult = com.ExecuteScalar();
                    int numberOfCustomers = (int)numCustomersQueryResult;

                    dataGridView1.Rows.Add($"Customer Reach: {numberOfCustomers} Movie Maniacs!");
                    dataGridView1.Rows.Add("Next Campaign Launch: 7 Days.");
                    dataGridView1.Rows.Add("Next Campaign Theme: \"Have A Merry Movie Christmas!\"");
                    dataGridView1.Rows.Add("Featuring:");
                    dataGridView1.Rows.Add("GDPR Says No Cookies For Santa");
                    dataGridView1.Rows.Add("How The Hackers Stole Christmas");
                    dataGridView1.Rows.Add("Encryption For The Holidays: A Family Adventure");

                }
                cnn.Close();
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Movies f = new Movies();
            f.ShowDialog();
            Close();
        }
    }
}
