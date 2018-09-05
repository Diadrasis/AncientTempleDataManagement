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
    public partial class frmActivity : YSMADataManagement.frmTemplate
    {
        public int activityid;
        //public string activityImg;
        public frmActivites callingForm;

        public frmActivity()
        {
            InitializeComponent();
        }

        private void construction_activityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            UpdateData();           
        }        

        private void frmActivity_Load(object sender, EventArgs e)
        {

            this.Text = "Δραστηριότητα";

            this.Controls["activity_idTextBox"].Visible = false;
            this.Controls["stage_idTextBox"].Visible = false;
            this.Controls["activity_desc_enLabel"].Text = "Κείμενο Δραστηριότητας (en)";
            this.Controls["activity_imageLabel"].Text = "Αρχείο εικόνας";
            this.Controls["activity_desc_grLabel"].Text = "Κείμενο Δραστηριότητας (gr)";
            this.Controls["activity_desc_enLabel"].Text = "Κείμενο Δραστηριότητας (en)";
            this.Controls["activity_imageLabel"].Text = "Αρχείο εικόνας";

            this.Size = new Size(1200, 550);

            ReloadData();
                     
        }       

        public void UpdateData()
        {         
            this.Validate();
            this.construction_activityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
            ReloadData();
        }

        public void ReloadData()
        {
            try
            {
                this.construction_activityTableAdapter.Fill(this.ancienttempledbDataSet.construction_activity, this.activityid);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            ShowImage();
        }

        public void ShowImage()
        {
            string webImageFolder = Paths.webConstructionFolderPath;

            if (!String.IsNullOrEmpty(this.activity_imageTextBox.Text))
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + this.activity_imageTextBox.Text);
                myRequest.Method = "GET";
                try
                {
                    using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                    {
                        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                        this.pictureBox2.Image = (Image)bmp;
                    }
                }
                catch
                {
                    this.pictureBox2.Image = Properties.Resources.imgNotFound;
                }
            }
            else
            {
                this.pictureBox2.Image = Properties.Resources.imgNotFound;
            }
        }

        private void frmActivity_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.callingForm.UpdateData();
            this.callingForm.Reload();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.imageFile = this.activity_imageTextBox.Text;
            frm.callingActivity = this;
            frm.Show();
        }
    }
}
