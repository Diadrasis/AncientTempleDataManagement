using MySql.Data.MySqlClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmActivites : YSMADataManagement.frmTemplate
    {
        public int stageid;
        public DataGridView dgv;
        BindingNavigator bnv;
        public int CurrentRow;

        public frmActivites()
        {
            InitializeComponent();
        }

        private void construction_activitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UpdateData();
            Reload();
        }

      

        private void frmActivites_Load(object sender, EventArgs e)
        {           

            dgv = this.construction_activitiesDataGridView;
            bnv = this.construction_activitiesBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Text = "Δραστηριότηες";

            dgv.Size = new Size(1150, 400);

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
            dgv.Columns["dataGridViewTextBoxColumn2"].Visible = false;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Κείμενο (el)";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 300;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Κείμενο (en)";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 300;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Εικόνα";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 100;

            dgv.Columns["preview"].HeaderText = "Προεπισκόπιση";
            dgv.Columns["preview"].Width = 120;


            dgv.Columns["details"].HeaderText = "Περισσότερα";
            dgv.Columns["details"].Width = 100;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 60;
            }

            Reload();

            //ShowImages();

        }

        private void construction_activitiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                CurrentRow = e.RowIndex;               
                if (e.ColumnIndex == dgv.Columns["details"].Index)
                {
                    UpdateData();
                    Reload();
                    frmActivity frm = new frmActivity();
                    frm.activityid = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    //frm.activityImg = dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    frm.callingForm = this;
                    frm.Show();
                }
                if (e.ColumnIndex == dgv.Columns["preview"].Index)
                {
                    UpdateData();
                    frmImage frm = new frmImage();
                    frm.imageFile = dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    frm.callingActivites = this;
                    frm.Show();

                   
                }
            }
        }

        private void construction_activitiesDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dgv != null)
                {
                    if (dgv.Rows != null)
                    {
                        if (dgv.Rows[e.RowIndex] != null)
                        {
                            if (dgv.Rows[e.RowIndex].Cells != null)
                            {
                                if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"] != null) { 
                                    if (dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == DBNull.Value) {                                        
                                         dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value = this.stageid.ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

       

        public void UpdateData()
        {
            this.Validate();
            this.construction_activitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
            //Reload();           
        }

        public void Reload()
        {
            try
            {
                this.construction_activitiesTableAdapter.Fill(this.ancienttempledbDataSet.construction_activities, stageid);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            ShowImages();
        }

        public void ShowImages()
        {
            string webImageFolder = Paths.webConstructionFolderPath;
            this.Enabled = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {

                if (row.Cells["dataGridViewTextBoxColumn5"].Value != DBNull.Value)
                {
                    String file = row.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + file);
                    myRequest.Method = "GET";
                    try
                    {
                        using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                        {
                            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                            row.Cells["preview"].Value = bmp;
                        }
                    }
                    catch
                    {
                        row.Cells["preview"].Value = Properties.Resources.imgNotFound;
                    }
                }
                else
                {
                    row.Cells["preview"].Value = Properties.Resources.imgNotFound;
                }
            }

            this.Enabled = true;
        }

       
    }
}
