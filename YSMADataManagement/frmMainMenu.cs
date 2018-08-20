using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmMainMenu : YSMADataManagement.frmTemplate
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGameMenu frm = new frmGameMenu();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGameData frm = new frmGameData();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDidYouKnowMenu frm = new frmDidYouKnowMenu();
            frm.Show();
        }
    }
}
