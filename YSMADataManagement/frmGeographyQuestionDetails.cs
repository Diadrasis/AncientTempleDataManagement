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
    public partial class frmGeographyQuestionDetails : YSMADataManagement.frmTemplate
    {
        public int questionID;
        public int templeID;
        public frmGeographyQuestions callingForm;
        public string templeImg;
        public string feedbackImg;

        public frmGeographyQuestionDetails()
        {
            InitializeComponent();
        }
      

        private void geography_questionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.geography_questionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ancienttempledbDataSet);
            this.callingForm.Update();
            this.callingForm.Reload();

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
           
            this.pictureBox3.Image = Properties.Resources.imgNotFound;
            //string img = GetTempleImage(this.templeID);
            //ShowImages();
        }

        private string GetTempleImage(int templeid)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.ancienttempledbConnectionString;
            SqlCommand command = new SqlCommand();
            string img = "";

            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT templeimg FROM temples WHERE templeid=@templeid";
            command.Parameters.AddWithValue("@templid", templeid);



            try
            { 
                conn.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        img = reader["templimg"].ToString();
                    }
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("could not connect!");
                img = "none";
            }
            return img;
        }

        public void ShowImages()
        {
            string webImageFolder = "http://localhost/ancienttemple/assets/images/geography/";          

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
                    this.pictureBox2.Image = (Image)Resources.ResourceManager.GetObject("imgNotFound");
                }
            }
            else
            {
                this.pictureBox2.Image = (Image)Resources.ResourceManager.GetObject("imgNotFound");
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
            frmGeographyTempleImage frm = new frmGeographyTempleImage();
            frm.imageFile = feedbackImg;
            frm.callingQuestionDetails = this;
            frm.Show();

        }

        private void frmGeographyQuestionDetails_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.callingForm.dgv.CurrentRow.Cells[6].Value = feedbackImg;
        }
    }
}
