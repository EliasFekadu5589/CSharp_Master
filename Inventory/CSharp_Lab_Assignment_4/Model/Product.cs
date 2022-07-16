using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Lab_Assignment_4.Model
{
    internal class Product
    {
        static List<Product> products = new List<Product>();
        public int Number { get; set; }
        public string Date { get; set; }
        public string Inventory { get; set; }
        public string ObjectName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public void save()
        {
            products.Add(this);
            MessageBox.Show($"{ObjectName} added to inventory!");
        }

    }
}
