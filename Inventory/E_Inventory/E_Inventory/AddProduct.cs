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
    public partial class AddProduct : Form
    {
        Product products;
        string size;
        public AddProduct(string username)
        {
            InitializeComponent();
            lbl_userText.Text = username;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                products = new Product();
                products.Name = txt_name.Text;
                products.InventoryNumber = int.Parse(txt_inventoryNumber.Text);
                products.Price = double.Parse(txt_price.Text);
                products.Date = Convert.ToString(dtp_date.Value);
                string colors = "";
                if(clb_color.CheckedItems.Count != 0)
                {
                    for(int i = 0; i < clb_color.CheckedItems.Count; i++)
                    {
                        colors = " " + colors + (i + 1).ToString() + ", "
                             + clb_color.CheckedItems[i].ToString() + "\n";
                    }
                }
                products.SelectedColors = colors;
                products.SelectedSize = size;
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error" + exe.Message);
            }

            var validate = new ClassValidation(products);
            if (validate.executeValidation())
            {
                products.Save();
                MessageBox.Show("Data Saved Successfully!");
                dgview_dataOutput.DataSource = null;
                dgview_dataOutput.DataSource = products.returnData();
            }
            else
            {
                MessageBox.Show("Error, Entered data is not in the correct format");
            }
            
        }

        private void rbtn_small_CheckedChanged(object sender, EventArgs e)
        {
            size = "Small";
        }

        private void rbtn_medium_CheckedChanged(object sender, EventArgs e)
        {
            size = "Medium";
        }

        private void rbtn_large_CheckedChanged(object sender, EventArgs e)
        {
            size = "Large";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_inventoryNumber.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";
            dtp_date.Value = DateTime.Now;
            while (clb_color.CheckedIndices.Count > 0)
            {
                clb_color.SetItemChecked(clb_color.CheckedIndices[0], false);
            }
            rbtn_large.Checked = false;
            rbtn_medium.Checked = false;
            rbtn_small.Checked = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
