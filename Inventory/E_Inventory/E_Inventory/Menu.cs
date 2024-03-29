﻿using System;
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
    public partial class Menu : Form
    {

        string username;
        public Menu(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var addForm = new AddProduct(username);
            addForm.MdiParent = this;
            addForm.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var searchForm = new Search();
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void viewDataInProductCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var displayForm = new DisplayProducts();
            displayForm.MdiParent = this;
            displayForm.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild;
            if (form != null)
            {
                form.Close();
            }

            var displayForm = new DisplayDetails();
            displayForm.MdiParent = this;
            displayForm.Show();
        }
    }
}
