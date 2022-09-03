using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Inventory
{
    public partial class DisplayDetails : Form
    {
        List<Product> product;
        ProductCard card;

        public DisplayDetails(List<Product> productsList, ProductCard cardCollection)
        {
            InitializeComponent();
            product = productsList;
            card = cardCollection;
        }

        private void DisplayDetails_Load(object sender, EventArgs e)
        {
            bool check = false;
            if (card != null)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (product[i].Name.Equals(card.var_ProductName))
                    {
                        txt_name.Text = product[i].Name;
                        txt_number.Text = product[i].InventoryNumber.ToString();
                        txt_price.Text = product[i].Price.ToString();
                        txt_date.Text = product[i].Date;
                        check = true;
                    }
                }
            }
            else if(card == null || check == false)
            {
                MessageBox.Show("Details not found");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
