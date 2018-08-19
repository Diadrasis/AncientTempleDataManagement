namespace YSMADataManagement
{
    partial class frmGeographyQuestionDetails
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
            System.Windows.Forms.Label questidLabel;
            System.Windows.Forms.Label questtext_grLabel;
            System.Windows.Forms.Label questtext_enLabel;
            System.Windows.Forms.Label templeidLabel;
            System.Windows.Forms.Label feedbacktext_grLabel;
            System.Windows.Forms.Label feedbacktext_enLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeographyQuestionDetails));
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
            this.geographytemplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geography_templesTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.geography_templesTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            questidLabel = new System.Windows.Forms.Label();
            questtext_grLabel = new System.Windows.Forms.Label();
            questtext_enLabel = new System.Windows.Forms.Label();
            templeidLabel = new System.Windows.Forms.Label();
            feedbacktext_grLabel = new System.Windows.Forms.Label();
            feedbacktext_enLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingNavigator)).BeginInit();
            this.geography_questionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemplesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // questidLabel
            // 
            questidLabel.AutoSize = true;
            questidLabel.Location = new System.Drawing.Point(75, 186);
            questidLabel.Name = "questidLabel";
            questidLabel.Size = new System.Drawing.Size(59, 17);
            questidLabel.TabIndex = 3;
            questidLabel.Text = "questid:";
            // 
            // questtext_grLabel
            // 
            questtext_grLabel.AutoSize = true;
            questtext_grLabel.Location = new System.Drawing.Point(75, 215);
            questtext_grLabel.Name = "questtext_grLabel";
            questtext_grLabel.Size = new System.Drawing.Size(88, 17);
            questtext_grLabel.TabIndex = 5;
            questtext_grLabel.Text = "questtext gr:";
            // 
            // questtext_enLabel
            // 
            questtext_enLabel.AutoSize = true;
            questtext_enLabel.Location = new System.Drawing.Point(536, 218);
            questtext_enLabel.Name = "questtext_enLabel";
            questtext_enLabel.Size = new System.Drawing.Size(91, 17);
            questtext_enLabel.TabIndex = 7;
            questtext_enLabel.Text = "questtext en:";
            // 
            // templeidLabel
            // 
            templeidLabel.AutoSize = true;
            templeidLabel.Location = new System.Drawing.Point(75, 366);
            templeidLabel.Name = "templeidLabel";
            templeidLabel.Size = new System.Drawing.Size(70, 17);
            templeidLabel.TabIndex = 9;
            templeidLabel.Text = "templeid:";
            // 
            // feedbacktext_grLabel
            // 
            feedbacktext_grLabel.AutoSize = true;
            feedbacktext_grLabel.Location = new System.Drawing.Point(75, 503);
            feedbacktext_grLabel.Name = "feedbacktext_grLabel";
            feedbacktext_grLabel.Size = new System.Drawing.Size(115, 17);
            feedbacktext_grLabel.TabIndex = 11;
            feedbacktext_grLabel.Text = "feedbacktext gr:";
            // 
            // feedbacktext_enLabel
            // 
            feedbacktext_enLabel.AutoSize = true;
            feedbacktext_enLabel.Location = new System.Drawing.Point(542, 500);
            feedbacktext_enLabel.Name = "feedbacktext_enLabel";
            feedbacktext_enLabel.Size = new System.Drawing.Size(118, 17);
            feedbacktext_enLabel.TabIndex = 13;
            feedbacktext_enLabel.Text = "feedbacktext en:";
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
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = this.geography_questionTableAdapter;
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
            this.questidTextBox.Location = new System.Drawing.Point(199, 183);
            this.questidTextBox.Name = "questidTextBox";
            this.questidTextBox.Size = new System.Drawing.Size(100, 23);
            this.questidTextBox.TabIndex = 4;
            // 
            // questtext_grTextBox
            // 
            this.questtext_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "questtext_gr", true));
            this.questtext_grTextBox.Location = new System.Drawing.Point(199, 212);
            this.questtext_grTextBox.Multiline = true;
            this.questtext_grTextBox.Name = "questtext_grTextBox";
            this.questtext_grTextBox.Size = new System.Drawing.Size(311, 125);
            this.questtext_grTextBox.TabIndex = 6;
            // 
            // questtext_enTextBox
            // 
            this.questtext_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "questtext_en", true));
            this.questtext_enTextBox.Location = new System.Drawing.Point(666, 218);
            this.questtext_enTextBox.Multiline = true;
            this.questtext_enTextBox.Name = "questtext_enTextBox";
            this.questtext_enTextBox.Size = new System.Drawing.Size(306, 119);
            this.questtext_enTextBox.TabIndex = 8;
            // 
            // feedbacktext_grTextBox
            // 
            this.feedbacktext_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "feedbacktext_gr", true));
            this.feedbacktext_grTextBox.Location = new System.Drawing.Point(199, 500);
            this.feedbacktext_grTextBox.Multiline = true;
            this.feedbacktext_grTextBox.Name = "feedbacktext_grTextBox";
            this.feedbacktext_grTextBox.Size = new System.Drawing.Size(311, 171);
            this.feedbacktext_grTextBox.TabIndex = 12;
            // 
            // feedbacktext_enTextBox
            // 
            this.feedbacktext_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geography_questionBindingSource, "feedbacktext_en", true));
            this.feedbacktext_enTextBox.Location = new System.Drawing.Point(666, 497);
            this.feedbacktext_enTextBox.Multiline = true;
            this.feedbacktext_enTextBox.Name = "feedbacktext_enTextBox";
            this.feedbacktext_enTextBox.Size = new System.Drawing.Size(306, 171);
            this.feedbacktext_enTextBox.TabIndex = 14;
            // 
            // templeidComboBox
            // 
            this.templeidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.geography_questionBindingSource, "templeid", true));
            this.templeidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.geographytemplesBindingSource, "templename_gr", true));
            this.templeidComboBox.DataSource = this.geographytemplesBindingSource;
            this.templeidComboBox.DisplayMember = "templename_gr";
            this.templeidComboBox.FormattingEnabled = true;
            this.templeidComboBox.Location = new System.Drawing.Point(199, 358);
            this.templeidComboBox.Name = "templeidComboBox";
            this.templeidComboBox.Size = new System.Drawing.Size(311, 25);
            this.templeidComboBox.TabIndex = 15;
            this.templeidComboBox.ValueMember = "templeid";
            // 
            // geographytemplesBindingSource
            // 
            this.geographytemplesBindingSource.DataMember = "geography_temples";
            this.geographytemplesBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // geography_templesTableAdapter
            // 
            this.geography_templesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(666, 366);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 109);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(199, 708);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(773, 126);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmGeographyQuestionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1273, 846);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.templeidComboBox);
            this.Controls.Add(questidLabel);
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
            this.Name = "frmGeographyQuestionDetails";
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
            this.Controls.SetChildIndex(questidLabel, 0);
            this.Controls.SetChildIndex(this.templeidComboBox, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionBindingNavigator)).EndInit();
            this.geography_questionBindingNavigator.ResumeLayout(false);
            this.geography_questionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemplesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.BindingSource geographytemplesBindingSource;
        private ancienttempledbDataSetTableAdapters.geography_templesTableAdapter geography_templesTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
