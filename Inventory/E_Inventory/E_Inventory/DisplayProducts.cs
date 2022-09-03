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
    public partial class DisplayProducts : Form
    {

        Product displayData = new Product();
        List<Product> LocalList;
        ProductCard card;
        List<ProductCard> cardCollection = new List<ProductCard>();

        public DisplayProducts()
        {
            InitializeComponent();
        }

        private void DisplayProducts_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            LocalList = displayData.returnData();

            foreach (var item in LocalList)
            {
                card = new ProductCard();
                card.var_ProductName = item.Name;
                card.InventoryDate = item.Date;
                card.ProductPrice = item.Price;
                cardCollection.Add(card);

                card.Click += ProductCard_Click;

                flowLayoutPanel1.Controls.Add(card);
            }
        }


        private void ProductCard_Click(object sender, EventArgs e)
        {
            ProductCard selectedCard = null;
            for (int i = 0; i < cardCollection.Count; i++)
            {
                if (sender.Equals(cardCollection[i]))
                {
                    selectedCard = cardCollection[i];
                }
            }
            DisplayDetails detailsPage = new DisplayDetails(LocalList, selectedCard);
            detailsPage.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
