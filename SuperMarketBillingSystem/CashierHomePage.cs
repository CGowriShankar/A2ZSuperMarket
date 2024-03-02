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
    public partial class CashierHomePage : Form
    {
        public CashierHomePage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierLoginPage cashierLogin = new CashierLoginPage();
            cashierLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierScoutSKU scoutSku = new CashierScoutSKU();
            scoutSku.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierRequestAdminToUpdateSKU requestForSKU = new CashierRequestAdminToUpdateSKU();
            requestForSKU.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierAddCustomer customer1 = new CashierAddCustomer();
            customer1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            CashierNewBill bill1 = new CashierNewBill();
            bill1.ShowDialog();                 
        }
    }
}
