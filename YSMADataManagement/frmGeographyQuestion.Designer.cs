﻿namespace YSMADataManagement
{
    partial class frmGeographyQuestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label questtext_grLabel;
            System.Windows.Forms.Label questtext_enLabel;
            System.Windows.Forms.Label templeidLabel;
            System.Windows.Forms.Label feedbacktext_grLabel;
            System.Windows.Forms.Label feedbacktext_enLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeographyQuestion));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.geography_questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geography_questionTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.geography_questionTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.geography_questionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.geography_questionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.questidTextBox = new System.Windows.Forms.TextBox();
            this.questtext_grTextBox = new System.Windows.Forms.TextBox();
            this.questtext_enTextBox = new System.Windows.Forms.TextBox();
            this.feedbacktext_grTextBox = new System.Windows.Forms.TextBox();
            this.feedbacktext_enTextBox = new System.Windows.Forms.TextBox();
            this.templeidComboBox = new System.Windows.Forms.ComboBox();
            this.geographytemples1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.feedback_imgTextBox = new System.Windows.Forms.TextBox();
            this.geography_temples1TableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.geography_temples1TableAdapter();
            questtext_grLabel = new System.Windows.Forms.Label();
            questtext_enLabel = new System.Windows.Forms.Label();
            templeidLabel = new System.Windows.Forms.Label();
            feedbacktext_grLabel = new System.Windows.Forms.Label();
            feedbacktext_enLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingNavigator)).BeginInit();
            this.geography_questionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemples1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // questtext_grLabel
            // 
            questtext_grLabel.AutoSize = true;
            questtext_grLabel.Location = new System.Drawing.Point(12, 151);
            questtext_grLabel.Name = "questtext_grLabel";
            questtext_grLabel.Size = new System.Drawing.Size(155, 17);
            questtext_grLabel.TabIndex = 5;
            questtext_grLabel.Text = "Κείμενο Ερώτησης (ελ):";
            // 
            // questtext_enLabel
            // 
            questtext_enLabel.AutoSize = true;
            questtext_enLabel.Location = new System.Drawing.Point(419, 151);
            questtext_enLabel.Name = "questtext_enLabel";
            questtext_enLabel.Size = new System.Drawing.Size(158, 17);
            questtext_enLabel.TabIndex = 7;
            questtext_enLabel.Text = "Κείμενο Ερώτησης (en):";
            // 
            // templeidLabel
            // 
            templeidLabel.AutoSize = true;
            templeidLabel.Location = new System.Drawing.Point(831, 122);
            templeidLabel.Name = "templeidLabel";
            templeidLabel.Size = new System.Drawing.Size(48, 17);
            templeidLabel.TabIndex = 9;
            templeidLabel.Text = "Ναός:";
            // 
            // feedbacktext_grLabel
            // 
            feedbacktext_grLabel.AutoSize = true;
            feedbacktext_grLabel.Location = new System.Drawing.Point(12, 381);
            feedbacktext_grLabel.Name = "feedbacktext_grLabel";
            feedbacktext_grLabel.Size = new System.Drawing.Size(166, 17);
            feedbacktext_grLabel.TabIndex = 11;
            feedbacktext_grLabel.Text = "Κείμενο Ανάδρασης (ελ):";
            // 
            // feedbacktext_enLabel
            // 
            feedbacktext_enLabel.AutoSize = true;
            feedbacktext_enLabel.Location = new System.Drawing.Point(419, 381);
            feedbacktext_enLabel.Name = "feedbacktext_enLabel";
            feedbacktext_enLabel.Size = new System.Drawing.Size(169, 17);
            feedbacktext_enLabel.TabIndex = 13;
            feedbacktext_enLabel.Text = "Κείμενο Ανάδρασης (en):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(825, 348);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(175, 17);
            label1.TabIndex = 18;
            label1.Text = "Φωτογραφία Ανάδρασης:";
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geography_questionBindingSource
            // 
            this.geography_questionBindingSource.DataMember = "geography_question";
            this.geography_questionBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // geography_questionTableAdapter
            // 
            this.geography_questionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.construction_activitiesTableAdapter = null;
            this.tableAdapterManager.construction_activityTableAdapter = null;
            this.tableAdapterManager.construction_stagesTableAdapter = null;
            this.tableAdapterManager.didyouknowDetailsTableAdapter = null;
            this.tableAdapterManager.didyouknowTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = this.geography_questionTableAdapter;
            this.tableAdapterManager.geography_temples1TableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // geography_questionBindingNavigator
            // 
            this.geography_questionBindingNavigator.AddNewItem = null;
            this.geography_questionBindingNavigator.BindingSource = this.geography_questionBindingSource;
            this.geography_questionBindingNavigator.CountItem = null;
            this.geography_questionBindingNavigator.DeleteItem = null;
            this.geography_questionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geography_questionBindingNavigatorSaveItem});
            this.geography_questionBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.geography_questionBindingNavigator.MoveFirstItem = null;
            this.geography_questionBindingNavigator.MoveLastItem = null;
            this.geography_questionBindingNavigator.MoveNextItem = null;
            this.geography_questionBindingNavigator.MovePreviousItem = null;
            this.geography_questionBindingNavigator.Name = "geography_questionBindingNavigator";
            this.geography_questionBindingNavigator.PositionItem = null;
            this.geography_questionBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.geography_questionBindingNavigator.TabIndex = 1;
            this.geography_questionBindingNavigator.Text = "bindingNavigator1";
            // 
            // geography_questionBindingNavigatorSaveItem
            // 
            this.geography_questionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.geography_questionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("geography_questionBindingNavigatorSaveItem.Image")));
            this.geography_questionBindingNavigatorSaveItem.Name = "geography_questionBindingNavigatorSaveItem";
            this.geography_questionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.geography_questionBindingNavigatorSaveItem.Text = "Save Data";
            this.geography_questionBindingNavigatorSaveItem.Click += new System.EventHandler(this.geography_questionBindingNavigatorSaveItem_Click);
            // 
            // questidTextBox
            // 
            this.questidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "questid", true));
            this.questidTextBox.Location = new System.Drawing.Point(12, 125);
            this.questidTextBox.Name = "questidTextBox";
            this.questidTextBox.Size = new System.Drawing.Size(100, 23);
            this.questidTextBox.TabIndex = 4;
            // 
            // questtext_grTextBox
            // 
            this.questtext_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "questtext_gr", true));
            this.questtext_grTextBox.Location = new System.Drawing.Point(15, 180);
            this.questtext_grTextBox.Multiline = true;
            this.questtext_grTextBox.Name = "questtext_grTextBox";
            this.questtext_grTextBox.Size = new System.Drawing.Size(375, 125);
            this.questtext_grTextBox.TabIndex = 6;
            // 
            // questtext_enTextBox
            // 
            this.questtext_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "questtext_en", true));
            this.questtext_enTextBox.Location = new System.Drawing.Point(422, 180);
            this.questtext_enTextBox.Multiline = true;
            this.questtext_enTextBox.Name = "questtext_enTextBox";
            this.questtext_enTextBox.Size = new System.Drawing.Size(375, 125);
            this.questtext_enTextBox.TabIndex = 8;
            // 
            // feedbacktext_grTextBox
            // 
            this.feedbacktext_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "feedbacktext_gr", true));
            this.feedbacktext_grTextBox.Location = new System.Drawing.Point(15, 404);
            this.feedbacktext_grTextBox.Multiline = true;
            this.feedbacktext_grTextBox.Name = "feedbacktext_grTextBox";
            this.feedbacktext_grTextBox.Size = new System.Drawing.Size(375, 125);
            this.feedbacktext_grTextBox.TabIndex = 12;
            // 
            // feedbacktext_enTextBox
            // 
            this.feedbacktext_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "feedbacktext_en", true));
            this.feedbacktext_enTextBox.Location = new System.Drawing.Point(422, 406);
            this.feedbacktext_enTextBox.Multiline = true;
            this.feedbacktext_enTextBox.Name = "feedbacktext_enTextBox";
            this.feedbacktext_enTextBox.Size = new System.Drawing.Size(375, 123);
            this.feedbacktext_enTextBox.TabIndex = 14;
            // 
            // templeidComboBox
            // 
            this.templeidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.geography_questionBindingSource, "templeid", true));
            this.templeidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geographytemples1BindingSource, "templename_gr", true));
            this.templeidComboBox.DataSource = this.geographytemples1BindingSource;
            this.templeidComboBox.DisplayMember = "templename_gr";
            this.templeidComboBox.FormattingEnabled = true;
            this.templeidComboBox.Location = new System.Drawing.Point(821, 180);
            this.templeidComboBox.Name = "templeidComboBox";
            this.templeidComboBox.Size = new System.Drawing.Size(382, 25);
            this.templeidComboBox.TabIndex = 15;
            this.templeidComboBox.ValueMember = "templeid";
            this.templeidComboBox.SelectedIndexChanged += new System.EventHandler(this.templeidComboBox_SelectedIndexChanged);
            // 
            // geographytemples1BindingSource
            // 
            this.geographytemples1BindingSource.DataMember = "geography_temples1";
            this.geographytemples1BindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(828, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(375, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // feedback_imgTextBox
            // 
            this.feedback_imgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "feedback_img", true));
            this.feedback_imgTextBox.Location = new System.Drawing.Point(829, 378);
            this.feedback_imgTextBox.Name = "feedback_imgTextBox";
            this.feedback_imgTextBox.Size = new System.Drawing.Size(374, 23);
            this.feedback_imgTextBox.TabIndex = 19;
            // 
            // geography_temples1TableAdapter
            // 
            this.geography_temples1TableAdapter.ClearBeforeFill = true;
            // 
            // frmGeographyQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1273, 561);
            this.Controls.Add(this.feedback_imgTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.templeidComboBox);
            this.Controls.Add(this.questidTextBox);
            this.Controls.Add(questtext_grLabel);
            this.Controls.Add(this.questtext_grTextBox);
            this.Controls.Add(questtext_enLabel);
            this.Controls.Add(this.questtext_enTextBox);
            this.Controls.Add(templeidLabel);
            this.Controls.Add(feedbacktext_grLabel);
            this.Controls.Add(this.feedbacktext_grTextBox);
            this.Controls.Add(feedbacktext_enLabel);
            this.Controls.Add(this.feedbacktext_enTextBox);
            this.Controls.Add(this.geography_questionBindingNavigator);
            this.Name = "frmGeographyQuestion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGeographyQuestionDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmGeographyQuestionDetails_Load);
            this.Controls.SetChildIndex(this.geography_questionBindingNavigator, 0);
            this.Controls.SetChildIndex(this.feedbacktext_enTextBox, 0);
            this.Controls.SetChildIndex(feedbacktext_enLabel, 0);
            this.Controls.SetChildIndex(this.feedbacktext_grTextBox, 0);
            this.Controls.SetChildIndex(feedbacktext_grLabel, 0);
            this.Controls.SetChildIndex(templeidLabel, 0);
            this.Controls.SetChildIndex(this.questtext_enTextBox, 0);
            this.Controls.SetChildIndex(questtext_enLabel, 0);
            this.Controls.SetChildIndex(this.questtext_grTextBox, 0);
            this.Controls.SetChildIndex(questtext_grLabel, 0);
            this.Controls.SetChildIndex(this.questidTextBox, 0);
            this.Controls.SetChildIndex(this.templeidComboBox, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(label1, 0);
            this.Controls.SetChildIndex(this.feedback_imgTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingNavigator)).EndInit();
            this.geography_questionBindingNavigator.ResumeLayout(false);
            this.geography_questionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemples1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource geography_questionBindingSource;
        private ancienttempledbDataSetTableAdapters.geography_questionTableAdapter geography_questionTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator geography_questionBindingNavigator;
        private System.Windows.Forms.ToolStripButton geography_questionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox questidTextBox;
        private System.Windows.Forms.TextBox questtext_grTextBox;
        private System.Windows.Forms.TextBox questtext_enTextBox;
        private System.Windows.Forms.TextBox feedbacktext_grTextBox;
        private System.Windows.Forms.TextBox feedbacktext_enTextBox;
        private System.Windows.Forms.ComboBox templeidComboBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox feedback_imgTextBox;
        private System.Windows.Forms.BindingSource geographytemples1BindingSource;
        private ancienttempledbDataSetTableAdapters.geography_temples1TableAdapter geography_temples1TableAdapter;
    }
}
