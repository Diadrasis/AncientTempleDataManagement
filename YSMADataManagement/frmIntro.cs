using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmIntro : YSMADataManagement.Form1
    {
        public int gameid;
        public frmIntro()
        {
            InitializeComponent();
        }

        private void gamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gamesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);

        }      

        private void frmIntro_Load(object sender, EventArgs e)
        {
            try
            {
                this.gamesTableAdapter.Fill(this.ancienttempledbDataSet.games, gameid );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
