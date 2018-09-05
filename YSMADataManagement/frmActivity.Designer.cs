namespace YSMADataManagement
{
    partial class frmActivity
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
            System.Windows.Forms.Label activity_idLabel;
            System.Windows.Forms.Label stage_idLabel;
            System.Windows.Forms.Label activity_desc_grLabel;
            System.Windows.Forms.Label activity_desc_enLabel;
            System.Windows.Forms.Label activity_imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivity));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.construction_activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.construction_activityTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.construction_activityTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.construction_activityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.construction_activityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activity_idTextBox = new System.Windows.Forms.TextBox();
            this.stage_idTextBox = new System.Windows.Forms.TextBox();
            this.activity_desc_grTextBox = new System.Windows.Forms.TextBox();
            this.activity_desc_enTextBox = new System.Windows.Forms.TextBox();
            this.activity_imageTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            activity_idLabel = new System.Windows.Forms.Label();
            stage_idLabel = new System.Windows.Forms.Label();
            activity_desc_grLabel = new System.Windows.Forms.Label();
            activity_desc_enLabel = new System.Windows.Forms.Label();
            activity_imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activityBindingNavigator)).BeginInit();
            this.construction_activityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // activity_idLabel
            // 
            activity_idLabel.AutoSize = true;
            activity_idLabel.Location = new System.Drawing.Point(21, 131);
            activity_idLabel.Name = "activity_idLabel";
            activity_idLabel.Size = new System.Drawing.Size(75, 17);
            activity_idLabel.TabIndex = 3;
            activity_idLabel.Text = "activity id:";
            activity_idLabel.Visible = false;
            // 
            // stage_idLabel
            // 
            stage_idLabel.AutoSize = true;
            stage_idLabel.Location = new System.Drawing.Point(276, 134);
            stage_idLabel.Name = "stage_idLabel";
            stage_idLabel.Size = new System.Drawing.Size(64, 17);
            stage_idLabel.TabIndex = 5;
            stage_idLabel.Text = "stage id:";
            stage_idLabel.Visible = false;
            // 
            // activity_desc_grLabel
            // 
            activity_desc_grLabel.AutoSize = true;
            activity_desc_grLabel.Location = new System.Drawing.Point(101, 164);
            activity_desc_grLabel.Name = "activity_desc_grLabel";
            activity_desc_grLabel.Size = new System.Drawing.Size(110, 17);
            activity_desc_grLabel.TabIndex = 7;
            activity_desc_grLabel.Text = "activity desc gr:";
            // 
            // activity_desc_enLabel
            // 
            activity_desc_enLabel.AutoSize = true;
            activity_desc_enLabel.Location = new System.Drawing.Point(651, 164);
            activity_desc_enLabel.Name = "activity_desc_enLabel";
            activity_desc_enLabel.Size = new System.Drawing.Size(113, 17);
            activity_desc_enLabel.TabIndex = 9;
            activity_desc_enLabel.Text = "activity desc en:";
            // 
            // activity_imageLabel
            // 
            activity_imageLabel.AutoSize = true;
            activity_imageLabel.Location = new System.Drawing.Point(212, 319);
            activity_imageLabel.Name = "activity_imageLabel";
            activity_imageLabel.Size = new System.Drawing.Size(105, 17);
            activity_imageLabel.TabIndex = 11;
            activity_imageLabel.Text = "activity image:";
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // construction_activityBindingSource
            // 
            this.construction_activityBindingSource.DataMember = "construction_activity";
            this.construction_activityBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // construction_activityTableAdapter
            // 
            this.construction_activityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.construction_activitiesTableAdapter = null;
            this.tableAdapterManager.construction_activityTableAdapter = this.construction_activityTableAdapter;
            this.tableAdapterManager.construction_stagesTableAdapter = null;
            this.tableAdapterManager.didyouknowDetailsTableAdapter = null;
            this.tableAdapterManager.didyouknowTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // construction_activityBindingNavigator
            // 
            this.construction_activityBindingNavigator.AddNewItem = null;
            this.construction_activityBindingNavigator.BindingSource = this.construction_activityBindingSource;
            this.construction_activityBindingNavigator.CountItem = null;
            this.construction_activityBindingNavigator.DeleteItem = null;
            this.construction_activityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.construction_activityBindingNavigatorSaveItem});
            this.construction_activityBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.construction_activityBindingNavigator.MoveFirstItem = null;
            this.construction_activityBindingNavigator.MoveLastItem = null;
            this.construction_activityBindingNavigator.MoveNextItem = null;
            this.construction_activityBindingNavigator.MovePreviousItem = null;
            this.construction_activityBindingNavigator.Name = "construction_activityBindingNavigator";
            this.construction_activityBindingNavigator.PositionItem = null;
            this.construction_activityBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.construction_activityBindingNavigator.TabIndex = 1;
            this.construction_activityBindingNavigator.Text = "bindingNavigator1";
            // 
            // construction_activityBindingNavigatorSaveItem
            // 
            this.construction_activityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.construction_activityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("construction_activityBindingNavigatorSaveItem.Image")));
            this.construction_activityBindingNavigatorSaveItem.Name = "construction_activityBindingNavigatorSaveItem";
            this.construction_activityBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.construction_activityBindingNavigatorSaveItem.Text = "Save Data";
            this.construction_activityBindingNavigatorSaveItem.Click += new System.EventHandler(this.construction_activityBindingNavigatorSaveItem_Click);
            // 
            // activity_idTextBox
            // 
            this.activity_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.construction_activityBindingSource, "activity_id", true));
            this.activity_idTextBox.Location = new System.Drawing.Point(143, 128);
            this.activity_idTextBox.Name = "activity_idTextBox";
            this.activity_idTextBox.Size = new System.Drawing.Size(100, 23);
            this.activity_idTextBox.TabIndex = 4;
            // 
            // stage_idTextBox
            // 
            this.stage_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.construction_activityBindingSource, "stage_id", true));
            this.stage_idTextBox.Location = new System.Drawing.Point(361, 131);
            this.stage_idTextBox.Name = "stage_idTextBox";
            this.stage_idTextBox.Size = new System.Drawing.Size(100, 23);
            this.stage_idTextBox.TabIndex = 6;
            // 
            // activity_desc_grTextBox
            // 
            this.activity_desc_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.construction_activityBindingSource, "activity_desc_gr", true));
            this.activity_desc_grTextBox.Location = new System.Drawing.Point(104, 199);
            this.activity_desc_grTextBox.Multiline = true;
            this.activity_desc_grTextBox.Name = "activity_desc_grTextBox";
            this.activity_desc_grTextBox.Size = new System.Drawing.Size(448, 103);
            this.activity_desc_grTextBox.TabIndex = 8;
            // 
            // activity_desc_enTextBox
            // 
            this.activity_desc_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.construction_activityBindingSource, "activity_desc_en", true));
            this.activity_desc_enTextBox.Location = new System.Drawing.Point(654, 199);
            this.activity_desc_enTextBox.Multiline = true;
            this.activity_desc_enTextBox.Name = "activity_desc_enTextBox";
            this.activity_desc_enTextBox.Size = new System.Drawing.Size(406, 103);
            this.activity_desc_enTextBox.TabIndex = 10;
            // 
            // activity_imageTextBox
            // 
            this.activity_imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.construction_activityBindingSource, "activity_image", true));
            this.activity_imageTextBox.Location = new System.Drawing.Point(333, 319);
            this.activity_imageTextBox.Name = "activity_imageTextBox";
            this.activity_imageTextBox.Size = new System.Drawing.Size(177, 23);
            this.activity_imageTextBox.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(333, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(509, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1273, 679);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(activity_idLabel);
            this.Controls.Add(this.activity_idTextBox);
            this.Controls.Add(stage_idLabel);
            this.Controls.Add(this.stage_idTextBox);
            this.Controls.Add(activity_desc_grLabel);
            this.Controls.Add(this.activity_desc_grTextBox);
            this.Controls.Add(activity_desc_enLabel);
            this.Controls.Add(this.activity_desc_enTextBox);
            this.Controls.Add(activity_imageLabel);
            this.Controls.Add(this.activity_imageTextBox);
            this.Controls.Add(this.construction_activityBindingNavigator);
            this.Name = "frmActivity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmActivity_FormClosing);
            this.Load += new System.EventHandler(this.frmActivity_Load);
            this.Controls.SetChildIndex(this.construction_activityBindingNavigator, 0);
            this.Controls.SetChildIndex(this.activity_imageTextBox, 0);
            this.Controls.SetChildIndex(activity_imageLabel, 0);
            this.Controls.SetChildIndex(this.activity_desc_enTextBox, 0);
            this.Controls.SetChildIndex(activity_desc_enLabel, 0);
            this.Controls.SetChildIndex(this.activity_desc_grTextBox, 0);
            this.Controls.SetChildIndex(activity_desc_grLabel, 0);
            this.Controls.SetChildIndex(this.stage_idTextBox, 0);
            this.Controls.SetChildIndex(stage_idLabel, 0);
            this.Controls.SetChildIndex(this.activity_idTextBox, 0);
            this.Controls.SetChildIndex(activity_idLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activityBindingNavigator)).EndInit();
            this.construction_activityBindingNavigator.ResumeLayout(false);
            this.construction_activityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource construction_activityBindingSource;
        private ancienttempledbDataSetTableAdapters.construction_activityTableAdapter construction_activityTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator construction_activityBindingNavigator;
        private System.Windows.Forms.ToolStripButton construction_activityBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox activity_idTextBox;
        private System.Windows.Forms.TextBox stage_idTextBox;
        private System.Windows.Forms.TextBox activity_desc_grTextBox;
        private System.Windows.Forms.TextBox activity_desc_enTextBox;
        private System.Windows.Forms.TextBox activity_imageTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
