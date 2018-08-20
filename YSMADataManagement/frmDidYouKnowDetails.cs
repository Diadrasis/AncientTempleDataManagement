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
        public frmDidYouKnowDetails()
        {
            InitializeComponent();
        }

        private void didyouknowDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.didyouknowDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);

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

            ShowImage();
        }

        public void ShowImage()
        {
            string webImageFolder = Paths.webFolderPath;

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
    }
}
