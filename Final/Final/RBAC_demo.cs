﻿using System;
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
        string Customer_ID;
        string Customer_Role;
        string[] allowed_marketing_roles = new string[] { "ADMIN", "MARKETING" };
        string[] allowed_sales_roles = new string[] { "ADMIN", "SALES" };

        public RBAC_demo(string Customer_ID)
        {
            InitializeComponent();
            this.Customer_ID = Customer_ID;
        }

        private void sales_data_button_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            if (allowed_sales_roles.Contains(Customer_Role))
            {
                dataGridView1.Columns.Add("mandatory column because reasons", "Sales Data");

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                using (cnn = new SqlConnection(s))
                {
                    cnn.Open(); // Opens a connection to the database

                    var com = cnn.CreateCommand();

                    com.CommandText = string.Format($"SELECT COUNT(CD_ID) FROM CD");
                    var numberOfMovies = com.ExecuteScalar();

                    dataGridView1.Rows.Add($"Number Of Different Movies Available: {numberOfMovies}");

                    com.CommandText = string.Format($"SELECT Movie_Name, Unit_Price, Quantity FROM CD");

                    dataGridView1.Rows.Add("Available Quantity Of Each Movie");

                    double inventory_value = 0;
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add($"{reader.GetString(0)}:\t {reader[1]}");

                        double price = Convert.ToDouble(reader[1]);
                            
                        double quantity = Convert.ToDouble(reader[2]);

                        inventory_value += price * quantity;
                    }

                    dataGridView1.Rows.Add($"Value of inventory: {inventory_value}");

                }
                cnn.Close();
            }
        }
    


        private void marketing_data_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            if (allowed_marketing_roles.Contains(Customer_Role))
            {
                dataGridView1.Columns.Add("Marketing_Data", "Marketing Data");
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                using (cnn = new SqlConnection(s))
                {
                    cnn.Open(); // Opens a connection to the database

                    var com = cnn.CreateCommand();

                    com.CommandText = string.Format($"SELECT COUNT(Customer_ID) FROM Customer");
                    var numCustomersQueryResult = com.ExecuteScalar();
                    int numberOfCustomers = (int)numCustomersQueryResult - 3; 
                    // subtract 3 to account for admin, marketing, sales users b/c those are company employees, not customers
                    
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

        private void RBAC_demo_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            using (cnn = new SqlConnection(s))
            {
                cnn.Open(); // Opens a connection to the database

                strsql = string.Format($"SELECT Fname FROM CUSTOMER WHERE Customer_ID = {Customer_ID}");
                cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.Customer_Role = reader[0].ToString();
                }
                cnn.Close();
            }
        }

        private void dataGridView1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
