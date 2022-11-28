using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SecureDatabase
{
    public partial class OrderedCDs : Form
    {
        string s = ("Data Source = ACER\\SQLEXPRESS; Initial Catalog = Movies; Integrated Security = True;");
        SqlConnection cnn;
        string strsql;
        SqlCommand cmd;
        uint ID;
        string pass;      
        public OrderedCDs(uint ID, string pass)
        {
            InitializeComponent();
            this.ID = ID;
            this.pass= pass;
        }
        private void Information_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Movie Name", "Movie Name");
            dataGridView1.Columns.Add("Unit Price", "Unit Price");
            dataGridView2.Columns.Add("Movie Name", "Movie Name");
            dataGridView2.Columns.Add("Unit Price", "Unit Price");
            using (cnn = new SqlConnection(s))
            {
                cnn.Open();
                strsql = string.Format("SELECT Movie_Name, Unit_Price FROM CD");
                cmd = new SqlCommand(strsql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString());
                }
                reader.Close();
            }
            totalPriceTextBox.Text = "0";
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Movies f = new Movies();
            f.ShowDialog();
            Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value, dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string price = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            double priceCon = Convert.ToDouble(price);

            double totalPrice = Convert.ToDouble(totalPriceTextBox.Text);
            totalPrice += priceCon;

            totalPriceTextBox.Text = totalPrice.ToString();
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                string price = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                double priceCon = Convert.ToDouble(price);

                double totalPrice = Convert.ToDouble(totalPriceTextBox.Text);
                totalPrice -= priceCon;

                totalPriceTextBox.Text = totalPrice.ToString();
                dataGridView2.Rows.Remove(dataGridView2.Rows[e.RowIndex]);
            }
        }
        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> numOfMovies = new Dictionary<string, int>();
            Dictionary<string, double> price = new Dictionary<string, double>();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                string movie = dataGridView2.Rows[i].Cells[0].Value.ToString();
                if (numOfMovies.ContainsKey(movie))
                {
                    numOfMovies[movie] += 1;
                }
                else
                {
                    numOfMovies.Add(movie, 1);
                    price.Add(movie, Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value.ToString()));
                }
            }
            foreach (KeyValuePair<string, int> x in numOfMovies)
            {
                using (cnn = new SqlConnection(s))
                {
                    cnn.Open();
                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    double priceOneMovie = price[x.Key] * x.Value;

                    strsql = string.Format("INSERT INTO OrderT VALUES({0},'{1}',{2},'{3}', {4})", ID, x.Key, x.Value, sqlFormattedDate, priceOneMovie);
                    cmd = new SqlCommand(strsql, cnn);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Purchase Complete!", "Successful Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            Hide();
            EditUser f = new EditUser(ID, pass);
            f.ShowDialog();
            Close();
        }
    }
}
