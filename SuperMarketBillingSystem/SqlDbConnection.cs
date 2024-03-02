using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;        //For SQL Server only
//using System.Data.OleDb;          //For other DB like ORacle, MySql

namespace SuperMarketBillingSystem
{
     public class SqlDbConnection
    {
         public SqlConnection sqlConn = new SqlConnection(@"SERVER=.\SQLEXPRESS; Database=A2ZSuperMarket; Integrated Security=true");

         //DateTime dT;

         public bool AdminLoginCheck(string ID, string PW)
        {
            bool isAdmin = false;

            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("select emppw from employee where empid = '"+ID+"' AND emptype = 'Admin'", sqlConn);
                string pass = sqlCmd.ExecuteScalar().ToString();

                if (pass == PW)
                {
                    isAdmin = true;
                }
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }            
        
            finally
            {
                sqlConn.Close();              
            }

            return isAdmin;
        }

         public bool CashierLoginCheck(string ID, string PW)
         {
             bool isCashier = false;

             try
             {
                 sqlConn.Open();
                 SqlCommand sqlCmd = new SqlCommand("select emppw from employee where empid = '"+ID+"' AND emptype ='Cashier'", sqlConn);
                 string pass = sqlCmd.ExecuteScalar().ToString();

                 if (pass == PW)
                 {
                     isCashier = true;
                 }
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }
             finally
             {
                 sqlConn.Close();
             }
             return isCashier;
         }

        public bool InsertCashier(string Name, string Mobile, string PW)
        {
            try
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "insert into Employee values('Cashier', '"+Name+"', '"+PW+"', '"+Mobile+"')";
                sqlCmd.ExecuteNonQuery();

                SqlCommand sqlCmd1 = new SqlCommand("select EmpID from Employee where EmpMobile = '" + Mobile + "'", sqlConn);
                System.Windows.Forms.MessageBox.Show("  Record added!\nNew Employee ID: " + sqlCmd1.ExecuteScalar());
                return true;
            }

            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

            finally
            {
                sqlConn.Close();
            }
        }

        public bool UpdateCashier(int ID, string Mobile, string PW)
        {
            try
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("update employee set EmpMobile = '"+Mobile+"' , EmpPw = '"+PW+"' where EmpID = '"+ID+"' AND emptype = 'Cashier'", sqlConn);

                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();              
            }
        }

        public bool EditCustomer(int ID, string Mobile)
        {
            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("update Customer set Mobile = '"+Mobile+"' where CustID = '"+ID +"'",sqlConn);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public bool DeleteCustomer(int ID)
        {
            try
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("delete from Customer where CustID = '"+ ID +"'", sqlConn);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public bool AddItem(string Name, int Quantity, float Price)
        {
            try
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("insert into SKU values('"+Name+"', " +Quantity+", "+Price+")", sqlConn);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public bool UpdateItem(int ID, int Quantity, float Price)
        {
            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("update SKU set Qty = '" + Quantity + "', Price = '" + Price + "' where ItemID = '" + ID + "'",sqlConn);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public bool DeleteItem(int ID)
        {
            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("delete from SKU where ItemID = '"+ ID +"'", sqlConn);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public bool InsertCustomer(string Name, string Mobile)
        {
            try
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("insert into Customer values('"+Name+"','"+Mobile+"')", sqlConn);
                sqlCmd.ExecuteNonQuery();
            
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }
         
        public bool InsertRequest(string ItemName)
        {
            try
            {
                sqlConn.Open();

                SqlCommand sqlCmd = new SqlCommand("insert into RequestFromCashier values('"+ItemName+"')", sqlConn);
                sqlCmd.ExecuteNonQuery();
                //System.Windows.Forms.MessageBox.Show("Record added!");
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public string EmployeeName(int ID, string PW)
        {
            string name = "";
            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("select empname from employee where empid ='"+ID+"' AND emppw = '"+PW+"'", sqlConn);
                name = sqlCmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return name;
        }

        public bool InsertBill(string DateTime, string CashierName, string CustomerName, float Total)
        {

            //dT = Convert.ToDateTime(DateTime);

            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("insert into bill values('"+DateTime+"', '"+CashierName+"', '"+CustomerName+"', '"+Total+"')", sqlConn);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

        public string ViewBillNumber(string DateTime)
        {
            string output = "";

            try
            {
                sqlConn.Open();
                SqlCommand sqlCmd = new SqlCommand("select billnumber from bill where billdatetime = '"+DateTime+"' ", sqlConn);
                output = sqlCmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            return output;
        }



    }   
}
