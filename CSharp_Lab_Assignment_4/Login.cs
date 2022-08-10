using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Lab_Assignment_4
{
    public partial class Login : Form
    {
        Form eForm;
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var check = false;
            var valObj = new Validate();
            valObj.username = usernametextbox.Text;
            valObj.password = passwordtxtbox.Text;
            check = valObj.validateLogin();
            if (!check)
            {
                MessageBox.Show("Username or Password incorrect");
                usernametextbox.Text = "";
                passwordtxtbox.Text = "";
            }
            else
            {
                eForm = new Form1(usernametextbox.Text);
                eForm.Show();
                /*Form menu = new menu();
                menu.Show();*/
                Hide();
            }
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
