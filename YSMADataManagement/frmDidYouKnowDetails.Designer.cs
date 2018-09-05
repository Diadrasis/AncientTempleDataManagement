namespace YSMADataManagement
{
    partial class frmDidYouKnowDetails
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
            System.Windows.Forms.Label dykidLabel;
            System.Windows.Forms.Label gameidLabel;
            System.Windows.Forms.Label questiontext_grLabel;
            System.Windows.Forms.Label questiontext_enLabel;
            System.Windows.Forms.Label answertext_grLabel;
            System.Windows.Forms.Label answertext_enLabel;
            System.Windows.Forms.Label imagefileLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDidYouKnowDetails));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.didyouknowDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.didyouknowDetailsTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.didyouknowDetailsTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.didyouknowDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.didyouknowDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dykidTextBox = new System.Windows.Forms.TextBox();
            this.gameidTextBox = new System.Windows.Forms.TextBox();
            this.questiontext_grTextBox = new System.Windows.Forms.TextBox();
            this.questiontext_enTextBox = new System.Windows.Forms.TextBox();
            this.answertext_grTextBox = new System.Windows.Forms.TextBox();
            this.answertext_enTextBox = new System.Windows.Forms.TextBox();
            this.imagefileTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            dykidLabel = new System.Windows.Forms.Label();
            gameidLabel = new System.Windows.Forms.Label();
            questiontext_grLabel = new System.Windows.Forms.Label();
            questiontext_enLabel = new System.Windows.Forms.Label();
            answertext_grLabel = new System.Windows.Forms.Label();
            answertext_enLabel = new System.Windows.Forms.Label();
            imagefileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowDetailsBindingNavigator)).BeginInit();
            this.didyouknowDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dykidLabel
            // 
            dykidLabel.AutoSize = true;
            dykidLabel.Location = new System.Drawing.Point(13, 128);
            dykidLabel.Name = "dykidLabel";
            dykidLabel.Size = new System.Drawing.Size(46, 17);
            dykidLabel.TabIndex = 3;
            dykidLabel.Text = "dykid:";
            dykidLabel.Visible = false;
            // 
            // gameidLabel
            // 
            gameidLabel.AutoSize = true;
            gameidLabel.Location = new System.Drawing.Point(13, 157);
            gameidLabel.Name = "gameidLabel";
            gameidLabel.Size = new System.Drawing.Size(63, 17);
            gameidLabel.TabIndex = 5;
            gameidLabel.Text = "gameid:";
            gameidLabel.Visible = false;
            // 
            // questiontext_grLabel
            // 
            questiontext_grLabel.AutoSize = true;
            questiontext_grLabel.Location = new System.Drawing.Point(135, 183);
            questiontext_grLabel.Name = "questiontext_grLabel";
            questiontext_grLabel.Size = new System.Drawing.Size(95, 17);
            questiontext_grLabel.TabIndex = 7;
            questiontext_grLabel.Text = "Ερώτηση (gr):";
            // 
            // questiontext_enLabel
            // 
            questiontext_enLabel.AutoSize = true;
            questiontext_enLabel.Location = new System.Drawing.Point(606, 178);
            questiontext_enLabel.Name = "questiontext_enLabel";
            questiontext_enLabel.Size = new System.Drawing.Size(98, 17);
            questiontext_enLabel.TabIndex = 9;
            questiontext_enLabel.Text = "Ερώτηση (en):";
            // 
            // answertext_grLabel
            // 
            answertext_grLabel.AutoSize = true;
            answertext_grLabel.Location = new System.Drawing.Point(132, 259);
            answertext_grLabel.Name = "answertext_grLabel";
            answertext_grLabel.Size = new System.Drawing.Size(103, 17);
            answertext_grLabel.TabIndex = 11;
            answertext_grLabel.Text = "Απάντηση (gr):";
            // 
            // answertext_enLabel
            // 
            answertext_enLabel.AutoSize = true;
            answertext_enLabel.Location = new System.Drawing.Point(606, 259);
            answertext_enLabel.Name = "answertext_enLabel";
            answertext_enLabel.Size = new System.Drawing.Size(106, 17);
            answertext_enLabel.TabIndex = 13;
            answertext_enLabel.Text = "Απάντηση (en):";
            // 
            // imagefileLabel
            // 
            imagefileLabel.AutoSize = true;
            imagefileLabel.Location = new System.Drawing.Point(132, 432);
            imagefileLabel.Name = "imagefileLabel";
            imagefileLabel.Size = new System.Drawing.Size(109, 17);
            imagefileLabel.TabIndex = 15;
            imagefileLabel.Text = "Αρχείο Εικόνας:";
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // didyouknowDetailsBindingSource
            // 
            this.didyouknowDetailsBindingSource.DataMember = "didyouknowDetails";
            this.didyouknowDetailsBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // didyouknowDetailsTableAdapter
            // 
            this.didyouknowDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.construction_activitiesTableAdapter = null;
            this.tableAdapterManager.construction_activityTableAdapter = null;
            this.tableAdapterManager.construction_stagesTableAdapter = null;
            this.tableAdapterManager.didyouknowDetailsTableAdapter = this.didyouknowDetailsTableAdapter;
            this.tableAdapterManager.didyouknowTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = null;
            this.tableAdapterManager.geography_temples1TableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // didyouknowDetailsBindingNavigator
            // 
            this.didyouknowDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.didyouknowDetailsBindingNavigator.BindingSource = this.didyouknowDetailsBindingSource;
            this.didyouknowDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.didyouknowDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.didyouknowDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.didyouknowDetailsBindingNavigatorSaveItem});
            this.didyouknowDetailsBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.didyouknowDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.didyouknowDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.didyouknowDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.didyouknowDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.didyouknowDetailsBindingNavigator.Name = "didyouknowDetailsBindingNavigator";
            this.didyouknowDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.didyouknowDetailsBindingNavigator.Size = new System.Drawing.Size(1090, 25);
            this.didyouknowDetailsBindingNavigator.TabIndex = 1;
            this.didyouknowDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // didyouknowDetailsBindingNavigatorSaveItem
            // 
            this.didyouknowDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.didyouknowDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("didyouknowDetailsBindingNavigatorSaveItem.Image")));
            this.didyouknowDetailsBindingNavigatorSaveItem.Name = "didyouknowDetailsBindingNavigatorSaveItem";
            this.didyouknowDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.didyouknowDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.didyouknowDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.didyouknowDetailsBindingNavigatorSaveItem_Click);
            // 
            // dykidTextBox
            // 
            this.dykidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "dykid", true));
            this.dykidTextBox.Location = new System.Drawing.Point(130, 125);
            this.dykidTextBox.Name = "dykidTextBox";
            this.dykidTextBox.Size = new System.Drawing.Size(100, 23);
            this.dykidTextBox.TabIndex = 4;
            // 
            // gameidTextBox
            // 
            this.gameidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "gameid", true));
            this.gameidTextBox.Location = new System.Drawing.Point(130, 154);
            this.gameidTextBox.Name = "gameidTextBox";
            this.gameidTextBox.Size = new System.Drawing.Size(100, 23);
            this.gameidTextBox.TabIndex = 6;
            // 
            // questiontext_grTextBox
            // 
            this.questiontext_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "questiontext_gr", true));
            this.questiontext_grTextBox.Location = new System.Drawing.Point(131, 203);
            this.questiontext_grTextBox.Multiline = true;
            this.questiontext_grTextBox.Name = "questiontext_grTextBox";
            this.questiontext_grTextBox.Size = new System.Drawing.Size(423, 42);
            this.questiontext_grTextBox.TabIndex = 8;
            // 
            // questiontext_enTextBox
            // 
            this.questiontext_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "questiontext_en", true));
            this.questiontext_enTextBox.Location = new System.Drawing.Point(609, 203);
            this.questiontext_enTextBox.Multiline = true;
            this.questiontext_enTextBox.Name = "questiontext_enTextBox";
            this.questiontext_enTextBox.Size = new System.Drawing.Size(451, 42);
            this.questiontext_enTextBox.TabIndex = 10;
            // 
            // answertext_grTextBox
            // 
            this.answertext_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "answertext_gr", true));
            this.answertext_grTextBox.Location = new System.Drawing.Point(131, 279);
            this.answertext_grTextBox.Multiline = true;
            this.answertext_grTextBox.Name = "answertext_grTextBox";
            this.answertext_grTextBox.Size = new System.Drawing.Size(423, 125);
            this.answertext_grTextBox.TabIndex = 12;
            // 
            // answertext_enTextBox
            // 
            this.answertext_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "answertext_en", true));
            this.answertext_enTextBox.Location = new System.Drawing.Point(609, 279);
            this.answertext_enTextBox.Multiline = true;
            this.answertext_enTextBox.Name = "answertext_enTextBox";
            this.answertext_enTextBox.Size = new System.Drawing.Size(451, 125);
            this.answertext_enTextBox.TabIndex = 14;
            // 
            // imagefileTextBox
            // 
            this.imagefileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.didyouknowDetailsBindingSource, "imagefile", true));
            this.imagefileTextBox.Location = new System.Drawing.Point(131, 452);
            this.imagefileTextBox.Name = "imagefileTextBox";
            this.imagefileTextBox.Size = new System.Drawing.Size(253, 23);
            this.imagefileTextBox.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.Location = new System.Drawing.Point(130, 485);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(930, 251);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(313, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // frmDidYouKnowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1090, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(dykidLabel);
            this.Controls.Add(this.dykidTextBox);
            this.Controls.Add(gameidLabel);
            this.Controls.Add(this.gameidTextBox);
            this.Controls.Add(questiontext_grLabel);
            this.Controls.Add(this.questiontext_grTextBox);
            this.Controls.Add(questiontext_enLabel);
            this.Controls.Add(this.questiontext_enTextBox);
            this.Controls.Add(answertext_grLabel);
            this.Controls.Add(this.answertext_grTextBox);
            this.Controls.Add(answertext_enLabel);
            this.Controls.Add(this.answertext_enTextBox);
            this.Controls.Add(imagefileLabel);
            this.Controls.Add(this.imagefileTextBox);
            this.Controls.Add(this.didyouknowDetailsBindingNavigator);
            this.Name = "frmDidYouKnowDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDidYouKnowDetails_FormClosing);
            this.Load += new System.EventHandler(this.frmDidYoyKnowDetails_Load);
            this.Controls.SetChildIndex(this.didyouknowDetailsBindingNavigator, 0);
            this.Controls.SetChildIndex(this.imagefileTextBox, 0);
            this.Controls.SetChildIndex(imagefileLabel, 0);
            this.Controls.SetChildIndex(this.answertext_enTextBox, 0);
            this.Controls.SetChildIndex(answertext_enLabel, 0);
            this.Controls.SetChildIndex(this.answertext_grTextBox, 0);
            this.Controls.SetChildIndex(answertext_grLabel, 0);
            this.Controls.SetChildIndex(this.questiontext_enTextBox, 0);
            this.Controls.SetChildIndex(questiontext_enLabel, 0);
            this.Controls.SetChildIndex(this.questiontext_grTextBox, 0);
            this.Controls.SetChildIndex(questiontext_grLabel, 0);
            this.Controls.SetChildIndex(this.gameidTextBox, 0);
            this.Controls.SetChildIndex(gameidLabel, 0);
            this.Controls.SetChildIndex(this.dykidTextBox, 0);
            this.Controls.SetChildIndex(dykidLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowDetailsBindingNavigator)).EndInit();
            this.didyouknowDetailsBindingNavigator.ResumeLayout(false);
            this.didyouknowDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource didyouknowDetailsBindingSource;
        private ancienttempledbDataSetTableAdapters.didyouknowDetailsTableAdapter didyouknowDetailsTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator didyouknowDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton didyouknowDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dykidTextBox;
        private System.Windows.Forms.TextBox gameidTextBox;
        private System.Windows.Forms.TextBox questiontext_grTextBox;
        private System.Windows.Forms.TextBox questiontext_enTextBox;
        private System.Windows.Forms.TextBox answertext_grTextBox;
        private System.Windows.Forms.TextBox answertext_enTextBox;
        private System.Windows.Forms.TextBox imagefileTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}
