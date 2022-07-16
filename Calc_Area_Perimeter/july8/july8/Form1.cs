using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace july8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_custName.Text = "Name:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hell");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_s(object sender, EventArgs e)
        {

        }

        private void lbl_name(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btn_submit_MouseClick(object sender, MouseEventArgs e)
        {
            String name = txt_Name.Text;
            String Item_name = txt_item_name.Text;
            String price = txt_price.Text;
            String count = txt_count.Text;
            //Db connect
            //insert 
            MessageBox.Show("Hello " + name + " Your item is " + Item_name);
           


        }
    }
}
