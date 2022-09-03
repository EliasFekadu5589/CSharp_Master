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
    public partial class ProductCard : UserControl
    {

        private string _product_name;

        public string var_ProductName
        {
            get { return _product_name; }
            set { _product_name = value; lbl_name.Text = value; }
        }

        private string _inventory_date;

        public string InventoryDate
        {
            get { return _inventory_date; }
            set { _inventory_date = value; lbl_inventoryNumber.Text = value; }
        }

        private double _product_price;

        public double ProductPrice
        {
            get { return _product_price; }
            set { _product_price = value; lbl_price.Text = value.ToString(); }
        }
        public ProductCard()
        {
            InitializeComponent();
        }
    }
}
