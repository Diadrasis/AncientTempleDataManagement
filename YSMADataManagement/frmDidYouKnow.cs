using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmDidYouKnow : YSMADataManagement.frmTemplate
    {
        public int gameid;
        public DataGridView dgv;
        BindingNavigator bnv;
        public int CurrentRow;
        public frmDidYouKnow()
        {
            InitializeComponent();
        }

        private void didyouknowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
     

        private void frmDidYouKnow_Load(object sender, EventArgs e)
        {
            try
            {
                Reload();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            dgv = this.didyouknowDataGridView;
            bnv = this.didyouknowBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            dgv.Size = new Size(1150, 300);

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Ερώτηση (el)";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Ερώτηση (en)";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Απάντηση (ελ)";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Απάντηση (en)";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn7"].HeaderText = "Αρχείο";
            dgv.Columns["dataGridViewTextBoxColumn7"].Width = 200;

            dgv.Columns["details"].HeaderText = "Περισσότερα";
            dgv.Columns["details"].Width = 70;



        }

        private void didyouknowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
                //UpdateData();
                if (e.ColumnIndex == dgv.Columns["details"].Index)
                {
                    frmDidYouKnowDetails frm = new frmDidYouKnowDetails();
                    frm.dykid = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.callingForm = this;
                    //frm.dgv = dgv;
                    //frm.SelectedRow = CurrentRow;
                    frm.dykImg = dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                    frm.Show();
                }
            }
        }

        public void UpdateData()
        {
            this.Validate();
            this.didyouknowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
        }

        public void Reload()
        {
            this.didyouknowTableAdapter.Fill(this.ancienttempledbDataSet.didyouknow, this.gameid);
        }
    }
}
