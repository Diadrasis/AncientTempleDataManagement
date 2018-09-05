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

            this.Width = 1200;
            dgv.Size = new Size(1100, 400);

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn1"].HeaderText = "ID";
            dgv.Columns["dataGridViewTextBoxColumn1"].Width = 60;
            

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα Χρήστη";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Κωδικός";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 100;
                       
            dgv.Columns["avatar_person"].HeaderText = "Avatar";
            dgv.Columns["avatar_person"].Width = 130;

            dgv.Columns["avatar_haircolor"].HeaderText = "Χρώμα Μαλιών";
            dgv.Columns["avatar_haircolor"].Width = 150;

            dgv.Columns["avatar_clothcolor"].HeaderText = "Χρώμα Ρούχων";
            dgv.Columns["avatar_clothcolor"].Width = 150;

            dgv.Columns["player_house_file"].HeaderText = "Σπίτι";
            dgv.Columns["player_house_file"].Width = 200;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 30;
            }

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

        private void playersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                

                if (e.ColumnIndex == dgv.Columns["score"].Index)
                {                   
                    frmScore frm = new frmScore();
                    frm.player_id = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);                   
                    frm.Show();
                }
            }
        }
    }
}
