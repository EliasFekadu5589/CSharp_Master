using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
        bool recheck = false;
        private string connectionString = "Data Source = ELIJAHS_PC\\SQLSERVER2; Initial Catalog = Product_Database; Integrated Security = true";
        private static List<Product> productsCollection = new List<Product>();

        public DisplayDetails(List<Product> productsList, ProductCard cardCollection)
        {
            InitializeComponent();
            product = productsList;
            card = cardCollection;
            tableLayoutPanel1.Visible = true;
            dgv1.Visible = false;
            recheck = true;
        }

        public DisplayDetails()
        {
            InitializeComponent();
            tableLayoutPanel1.Visible = false;
            dgv1.Visible = true;
            recheck = false;
        }

        private void DisplayDetails_Load(object sender, EventArgs e)
        {
            if (recheck)
            {
                tableLayoutPanel1.Visible = false;
                dgv1.Visible = true;
            }
            else
            {
                tableLayoutPanel1.Visible = true;
                dgv1.Visible = false;
            }
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

        private void populateData()
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string select = "select * from Products_Table";
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            { 
                Product prod = new Product();
                prod.Name = Convert.ToString(reader["prodName"]);
                prod.InventoryNumber = Convert.ToInt32(reader["prodNumber"]);
                prod.Date = Convert.ToString(reader["prodDate"]);
                prod.Price = Convert.ToDouble(reader["prodPrice"]);
                productsCollection.Add(prod);
            }
            connection.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
