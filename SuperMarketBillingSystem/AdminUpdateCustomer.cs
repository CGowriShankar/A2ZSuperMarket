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
    public partial class AdminUpdateCustomer : Form
    {
        public AdminUpdateCustomer()
        {
            InitializeComponent();
        }

        Utility util = new Utility();
        SqlDbConnection db = new SqlDbConnection();

        string conn = @"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true";

        private void AdminUpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet13.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter1.Fill(this.a2ZSuperMarketDataSet13.Customer);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet2.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.a2ZSuperMarketDataSet2.Customer);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet3.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.a2ZSuperMarketDataSet3.Customer);
                      
            string query = "select * from customer";
            DisplayDataInGrid(query);

            label3.Enabled = false;
            label1.Enabled = false;
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            button5.Enabled = false;

            string query1 = "select custid from customer";
            SqlConnection sqlConn = new SqlConnection(conn);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(query1, sqlConn);

            SqlDataReader dr;
            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["custid"]);
            }

            sqlConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminHomePage home = new AdminHomePage();
            home.ShowDialog();
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage welcome = new WelcomePage();
            welcome.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            label3.Enabled = true;
            label1.Enabled = true;
            comboBox1.Enabled = true;
            textBox2.Enabled = true;
            button5.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            label3.Enabled = true;
            comboBox1.Enabled = true;
            label1.Enabled = false;
            textBox2.Enabled = false;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (button3.Enabled == true)
                {
                    util.Mobile = textBox2.Text;

                    if (db.EditCustomer(int.Parse(comboBox1.Text), textBox2.Text))
                    {
                        string query = "select * from Customer";

                        DisplayDataInGrid(query);

                        MessageBox.Show("Record updated!");
                    }
                    else
                    {
                        throw new Exception("Can't be edited.");
                    }

                    button3.Enabled = true;
                    button4.Enabled = true;
                    label3.Enabled = false;
                    label1.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox2.Enabled = false;
                    comboBox1.Refresh();
                    textBox2.Clear();
                }

                else if (button4.Enabled == true)
                {
                    if (db.DeleteCustomer(int.Parse(comboBox1.Text)))
                    {
                        string query = "select * from Customer";

                        DisplayDataInGrid(query);

                        MessageBox.Show("Record updated!");
                    }
                    else
                    {
                        throw new Exception("Can't be deleted.");
                    }

                    button3.Enabled = true;
                    button4.Enabled = true;
                    label3.Enabled = false;
                    label1.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox2.Enabled = false;
                    comboBox1.Refresh();
                    textBox2.Clear();
                }
            }

            catch (Exception ex)
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


       
    }
}
