using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmConstruvtionMenu : YSMADataManagement.frmTemplate
    {
        public frmConstruvtionMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmConstruction_Stages frm = new frmConstruction_Stages();
            frm.Show();
        }

        private void frmConstruvtionMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Κατασκευή";
        }
    }
}
