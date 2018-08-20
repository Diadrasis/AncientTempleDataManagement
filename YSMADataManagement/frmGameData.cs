using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmGameData : YSMADataManagement.frmTemplate
    {
        public frmGameData()
        {
            InitializeComponent();
        }

        private void frmGameData_Load(object sender, EventArgs e)
        {
            this.Text="Δεδομένα Παιχνιδιών";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGeographyMenu frm = new frmGeographyMenu();
            frm.Show();
        }
    }
}
