using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Inventory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var validate = new ClassValidation(txt_username.Text, txt_password.Text);


            if (validate.loginManager())
            {
                Form menuForm = new Menu(txt_username.Text);
                menuForm.Show();
                Hide();
            }
            else
            {
                txt_username.Text = "";
                txt_password.Text = "";
                MessageBox.Show("Wrong Username or Password used");
            }            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
