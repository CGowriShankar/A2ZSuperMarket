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
    public partial class AdminAddCashier : Form
    {
        public AdminAddCashier()
        {
            InitializeComponent();
        }

        Utility util = new Utility();
        SqlDbConnection db = new SqlDbConnection();
        string conn = @"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true";

        private void AdminAddCashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet9.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter1.Fill(this.a2ZSuperMarketDataSet9.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.a2ZSuperMarketDataSet.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet7.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.a2ZSuperMarketDataSet7.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet.Cashier' table. You can move, or remove it, as needed.
            //this.cashierTableAdapter.Fill(this.a2ZSuperMarketDataSet.Cashier);

            string query = "select * from Employee";
            DisplayDataInGrid(query);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminHomePage adminHome = new AdminHomePage();
            adminHome.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage adminLogout = new WelcomePage();
            adminLogout.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                util.Name = textBox1.Text;
                util.Mobile = textBox2.Text;
                util.Password = textBox4.Text;        

                db.InsertCashier(textBox1.Text, textBox2.Text, textBox4.Text);

                string query = "select * from Employee";
                DisplayDataInGrid(query);

                //SqlConnection connection = new SqlConnection(conn);
                //SqlDataAdapter da = new SqlDataAdapter(query, connection);

                //connection.Open();
                //da.Fill(a2ZSuperMarketDataSet9.Employee);
                //connection.Close();

                //dataGridView1.DataSource = a2ZSuperMarketDataSet9.Employee;

                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
