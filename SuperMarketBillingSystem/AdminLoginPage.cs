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
    public partial class AdminLoginPage : Form
    {

        Billing admin1 = new Billing();
        Utility util = new Utility();
        SqlDbConnection db = new SqlDbConnection();
        
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLoginCredentialsPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter the ID and Password to Login!");
            }
            else
            {
                try
                {
                    if (db.AdminLoginCheck(textBox1.Text, textBox2.Text))
                    {
                        string AdminName = db.EmployeeName(int.Parse(textBox1.Text), textBox2.Text);
                        this.Hide();
                        MessageBox.Show("  Login Successful!\n Hi " + AdminName);
                        AdminHomePage adminHome = new AdminHomePage();
                        adminHome.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Invalid Login Credentials!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage welcome = new WelcomePage();
            welcome.ShowDialog();
         
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage welcome = new WelcomePage();
            welcome.ShowDialog();
        }

        
        
        
    }
}
