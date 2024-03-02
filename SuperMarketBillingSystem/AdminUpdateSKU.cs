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
    public partial class AdminUpdateSKU : Form
    {
        public AdminUpdateSKU()
        {
            InitializeComponent();
        }

        Utility util = new Utility();
        SqlDbConnection db = new SqlDbConnection();

        string conn = @"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true";

        private void label1_Click(object sender, EventArgs e)
        {

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

            WelcomePage Home = new WelcomePage();
            Home.ShowDialog();
        }

        private void AdminUpdateSKU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet14.SKU' table. You can move, or remove it, as needed.

            //this.sKUTableAdapter1.Fill(this.a2ZSuperMarketDataSet14.SKU);

            string query = "select * from SKU";

            DisplayDataInGrid(query);                      

            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet3.SKU' table. You can move, or remove it, as needed.
            //this.sKUTableAdapter.Fill(this.a2ZSuperMarketDataSet3.SKU);
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet1.SKU' table. You can move, or remove it, as needed.
            //this.sKUTableAdapter.Fill(this.a2ZSuperMarketDataSet1.SKU);
            label1.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            comboBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button6.Enabled = false;

            string query1 = "select itemid from sku";
            SqlConnection sqlConn = new SqlConnection(conn);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(query1, sqlConn);

            SqlDataReader dr;
            dr = sqlCmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["itemid"]);
            }

            sqlConn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            comboBox1.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (button3.Enabled == true)
                {
                    if (textBox3.Text == "")
                    {
                        throw new Exception("Invalid Name!");
                    }

                    util.Quantity = textBox2.Text;
                    util.Price = textBox1.Text;

                    db.AddItem(textBox3.Text, int.Parse(textBox2.Text), float.Parse(textBox1.Text));

                    string query = "select * from SKU";

                    DisplayDataInGrid(query);    

                    MessageBox.Show("Record updated!");

                    label1.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button6.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }

                else if (button4.Enabled == true)
                {
                    util.Quantity = textBox2.Text;
                    util.Price = textBox1.Text;

                    db.UpdateItem(int.Parse(comboBox1.Text), int.Parse(textBox2.Text), float.Parse(textBox1.Text));

                    string query = "select * from SKU";

                    DisplayDataInGrid(query);

                    MessageBox.Show("Record updated!");

                    label1.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button6.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }

                else if (button5.Enabled == true)
                {
                    db.DeleteItem(int.Parse(comboBox1.Text));

                    string query = "select * from SKU";

                    DisplayDataInGrid(query);

                    MessageBox.Show("Record deleted!");

                    label1.Enabled = false;
                    label3.Enabled = false;
                    label4.Enabled = false;
                    label5.Enabled = false;
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button6.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                comboBox1.Refresh();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Enabled = false;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            comboBox1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Enabled = false;
            label3.Enabled = true;
            label4.Enabled = false;
            label5.Enabled = false;
            comboBox1.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button3.Enabled = false;
            button6.Enabled = true;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
