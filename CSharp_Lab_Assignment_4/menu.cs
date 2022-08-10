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
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = ActiveMdiChild;
            if (Form != null)
            {
                Form.Close();
            }
            
            
            Form form = new Form1();
            form.MdiParent=this;
            form.Show();



        }
    }
}
