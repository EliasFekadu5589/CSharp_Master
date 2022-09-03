using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Inventory
{
    public class Product
    {

        public string Name { get; set; }
        public string Date { get; set; }
        public int InventoryNumber { get; set; }
        public double Price { get; set; }
        public string SelectedColors { get; set; }
        public string SelectedSize { get; set; }

        public static List<Product> products = new List<Product>();

        public void Save()
        {
            products.Add(this);
        }

        public List<Product> returnData()
        {
            return products;
        }

        public static Product getProduct(string name)
        {
            return products.Find(prod => prod.Name == name);
        }
    }
}
