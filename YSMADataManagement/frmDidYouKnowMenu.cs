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

        private void frmDidYouKnowMenu_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1100, 700);
            this.Text = "Ήξερες Ότι...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 1;
            frm.formTitle = "Γεωγραφία";
            frm.Show();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 2;
            frm.formTitle = "Επιγραφή";
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 3;
            frm.formTitle = "Τύπος";
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 4;
            frm.formTitle = "Κατασκευή";
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 5;
            frm.formTitle = "Μορφή";
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmDidYouKnow frm = new frmDidYouKnow();
            frm.gameid = 6;
            frm.formTitle = "Γλυπτική";
            frm.Show();
        }
    }
}
