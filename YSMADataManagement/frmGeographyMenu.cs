using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmGeographyMenu : YSMADataManagement.frmTemplate
    {
        public frmGeographyMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGeographyTemples frm = new frmGeographyTemples();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGeographyQuestions frm = new frmGeographyQuestions();
            frm.Show();
        }

        private void frmGeographyMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Δεδομένα Γεωγραφίας";
        }
    }
}
