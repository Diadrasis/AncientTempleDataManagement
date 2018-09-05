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
    public partial class frmDidYouKnowDetails : YSMADataManagement.frmTemplate
    {
        public int dykid;
        public string dykImg;
        public frmDidYouKnow callingForm;
        public frmDidYouKnowDetails()
        {
            InitializeComponent();
        }

        private void didyouknowDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.didyouknowDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
            //callingForm.dgv.CurrentRow.Cells[6].Value = this.dykImg;            
        }       

        private void frmDidYoyKnowDetails_Load(object sender, EventArgs e)
        {
            try
            {
                this.didyouknowDetailsTableAdapter.Fill(this.ancienttempledbDataSet.didyouknowDetails, this.dykid);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            ((Label)this.Controls["questiontext_grLabel"]).Text = "Ερώτηση (gr)";
            ((Label)this.Controls["questiontext_enLabel"]).Text = "Ερώτηση (en)";
            ((Label)this.Controls["answertext_grLabel"]).Text = "Απάντηση (gr)";
            ((Label)this.Controls["answertext_enLabel"]).Text = "Απάντηση (en)";
            ((Label)this.Controls["imagefileLabel"]).Text = "Αρχείο";

            this.dykidTextBox.Visible = false;            
            this.gameidTextBox.Visible = false;
            this.Text = "Ήξερες ότι;";
            
            ShowImage();
        }

        public void ShowImage()
        {
            string webImageFolder = Paths.webDidYouKnowFolderPath;

            if (!String.IsNullOrEmpty(this.dykImg))
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + dykImg);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.imageFile = this.dykImg;
            frm.callingDidYouKnowDetails = this;
            frm.Show();
        }

        private void frmDidYouKnowDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.callingForm.UpdateData();
            this.callingForm.Reload();
        }

        public void Reload()
        {
            this.didyouknowDetailsTableAdapter.Fill(this.ancienttempledbDataSet.didyouknowDetails, this.dykid);
        }
    }
}
