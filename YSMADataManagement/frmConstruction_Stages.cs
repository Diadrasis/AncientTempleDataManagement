using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmConstruction_Stages : YSMADataManagement.frmTemplate
    {

        public DataGridView dgv;
        BindingNavigator bnv;
        int CurrentRow;

        public frmConstruction_Stages()
        {
            InitializeComponent();
        }

        private void construction_stagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.construction_stagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);

        }

        private void frmConstruction_Stages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.construction_stages' table. You can move, or remove it, as needed.
            this.construction_stagesTableAdapter.Fill(this.ancienttempledbDataSet.construction_stages);

            dgv = this.construction_stagesDataGridView;
            bnv = this.construction_stagesBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Width = 1200;
            dgv.Size = new Size(1100, 400);
            this.Text = "Στάδια Κατασκευής";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;


            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα (el)";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 300;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Όνομα (en)";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 300;

            dgv.Columns["activites"].HeaderText = "Δραστηριότητες";
            dgv.Columns["activites"].Width = 300;



        }

        private void construction_stagesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                //UpdateData();
                if (e.ColumnIndex == dgv.Columns["activites"].Index)
                {                   
                    frmActivites frm = new frmActivites();
                    frm.stageid = Convert.ToInt16(dgv.Rows[CurrentRow].Cells["dataGridViewTextBoxColumn1"].Value);                   
                    frm.Show();
                }
            }
        }
    }
}
