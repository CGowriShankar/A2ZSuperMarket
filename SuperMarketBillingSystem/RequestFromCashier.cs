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
    public partial class RequestFromCashier : Form
    {
        public RequestFromCashier()
        {
            InitializeComponent();
        }

        String conn = @"SERVER = .\SQLEXPRESS; DATABASE = A2ZSuperMarket; Integrated Security = true";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminHomePage adminHome = new AdminHomePage();
            adminHome.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage home = new WelcomePage();
            home.ShowDialog();
        }

        private void RequestFromCashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet8.RequestFromCashier' table. You can move, or remove it, as needed.
             //this.requestFromCashierTableAdapter.Fill(this.a2ZSuperMarketDataSet8.RequestFromCashier);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet2.RequestFromCashier' table. You can move, or remove it, as needed.
            //this.requestFromCashierTableAdapter.Fill(this.a2ZSuperMarketDataSet2.RequestFromCashier);

            String query = "select * from RequestFromCashier";
            DisplayDataInGrid(query);

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
