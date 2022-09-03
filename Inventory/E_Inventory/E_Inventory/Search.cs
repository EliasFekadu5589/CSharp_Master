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
    public partial class Search : Form
    {
        Product products;
        public Search()
        {
            InitializeComponent();
        }

        private void searchForProduct(string name)
        {
            products = Product.getProduct(name);

            if (products != null)
            {
                txt_name.Text = products.Name;
                txt_number.Text = products.InventoryNumber.ToString();
                txt_price.Text = products.Price.ToString();
                txt_date.Text = products.Date;
            }
            else
            {
                MessageBox.Show("Record not found");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchForProduct(txt_search.Text);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
