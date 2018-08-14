using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmUsers : YSMADataManagement.frmTemplate
    {
        DataGridView dgv;
        BindingNavigator bnv;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.ancienttempledbDataSet.players);
            this.Text = "Παίκτες";

            dgv = this.playersDataGridView;
            bnv = this.playersBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Width = 1400;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn1"].HeaderText = "ID";
            dgv.Columns["dataGridViewTextBoxColumn1"].Width = 60;
            

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα Χρήστη";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 550;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Κωδικός";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 200;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text != ""){
                this.playersBindingSource.Filter = "playername like '%" + this.textBox2.Text.Trim() + "%' or playerpsw like '%" + this.textBox2.Text.Trim() + "%'";
            }
            else
            {
                this.playersBindingSource.RemoveFilter();
            }
        }
    }
}
