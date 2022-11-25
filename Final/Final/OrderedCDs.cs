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

namespace SecureDatabase
{
    public partial class OrderedCDs : Form
    {
        double unitPrice = 0;
        int OrderQuan = 0;

        SqlConnection cnn;
        string Customer_ID;
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        public OrderedCDs(string Customer_ID)
        {
            InitializeComponent();
            this.Customer_ID = Customer_ID;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Cd_id", "CD_id");
            dataGridView1.Columns.Add("Ordered_quantity", "Ordered_quantity");
            dataGridView1.Columns.Add("Order_date", "Order_date");
            dataGridView1.Columns.Add("unit_price", "unit_price");
            dataGridView1.Columns.Add("movie_name", "movie_name ID");
            using (cnn = new SqlConnection(s))
            {
                cnn.Open();
                string strsql = string.Format("SELECT CD.CD_ID, Order_Quantity, Order_date, Unit_Price ,Movie_Name " +
                    "FROM CD, OrderT, Customer " +
                    "WHERE CD.CD_ID = OrderT.CD_ID AND Customer.Customer_ID = OrderT.Customer_ID AND Customer.Customer_ID = {0} " +
                    "ORDER BY Customer.Customer_ID", Customer_ID);
                SqlCommand cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    unitPrice += Convert.ToDouble(reader[3].ToString());
                    OrderQuan += Convert.ToInt32(reader["Order_Quantity"].ToString());
                }
                textBox1.Text = (unitPrice * OrderQuan).ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(s))
            {
                cnn.Open();
                string strsql = string.Format("SELECT CD.CD_ID, Order_Quantity, Order_date, Unit_Price ,Movie_Name, Quantity " +
                    "FROM CD, OrderT, Customer " +
                    "WHERE CD.CD_ID = OrderT.CD_ID AND Customer.Customer_ID = OrderT.Customer_ID AND Customer.Customer_ID = {0} " +
                    "ORDER BY Customer.Customer_ID", Customer_ID);
                SqlCommand cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MovieNameTextBox.Text = reader[4].ToString();
                    UnitPriceTextBox.Text = reader[3].ToString();
                    QuantityTextBox.Text = reader[5].ToString();
                 
                }
            }
          

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Movies f = new Movies();
            f.ShowDialog();
            Close();
        }

        private void AddToMyCartButton_Click(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(s))
            {
                cnn.Open();
                string strsql = string.Format("INSERT INTO OrderT VALUES({0},{1},{2},{3})", Customer_ID ,CDIDTextBox.Text, OrderedQuantityTextBox.Text, OrderDateTextBox.Text);
                SqlCommand cmd = new SqlCommand(strsql, cnn);
                int r = cmd.ExecuteNonQuery();
            }
            using (cnn = new SqlConnection(s))
            {
                cnn.Open();
                string strsql = string.Format("SELECT CD.CD_ID, Order_Quantity, Order_date, Unit_Price ,Movie_Name, Quantity " +
                    "FROM CD, OrderT, Customer " +
                    "WHERE CD.CD_ID = OrderT.CD_ID AND Customer.Customer_ID = OrderT.Customer_ID AND Customer.Customer_ID = {0} " +
                    "ORDER BY Customer.Customer_ID", Customer_ID);
                SqlCommand cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());

                }
                unitPrice += Convert.ToDouble(UnitPriceTextBox.Text);
                OrderQuan += Convert.ToInt32(OrderedQuantityTextBox.Text);
                textBox1.Text = (unitPrice * OrderQuan).ToString();
            }
        }
    }
}
