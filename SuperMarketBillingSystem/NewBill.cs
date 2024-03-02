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
using System.Drawing.Printing;
using System.IO;

namespace SuperMarketBillingSystem
{
    public partial class NewBill : Form
    {
        public NewBill()
        {
            InitializeComponent();
        }

        SqlDbConnection db = new SqlDbConnection();
        Billing finalBill = new Billing();
        string billName = "";
        private void NewBill_Load(object sender, EventArgs e)
        {
            try
            {
                label9.Text = CashierLoginPage.cashierName;
                label10.Text = CashierNewBill.customerName;
                label11.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss");
                float billTotal = Billing.total;

                db.InsertBill(label11.Text, label9.Text, label10.Text, billTotal);

                label12.Text = db.ViewBillNumber(label11.Text);
                billName = label12.Text + " | " + label11.Text;

                listBox1.Items.Add("Items\t\t\tPrice\t\tQuantity\t\tAmount");
                listBox1.Items.Add("\n");
                listBox1.Items.Add("____________________________________________________________________________________________________________________________");
                listBox1.Items.Add("\n");

                foreach (var item in CashierNewBill.Bd)
                {
                    listBox1.Items.Add(item);
                }

                listBox1.Items.Add("\n");
                listBox1.Items.Add("____________________________________________________________________________________________________________________________");
                listBox1.Items.Add("\n");
                listBox1.Items.Add("Total amount :\t\t\t\t\t\t" + billTotal);
                listBox1.Items.Add("____________________________________________________________________________________________________________________________");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billing.total = 0;
            CashierNewBill.Bd.Clear();
            listBox1.Items.Clear();
            this.Hide();

            CashierNewBill bill1 = new CashierNewBill();
            bill1.ShowDialog();
           
        }

        Bitmap bitmap;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            PrintDialog pd1 = new PrintDialog();
            pd1.Document = printDocument1;

            DialogResult result = pd1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.DocumentName = billName;
                printDocument1.Print();
            }
        }
        
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
     
    }
}
