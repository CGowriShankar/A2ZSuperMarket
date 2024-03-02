using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperMarketBillingSystem
{
     class Billing
    {
        //string item;
        //int quantity;
        //float price;
        float amount;
        public static float total = 0;

        string conn = (@"SERVER = .\SQLEXPRESS; DATABASE = A2ZSuperMarket; Integrated Security = true");

        public string AddToBill(string Item, int Quantity)
        {
            string output = "";

            SqlConnection connect = new SqlConnection(conn);
            connect.Open();

            SqlCommand sqlCmd = new SqlCommand("select price from sku where name = '" + Item + "'", connect);
            string price = Convert.ToString(sqlCmd.ExecuteScalar());
            connect.Close();

            amount = Quantity * float.Parse(price);
            total += amount;
            output = Item + "\t\t" + price + "\t\t" + Quantity + "\t\t" + amount;

            return output;
        }

    }
}
