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
    public partial class AdminUpdateCashier : Form
    {
        public AdminUpdateCashier()
        {
            InitializeComponent();
        }

        Utility util = new Utility();
        SqlDbConnection db = new SqlDbConnection();
        string conn = @"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true";

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

            WelcomePage home = new WelcomePage();
            home.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                util.Mobile = textBox2.Text;
                util.Password = textBox4.Text;

                db.UpdateCashier(int.Parse(comboBox1.Text), textBox2.Text, textBox4.Text);             

                string query = "select * from Employee";
                DisplayDataInGrid(query);
                //SqlConnection connection = new SqlConnection(conn);
                //SqlDataAdapter da = new SqlDataAdapter(query,connection);

                //connection.Open();
                //da.Fill(a2ZSuperMarketDataSet12.Employee);
                //connection.Close();

                //dataGridView1.DataSource = a2ZSuperMarketDataSet12.Employee;

                System.Windows.Forms.MessageBox.Show("Record added!");

                textBox2.Clear();
                textBox4.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminUpdateCashier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet12.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter3.Fill(this.a2ZSuperMarketDataSet12.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet11.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter2.Fill(this.a2ZSuperMarketDataSet11.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet10.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter1.Fill(this.a2ZSuperMarketDataSet10.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.a2ZSuperMarketDataSet1.Employee);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet.Cashier' table. You can move, or remove it, as needed.
            //this.cashierTableAdapter.Fill(this.a2ZSuperMarketDataSet.Cashier);

            string query = "select * from Employee";
            DisplayDataInGrid(query);

            string query1 = "select empid from Employee";
            SqlConnection sqlConn = new SqlConnection(conn);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(query1, sqlConn);

            SqlDataReader dr;
            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["empid"]);
            }

            sqlConn.Close();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
