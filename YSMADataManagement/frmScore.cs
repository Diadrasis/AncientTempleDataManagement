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
        DataGridView dgv;
        BindingNavigator bnv;

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
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.games1' table. You can move, or remove it, as needed.
            this.games1TableAdapter.Fill(this.ancienttempledbDataSet.games1);
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.games1' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'ancienttempledbDataSet.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.ancienttempledbDataSet.players);
            try
            {
                this.scoresTableAdapter.Fill(this.ancienttempledbDataSet.scores, player_id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            this.Text = "Βαθμολογία";

            dgv = this.scoresDataGridView;
            bnv = this.scoresBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Width = 1200;
            dgv.Size = new Size(1100, 400);

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn1"].HeaderText = "ID";
            dgv.Columns["dataGridViewTextBoxColumn1"].Width = 60;


            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα Χρήστη";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 200;

            dgv.Columns["gameid"].HeaderText = "Παιχνίδι";
            dgv.Columns["gameid"].Width = 130;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Βαθμοί";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 130;
        }
    }
}
