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
    public partial class CashierNewBill : Form
    {
        public CashierNewBill()
        {
            InitializeComponent();
        }

        string conn = @"SERVER = .\SQLEXPRESS; Database = A2ZSuperMarket; Integrated Security = true";

        public static string customerName = "";
        public static List<string> Bd = new List<string>();
     
        private void CashierNewBill_Load(object sender, EventArgs e)
        {
            string query = "select * from Customer";

            DisplayDataInGrid(query);

            string query1 = "select name from sku";
            SqlConnection sqlConn = new SqlConnection(conn);

            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(query1, sqlConn);

            SqlDataReader dr;
            dr = sqlCmd.ExecuteReader();

             while (dr.Read())
	        {
                comboBox1.Items.Add(dr["name"]);
	        }

            sqlConn.Close();            

               textBox3.Enabled = false;
               textBox4.Enabled = false;
               comboBox1.Text = "Select Item";
               comboBox1.Enabled = false;
               numericUpDown1.Enabled = false;
               button2.Enabled = false;
               button3.Enabled = false;
               button4.Enabled = false;
               button5.Enabled = false;
               label5.Enabled = false;
               label7.Enabled = false;
               label8.Enabled = false;
               listBox1.Enabled = false;
               listBox1.Items.Add("Items\t\t\tPrice\t\tQuantity\t\tAmount");
               listBox1.Items.Add("\n");
               listBox1.Items.Add("____________________________________________________________________________________________________________________________");
               listBox1.Items.Add("\n");       

// TODO: This line of code loads data into the 'a2ZSuperMarketDataSet5.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.a2ZSuperMarketDataSet5.Customer);

        
            // TODO: This line of code loads data into the 'a2ZSuperMarketDataSet4.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.a2ZSuperMarketDataSet4.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierHomePage home = new CashierHomePage();
            home.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from customer where name like '" + textBox1.Text + "%" + "'";

            DisplayDataInGrid(query);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from customer where name like '"+textBox1.Text+"%"+"' AND mobile like '"+textBox2.Text+"%"+"'";

            DisplayDataInGrid(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "select * from customer where name like '" + textBox1.Text + "%" + "' AND mobile like '" + textBox2.Text + "%" + "'";

            DisplayDataInGrid(query);

            label8.Enabled = true;
            button2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Enabled = true;
            label7.Enabled = true;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            listBox1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            NewBill bill1 = new NewBill();
            bill1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button4.Enabled = true;
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerName = textBox3.Text;                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {          
            try
            {
                if (comboBox1.Text == "" || numericUpDown1.Value == 0)
                {
                    throw new Exception("Required fields cannot be empty or zero!");
                }
                else
                {                    
                    Billing bill = new Billing();
                    string billContent = bill.AddToBill(comboBox1.Text, Convert.ToInt32(numericUpDown1.Value));
                    listBox1.Items.Add(billContent);
                    Bd.Add(billContent);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboBox1.Text = "Select Item";
            numericUpDown1.Value = 0;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }      
    }    
}
