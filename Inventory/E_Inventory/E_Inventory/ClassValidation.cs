using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E_Inventory
{
    public class ClassValidation
    {
        Product value;

        private string correctUsername = "admin";
        private string correctPassword = "admin";
        private string username = "";
        private string password = "";

        public ClassValidation(Product value)
        {
            this.value = value;
        }

        public ClassValidation(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool executeValidation()
        {
            if (!validateStrings())
            {
                return false;
            }
            else if (!validateNumbers())
            {
                return false;
            }
            else if (!validatePrice())
            {
                return false;
            }
            return true;
        }

        public bool loginManager()
        {
            if (validateUsername(username))
            {
                if (validatePassword(password))
                {
                    if (checkLoginDetail(username, password))
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        private bool validateStrings()
        {
            Regex name = new Regex("^[A-Za-z0-9\\s]{2,50}$");

            if (name.IsMatch(value.Name))
            {
                return true;
            }
            return false;
        }

        private bool validateNumbers()
        {
            Regex Num = new Regex("^[1-9]{1,15}$");

            if (Num.IsMatch(value.InventoryNumber.ToString()))
            {
                return true;
            }
            return false;
        }

        private bool validatePrice()
        {
            Regex price = new Regex("^[0-9]{1,6}[.]{0,1}[0-9]{1,2}$");

            if (price.IsMatch(value.Price.ToString()))
            {
                return true;
            }
            return false;
        }

        private bool validateUsername(string username)
        {
            Regex regUname = new Regex("^[A-Za-z]{2,50}$");
            if (regUname.IsMatch(username))
            {
                return true;
            }
            return false;
        }

        private bool validatePassword(string password)
        {
            Regex regUname = new Regex("^[A-Za-z0-9\\s]{2,50}$");
            if (regUname.IsMatch(password))
            {
                return true;
            }
            return false;
        }

        private bool checkLoginDetail(string username, string password)
        {
            if (username == correctUsername)
            {
                if (password == correctPassword)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
