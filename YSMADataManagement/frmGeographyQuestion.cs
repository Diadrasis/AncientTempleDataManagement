using MySql.Data.MySqlClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace YSMADataManagement
{
    public partial class frmGeographyQuestion : YSMADataManagement.frmTemplate
    {
        public int questionID;
        public int templeID;
        public frmGeographyQuestions callingForm;
        public string templeImg;
        public string feedbackImg;

        public frmGeographyQuestion()
        {
            InitializeComponent();
        }
      

        private void geography_questionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.geography_questionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
            this.callingForm.dgv.CurrentRow.Cells[7].Value = feedbackImg;
            this.ShowImages();
            //this.callingForm.UpdateData();
            //this.callingForm.Reload();  
        }

        private void frmGeographyQuestionDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ancienttempledbDataSet.geography_temples' table. You can move, or remove it, as needed.
            this.geography_templesTableAdapter.Fill(this.ancienttempledbDataSet.geography_temples);
            try
            {
                this.geography_questionTableAdapter.Fill(this.ancienttempledbDataSet.geography_question, questionID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //this.pictureBox3.Image = Properties.Resources.imgNotFound;
            //string img = GetTempleImage(this.templeID);
            this.questidTextBox.Visible = false;
            ShowImages();
        }      

        public void ShowImages()
        {
            string webImageFolder = Paths.webFolderPath;          

            if (!String.IsNullOrEmpty(this.templeImg))
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + templeImg);
                myRequest.Method = "GET";
                try
                {
                    using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                    {
                        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                        this.pictureBox2.Image=(Image)bmp;
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

            if (!String.IsNullOrEmpty(this.feedbackImg))
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + feedbackImg);
                myRequest.Method = "GET";
                try
                {
                    using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                    {
                        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                        this.pictureBox3.Image = (Image)bmp;
                    }
                }
                catch
                {
                    this.pictureBox3.Image = Properties.Resources.imgNotFound;
                }
            }
            else
            {
                this.pictureBox3.Image = Properties.Resources.imgNotFound;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmGeographyImage frm = new frmGeographyImage();
            frm.imageFile = feedbackImg;
            frm.callingQuestionDetails = this;
            frm.Show();

        }

        private void frmGeographyQuestionDetails_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.callingForm.dgv.CurrentRow.Cells[7].Value = feedbackImg;
            this.callingForm.UpdateData();
            this.callingForm.Reload();

        }

        private void templeidComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Image = null;
        }
    }
}
