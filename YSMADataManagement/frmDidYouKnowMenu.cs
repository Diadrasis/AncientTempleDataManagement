using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmDidYouKnowMenu : YSMADataManagement.frmTemplate
    {
        public frmDidYouKnowMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 2;
            frm.Show();
        }

        private void frmDidYouKnowMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1100, 700);
            this.Text = "Ήξερες Ότι...";
        }
    }
}
