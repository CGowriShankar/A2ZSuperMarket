using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;  
using System.Threading.Tasks;

namespace SuperMarketBillingSystem
{
    class Utility
    {
        string name;

        public string Name
        {
            //get { return name; }
            set
            {
                if (NameCheck(value))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Invalid Name!");
                }
            }
        }

        string mobile;

        public string Mobile
        {
            //get { return mobile; }
            set
            {
                if (CheckMobile(value))
                {
                    mobile = value;
                }
                else
                {
                    throw new Exception("Invalid Mobile number!");
                }
            }
        }

        string quantity;

        public string Quantity
        {
            //get { return quantity; }
            set
            {
                if (QuantityCheck(value))
                {
                    quantity = value;
                }
                else
                {
                    throw new Exception ("Invalid Quantity!");
                }
            }
        }

        string price;

        public string Price
        {
            //get { return price; }
            set
            {
                if (PriceCheck(value))
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Invalid Price!");
                }
            }
        }

        string password;

        public string Password
        {
            //get { return password; }
            set
            {
                if (CheckPassword(value))
                {
                    password = value;
                }
                else
                {
                    throw new Exception("\tInvalid Password!\n\nPassword should contain.\n*Length should be 5 to 8\n*Atleast one uppercase letter\n*Atleast a number.");
                }
            }
        }




        /* Function's */
         
        public bool NameCheck(string input)
        {
            bool isName = true;

            char[] temp = input.ToCharArray();

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] >= 65 & temp[i] <= 90 | temp[i] >= 97 & temp[i] <= 122 | temp[i] == 32)
                {
                    continue;
                }
                else
                {
                    isName = false;
                    break;
                }
            }
            return isName;
        }

        public bool CheckMobile(string input)
        {
            bool isMobile = true;

            char[] temp = input.ToCharArray();

            if (temp.Length == 10)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    //if (char.IsNumber(temp[i]))
                    //{
                    //}

                    if (temp[i] >= 48 & temp[i] <= 57)
                    {
                        continue;
                    }
                    else
                    {
                        isMobile = false;
                        break;
                    }
                }
            }
            else
            {
                isMobile = false;
            }
            return isMobile;
        }

        public bool CheckPassword(string input)
        {
            bool isPass = false;
            bool isUpper = false;
            bool isDigit = false;

            char[] temp = input.ToCharArray();

            if (temp.Length >= 5 && temp.Length <= 8)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] >= 65 && temp[i] <= 90)
                    {
                        isUpper = true;
                    }
                    else if (temp[i] >= 48 & temp[i] <= 57)
                    {
                        isDigit = true;
                    }
                }
                if (isUpper == true && isDigit == true)
                {
                    isPass = true;
                }
            }
            else
            {
                isPass = false;
            }          
            return isPass;
        }

        public bool QuantityCheck(string input)
        {            
            bool isCorrect = true;

            char[] temp = input.ToCharArray();

            if (temp.Length >= 1 && temp.Length <= 4)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] >= 48 && temp[i] <= 57)
                    {
                        continue;
                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }
            else
            {
                isCorrect = false;
            }

            return isCorrect;
        }

        public bool PriceCheck(string input)
        {
            bool isCorrect = true;

            char[] temp = input.ToCharArray();

            if (temp.Length >= 1 && temp.Length <= 7)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] >= 48 && temp[i] <= 57 || temp[i] == 46)
                    {
                        continue;
                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }
            else
            {
                isCorrect = false;
            }

            return isCorrect;
        }




    }
}
