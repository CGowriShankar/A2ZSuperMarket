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
    public partial class AdminHomePage : Form
    {         
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            WelcomePage welcome = new WelcomePage();
            welcome.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminAddCashier cashier1 = new AdminAddCashier();
            cashier1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminUpdateCashier update1 = new AdminUpdateCashier();
            update1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminUpdateSKU sku1 = new AdminUpdateSKU();
            sku1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminUpdateCustomer customerUpdate = new AdminUpdateCustomer();
            customerUpdate.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            RequestFromCashier requests = new RequestFromCashier();
            requests.ShowDialog();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
