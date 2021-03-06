﻿using MySql.Data.MySqlClient.Properties;
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
    public partial class frmGeographyTemples3 : YSMADataManagement.frmTemplate
    {
        public DataGridView dgv;
        BindingNavigator bnv;
        public int CurrentRow;

        public frmGeographyTemples3()
        {
            InitializeComponent();
        }

        private void geography_temples1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmGeographyTemples3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.geography_temples1' table. You can move, or remove it, as needed.
            //this.geography_temples1TableAdapter.Fill(this.ancienttempledbDataSet.geography_temples1);
           

            dgv = this.geography_temples1DataGridView;
            bnv = this.geography_temples1BindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Width = 1200;
            dgv.Size = new Size(1150, 500);
            this.Text = "Ναοί";

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;


            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα (el)";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 350;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Όνομα (en)";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 350;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Χ";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 40;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Υ";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 40;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Αρχείο";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 150;

            dgv.Columns["previewImg"].HeaderText = "Προεπισκόπιση";
            dgv.Columns["previewImg"].Width = 170;

            ReloadData();          

        }

        public void UpdateData()
        {
            this.Validate();
            this.geography_temples1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
        }

        public void ReloadData()
        {
            this.geography_temples1TableAdapter.Fill(this.ancienttempledbDataSet.geography_temples1);
            ShowImages();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 60;
            }
        }

        public void ShowImages()
        {
            string webImageFolder = Paths.webFolderPath;
            this.Enabled = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {

                if (row.Cells["dataGridViewTextBoxColumn4"].Value != DBNull.Value)
                {
                    String file = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + file);
                    myRequest.Method = "GET";
                    try
                    {
                        using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                        {
                            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                            row.Cells["previewImg"].Value = bmp;
                        }
                    }
                    catch
                    {
                        row.Cells["previewImg"].Value = (Image)Resources.ResourceManager.GetObject("imgNotFound");
                    }
                }
                else
                {
                    row.Cells["previewImg"].Value = Properties.Resources.imgNotFound;
                }
            }

            this.Enabled = true;
        }

        private void geography_temples1DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgv.Columns["previewImg"].Index)
                {
                    frmImage frm = new frmImage();
                    frm.templeID = Convert.ToInt16(dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value);
                    CurrentRow = e.RowIndex;
                    frm.callingGeographyTemples = this;
                    frm.dgv = dgv;
                    frm.SelectedRow = CurrentRow;
                    frm.imageFile = dgv.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    frm.Show();
                    UpdateData();
                }
            }
        }
    }
}
