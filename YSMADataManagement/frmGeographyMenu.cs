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
            frmGeographyTemples2 frm = new frmGeographyTemples2();
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmGeographyTemples2 frm = new frmGeographyTemples2();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmGeographyTemples3 frm = new frmGeographyTemples3();
            frm.Show();
        }
    }
}
