using CSharp_Lab_Assignment_4.Model;
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
{    public partial class Form1 : Form
    {
        public Form1(string username)
        {

            InitializeComponent();
            whologin.Text = username;
        }

        public Form1()
        {

            InitializeComponent();
            whologin.Text = "default";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product P = new Product
            {
                Number = Convert.ToInt32(txt_Number.Text),
                Date = txt_date.Text,
                Inventory = txt_inventoryNumber.Text,
                ObjectName = txt_objectName.Text,
                Count = Convert.ToInt32(txt_count.Text),
                Price = Convert.ToDouble(txt_price.Text)
            };
           // prop.add(p);

            P.save();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Number.Text = "";
            txt_date.Text = "";
            txt_inventoryNumber.Text = "";
            txt_objectName.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
