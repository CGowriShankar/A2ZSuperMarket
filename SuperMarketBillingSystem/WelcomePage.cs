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
    public partial class WelcomePage : Form
    {         
        public WelcomePage()
        {
            InitializeComponent();
        }

        SqlDbConnection db = new SqlDbConnection();

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdminLoginPage adminLogin = new AdminLoginPage();
            adminLogin.ShowDialog();
            this.Close();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashierLoginPage cashier1 = new CashierLoginPage();
            cashier1.ShowDialog();
            this.Close();
        }

        
    }
}
