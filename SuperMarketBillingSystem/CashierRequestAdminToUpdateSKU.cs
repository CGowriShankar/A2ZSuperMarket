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
    public partial class CashierRequestAdminToUpdateSKU : Form
    {
        public CashierRequestAdminToUpdateSKU()
        {
            InitializeComponent();
        }

        SqlDbConnection db = new SqlDbConnection();
       // String conn = @"SERVER = .\SQLEXPRESS ; DATABASE = A2ZSuperMarket ; Integrated Security = True";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierHomePage home = new CashierHomePage();
            home.ShowDialog();
        }

        private void CashierRequestAdminToUpdateSKU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet6.RequestFromCashier' table. You can move, or remove it, as needed.
            //this.requestFromCashierTableAdapter.Fill(this.a2ZSuperMarketDataSet6.RequestFromCashier);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet5.RequestFromCashier' table. You can move, or remove it, as needed.
            //this.requestFromCashierTableAdapter.Fill(this.a2ZSuperMarketDataSet5.RequestFromCashier);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet1.SKU' table. You can move, or remove it, as needed.
            //this.sKUTableAdapter.Fill(this.a2ZSuperMarketDataSet1.SKU);

            string query = "select * from RequestFromCashier";
            DisplayDataInGrid(query);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    throw new Exception("Please enter the Item name.");
                }
                else
                {
                    db.InsertRequest(textBox1.Text);

                    string query = "select * from RequestFromCashier";
                    DisplayDataInGrid(query);
                                       
                    System.Windows.Forms.MessageBox.Show("Record added!");

                    textBox1.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        public void DisplayDataInGrid(string Query)
        {
          //  SqlConnection connection = new SqlConnection();

            //connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(Query, db.sqlConn);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            //connection.Close();
        }
    }
}
