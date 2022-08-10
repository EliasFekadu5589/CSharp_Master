using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lab_Assignment_4
{
    internal class Validate
    {
        // Class responsible for login validation and data validation

        //Login Validation

        public string username { get; set; }
        public string password { get; set; }

        public bool validateLogin()
        {
            bool check = false;
            if (username == "admin")
            {
                if (password == "admin")
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
