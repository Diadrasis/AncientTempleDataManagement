﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSMADataManagement.Properties;

namespace YSMADataManagement
{
    public partial class frmImage : Form
    {
        public int templeID;
        public string imageFile;
        public string newImageFile;
        public frmGeographyTemples callingForm;
        public frmGeographyQuestion callingQuestionDetails;
        public frmDidYouKnowDetails callingDidYouKnowDetails;
        public DataGridView dgv;
        public int SelectedRow;

        public frmImage()
        {
            InitializeComponent();
        }

        private void frmGeographyTempleImage_Load(object sender, EventArgs e)
        {
            this.pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            this.label1.Text = "";
            this.button1.Visible = true;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.label1.Visible = false;
            
            ShowImage();
        }

        private void ShowImage()
        {
            if (!String.IsNullOrEmpty(imageFile))
            {               
                if (imageFile.Contains("jpg") || imageFile.Contains("png") )
                {
                    string webImageFolder = Paths.webFolderPath;
                    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(webImageFolder + imageFile);
                    myRequest.Method = "GET";
                    try
                    {
                        using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                        {
                            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                            this.pictureBox2.Image = bmp;                          
                            label2.Text = "Αρχείο:" + imageFile + " Διαστάσεις:" + bmp.Width.ToString() + " x " + bmp.Height.ToString() + " ";
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
            }
            else
            {
                this.pictureBox2.Image = (Image)Resources.ResourceManager.GetObject("imgNotFound");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox2.AllowDrop = true;
            //this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.label1.Text = "Σύρετε τη φωτογραφία...";
            this.button1.Visible = false;
            this.button2.Visible = true;
            this.button3.Visible = true;
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                //check if files are the right ones
                //create a thumb and show
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                newImageFile = filePaths[0];
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(filePaths[0]);
                this.pictureBox2.Image = bmp;
                label2.Text = "Αρχείο:" + newImageFile.Substring(newImageFile.LastIndexOf("\\") + 1) + " Διαστάσεις:" + bmp.Width.ToString() + " x " + bmp.Height.ToString() + " ";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            this.button1.Visible = true;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.pictureBox2.AllowDrop = false;
            ShowImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string f = newImageFile.Substring(newImageFile.LastIndexOf("\\") +1 );
            //dgv.Rows[SelectedRow].Cells[5].Value = f;  
            
            //upload the file
            string un = "giannisftp";
            string ps = "!giannisftp$1";
            string filePath = newImageFile;
            string serverPath="";
            if (this.callingForm!=null || this.callingQuestionDetails != null)
            {
                serverPath= Paths.ftpFolderPath;
            }
            else if (this.callingDidYouKnowDetails!=null)
            {
                serverPath = Paths.didYouKnowFolderPath;
            }
            
            
            
            try
            {
                FtpWebRequest requestExists = (FtpWebRequest)WebRequest.Create(serverPath + f);
                requestExists.Credentials = new NetworkCredential(un, ps);
                requestExists.Method = WebRequestMethods.Ftp.GetFileSize;

                FtpWebResponse responseExists = (FtpWebResponse)requestExists.GetResponse();
                DialogResult dialogResult = MessageBox.Show("Το αρχείο υπάρχει ήδη! Θέλετε να αντικατασταθεί;", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    responseExists.Close();
                    //LoadFile(serverPath, (NetworkCredential)requestExists.Credentials);
                    try
                    {

                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverPath + f);
                        request.Method = WebRequestMethods.Ftp.UploadFile;

                        // This example assumes the FTP site uses anonymous logon.
                        request.Credentials = new NetworkCredential(un, ps);

                        // Copy the contents of the file to the request stream.
                        StreamReader sourceStream = new StreamReader(newImageFile);

                        //this is for texts
                        //byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());


                        //this is for image
                        byte[] fileContents = File.ReadAllBytes(newImageFile);
                        sourceStream.Close();

                        request.ContentLength = fileContents.Length;

                        Stream requestStream = request.GetRequestStream();
                        requestStream.Write(fileContents, 0, fileContents.Length);
                        requestStream.Close();

                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        response.Close();

                        MessageBox.Show("Το αρχείο φορτώθηκε!");
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }

            }
            catch (WebException ex)
            {
                FtpWebResponse responseExists = (FtpWebResponse)ex.Response;
                if (responseExists.StatusCode ==
                    FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    try
                    {

                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverPath + f);
                        request.Method = WebRequestMethods.Ftp.UploadFile;

                        // This example assumes the FTP site uses anonymous logon.
                        request.Credentials = new NetworkCredential(un, ps);

                        // Copy the contents of the file to the request stream.
                        StreamReader sourceStream = new StreamReader(newImageFile);

                        //this is for texts
                        //byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());


                        //this is for image
                        byte[] fileContents = File.ReadAllBytes(newImageFile);
                        sourceStream.Close();

                        request.ContentLength = fileContents.Length;

                        Stream requestStream = request.GetRequestStream();
                        requestStream.Write(fileContents, 0, fileContents.Length);
                        requestStream.Close();

                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        response.Close();

                        MessageBox.Show("Το αρχείο φορτώθηκε!");
                    }
                    catch (WebException ex2)
                    {
                        MessageBox.Show(ex2.ToString());
                    }

                }
            }

            //------------------                    

            if (callingForm != null)
            {
                dgv.Rows[SelectedRow].Cells[5].Value = f;
                callingForm.UpdateData();
            }
            else if (callingQuestionDetails != null)
            {
                callingQuestionDetails.feedbackImg = f;
                callingQuestionDetails.ShowImages();
            }
            else if (callingDidYouKnowDetails!=null)
            {
                callingDidYouKnowDetails.dykImg = f;
                callingDidYouKnowDetails.ShowImage();
            }
            this.Close();         

        }

        private void LoadFile(string path, NetworkCredential credentials)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = credentials;

                // Copy the contents of the file to the request stream.
                StreamReader sourceStream = new StreamReader(newImageFile);

                //this is for texts
                //byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());


                //this is for image
                byte[] fileContents = File.ReadAllBytes(newImageFile);
                sourceStream.Close();

                request.ContentLength = fileContents.Length;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();

                MessageBox.Show("Το αρχείο φορτώθηκε!");

            }
            catch(WebException ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }
    }
}