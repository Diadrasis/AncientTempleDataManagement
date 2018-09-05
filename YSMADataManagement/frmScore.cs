using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmScore : YSMADataManagement.frmTemplate
    {
        public int player_id;
        public frmScore()
        {
            InitializeComponent();
        }

        private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);

        }       

        private void frmScore_Load(object sender, EventArgs e)
        {
            try
            {
                this.scoresTableAdapter.Fill(this.ancienttempledbDataSet.scores, player_id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
