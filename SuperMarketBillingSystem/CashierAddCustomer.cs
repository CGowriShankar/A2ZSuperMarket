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
    public partial class CashierAddCustomer : Form
    {
        public CashierAddCustomer()
        {
            InitializeComponent();
        }

        Utility util = new Utility();
        SqlDbConnection db = new SqlDbConnection();
        String conn = @"SERVER = .\SQLEXPRESS; Database = A2ZSuperMarket; Integrated Security=true";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierHomePage home = new CashierHomePage();
            home.ShowDialog();
        }

        private void CashierAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet4.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.a2ZSuperMarketDataSet4.Customer);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet4.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.a2ZSuperMarketDataSet4.Customer);

            string query = "select * from customer";
            DisplayDataInGrid(query);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                util.Name = textBox1.Text;
                util.Mobile = textBox2.Text;

                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    throw new Exception("Please enter Customer Name & Mobile!");
                }
                else
                {                    
                    db.InsertCustomer(textBox1.Text, textBox2.Text);

                    string conn = @"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true";
                    string query = "select * from Customer";
                    SqlConnection connection = new SqlConnection(conn);
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);

                    connection.Open();
                    da.Fill(a2ZSuperMarketDataSet4.Customer);
                    connection.Close();

                    dataGridView1.DataSource = a2ZSuperMarketDataSet4.Customer;

                    System.Windows.Forms.MessageBox.Show("Record added!");

                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
