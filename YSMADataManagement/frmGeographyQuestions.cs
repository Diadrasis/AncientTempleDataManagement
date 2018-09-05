using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmGeographyQuestions : YSMADataManagement.frmTemplate
    {
        public DataGridView dgv;
        BindingNavigator bnv;
        public int CurrentRow;

        public frmGeographyQuestions()
        {
            InitializeComponent();
        }

        private void geography_questionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void frmGeographyQuestions_Load(object sender, EventArgs e)
        {
           

            dgv = this.geography_questionsDataGridView;
            bnv = this.geography_questionsBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Size = new Size(1200, 600);
            dgv.Size = new Size(1150, 300);

            

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;


            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Κείμενο (el)";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Κείμενο (en)";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 200;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Ναός";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 200;

            dgv.Columns["temple_file"].Visible=false;
           

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Ανάδραση (el)";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 160;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Ανάδραση (en)";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 160;

            dgv.Columns["feedbackImg"].HeaderText = "Εικόνα Ανάδρασης";
            dgv.Columns["feedbackImg"].Width = 160;

            dgv.Columns["details"].HeaderText = "";
            dgv.Columns["details"].Width = 70;

            Reload();

        }

        private void geography_questionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;
               
                if (e.ColumnIndex == dgv.Columns["details"].Index)
                {
                    UpdateData();
                    frmGeographyQuestion frm = new frmGeographyQuestion();
                    frm.questionID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    frm.templeID= Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value);
                    //frm.templeImg= dgv.Rows[e.RowIndex].Cells["temple_file"].FormattedValue.ToString();
                    frm.feedbackImg= dgv.Rows[e.RowIndex].Cells["feedbackImg"].Value.ToString();

                    frm.callingForm = this;
                    //frm.dgv = dgv;
                    //frm.SelectedRow = CurrentRow;
                    //frm.imageFile = dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    frm.Show();
                }
            }
        }

        public void UpdateData()
        {
            this.Validate();
            this.geography_questionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
        }

        public void Reload()
        {
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.geography_temples' table. You can move, or remove it, as needed.
            //this.geography_templesTableAdapter.Fill(this.ancienttempledbDataSet.geography_temples1);
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.geography_questions' table. You can move, or remove it, as needed.
            this.geography_temples1TableAdapter.Fill(this.ancienttempledbDataSet.geography_temples1);
            this.geography_questionsTableAdapter.Fill(this.ancienttempledbDataSet.geography_questions);
        }
    }
}
