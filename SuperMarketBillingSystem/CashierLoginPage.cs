using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketBillingSystem
{
    public partial class CashierLoginPage : Form
    {
        public CashierLoginPage()
        {
            InitializeComponent();
        }

         public static string cashierName = "";
         SqlDbConnection db = new SqlDbConnection();
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage home = new WelcomePage();
            home.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    throw new Exception("Please enter the ID and Password to Login!");
                }
                else
                {
                    if (db.CashierLoginCheck(textBox1.Text, textBox2.Text))
                    {
                        cashierName = db.EmployeeName(int.Parse(textBox1.Text), textBox2.Text);
                        this.Hide();
                        MessageBox.Show("  Login Successful!\n Hi " + cashierName);
                        CashierHomePage cashier1 = new CashierHomePage();
                        cashier1.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Invalid Login Credentials!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
