using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Mgmt
{
    public partial class Medical_certificate : UserControl
    {
        public Medical_certificate()
        {
            InitializeComponent();
        }

        private string Pat_Name;

        public string Exp_Pat_Name
        {
            get { return Pat_Name; }
            set { Pat_Name = value; lbl_Patient_Name.Text = value;  }
        }
        private string Doc_Name;

        public string Exp_Doc_Name
        {
            get { return Doc_Name; }
            set { Doc_Name = value; lbl_Doc_Name.Text = value; }
        }

        private string Medicine;

        public string Exp_Medicine
        {
            get { return Medicine; }
            set { Medicine = value; lbl_Medicine.Text = value; }
        }

        private void lbl_Patient_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
