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

namespace SuperMarketBillingSystem
{
    public partial class CashierScoutSKU : Form
    {
        public CashierScoutSKU()
        {
            InitializeComponent();
        }

        string conn = @"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierHomePage home = new CashierHomePage();
            home.ShowDialog();

        }

        private void CashierScoutSKU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet7.SKU' table. You can move, or remove it, as needed.
           // this.sKUTableAdapter.Fill(this.a2ZSuperMarketDataSet7.SKU);

            string query = "select * from SKU";
            DisplayDataInGrid(query);          

            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet6.SKU' table. You can move, or remove it, as needed.
            //this.sKUTableAdapter.Fill(this.a2ZSuperMarketDataSet6.SKU);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from sku where name like '"+textBox1.Text+"%"+"'";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "select * from sku where name like '" + textBox1.Text + "%" + "'";
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(query, conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        public void DisplayDataInGrid(string Query)
        {
            SqlConnection connection = new SqlConnection(conn);

            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(Query, conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    
    }
         
}
