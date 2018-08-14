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
    public partial class frmGeographyTemples : YSMADataManagement.frmTemplate
    {
        DataGridView dgv;
        BindingNavigator bnv;

        public frmGeographyTemples()
        {
            InitializeComponent();
        }

        private void geography_templesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.geography_templesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);

        }

        private void frmGeographyTemples_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.geography_temples' table. You can move, or remove it, as needed.
            this.geography_templesTableAdapter.Fill(this.ancienttempledbDataSet.geography_temples);

            dgv = this.geography_templesDataGridView;
            bnv = this.geography_templesBindingNavigator;
            DesignerHelper.DesignDataGridView(dgv);
            DesignerHelper.DesignDataGridNavigator(bnv);

            this.Width = 1400;

            dgv.Columns["dataGridViewTextBoxColumn1"].Visible = false;
           

            dgv.Columns["dataGridViewTextBoxColumn2"].HeaderText = "Όνομα (el)";
            dgv.Columns["dataGridViewTextBoxColumn2"].Width = 300;

            dgv.Columns["dataGridViewTextBoxColumn3"].HeaderText = "Όνομα (en)";
            dgv.Columns["dataGridViewTextBoxColumn3"].Width = 300;

            dgv.Columns["dataGridViewTextBoxColumn5"].HeaderText = "Συντεταγμένες Χ";
            dgv.Columns["dataGridViewTextBoxColumn5"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn6"].HeaderText = "Συντεταγμένες Υ";
            dgv.Columns["dataGridViewTextBoxColumn6"].Width = 70;

            dgv.Columns["dataGridViewTextBoxColumn4"].HeaderText = "Αρχείο";
            dgv.Columns["dataGridViewTextBoxColumn4"].Width = 200;

            dgv.Columns["previewImg"].HeaderText = "Προεπισκόπιση";
            dgv.Columns["previewImg"].Width = 200;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Height = 60;
            }

            ShowPreviewImages();

        }

        public void ShowPreviewImages()
        {
            string webThumbsFolder = "http://ancienttemple.diadrasis.net";
            this.Enabled = false;
            foreach (DataGridViewRow row in dgv.Rows)
            {

                if (row.Cells["dataGridViewTextBoxColumn4"].Value != DBNull.Value)
                {
                    String file = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webThumbsFolder + file);
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
                    row.Cells["previewImg"].Value = (Image)Resources.ResourceManager.GetObject("imgNotFound");
                }
            }             
            
            this.Enabled = true;
        }
    }
}
