using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmGameMenu : YSMADataManagement.frmTemplate
    {
        public frmGameMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIntro frm = new frmIntro();
            frm.gameid = 2;
            frm.Show();
        }

        private void frmGameMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1100, 700);
            this.Text = "Εισαγωγές Παιχνιδιών";
        }
    }
}
