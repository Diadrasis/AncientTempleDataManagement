namespace YSMADataManagement
{
    partial class frmGeographyQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeographyQuestions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.geography_questionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.geography_questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
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
            this.geography_questionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.geography_questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.geographytemples1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geography_questionsTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.geography_questionsTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.geography_temples1TableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.geography_temples1TableAdapter();
            this.geographytemples1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.temple_file = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionsBindingNavigator)).BeginInit();
            this.geography_questionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemples1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemples1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // geography_questionsBindingNavigator
            // 
            this.geography_questionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.geography_questionsBindingNavigator.BindingSource = this.geography_questionsBindingSource;
            this.geography_questionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.geography_questionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.geography_questionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.geography_questionsBindingNavigatorSaveItem});
            this.geography_questionsBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.geography_questionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.geography_questionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.geography_questionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.geography_questionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.geography_questionsBindingNavigator.Name = "geography_questionsBindingNavigator";
            this.geography_questionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.geography_questionsBindingNavigator.Size = new System.Drawing.Size(840, 25);
            this.geography_questionsBindingNavigator.TabIndex = 0;
            this.geography_questionsBindingNavigator.Text = "bindingNavigator1";
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
            // geography_questionsBindingSource
            // 
            this.geography_questionsBindingSource.DataMember = "geography_questions";
            this.geography_questionsBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // geography_questionsBindingNavigatorSaveItem
            // 
            this.geography_questionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.geography_questionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("geography_questionsBindingNavigatorSaveItem.Image")));
            this.geography_questionsBindingNavigatorSaveItem.Name = "geography_questionsBindingNavigatorSaveItem";
            this.geography_questionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.geography_questionsBindingNavigatorSaveItem.Text = "Save Data";
            this.geography_questionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.geography_questionsBindingNavigatorSaveItem_Click);
            // 
            // geography_questionsDataGridView
            // 
            this.geography_questionsDataGridView.AutoGenerateColumns = false;
            this.geography_questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.geography_questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.temple_file,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.feedbackImg,
            this.details});
            this.geography_questionsDataGridView.DataSource = this.geography_questionsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.geography_questionsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.geography_questionsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.geography_questionsDataGridView.Location = new System.Drawing.Point(75, 128);
            this.geography_questionsDataGridView.Name = "geography_questionsDataGridView";
            this.geography_questionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.geography_questionsDataGridView.Size = new System.Drawing.Size(679, 220);
            this.geography_questionsDataGridView.TabIndex = 1;
            this.geography_questionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.geography_questionsDataGridView_CellContentClick);
            // 
            // geographytemples1BindingSource
            // 
            this.geographytemples1BindingSource.DataMember = "geography_temples1";
            this.geographytemples1BindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // geography_questionsTableAdapter
            // 
            this.geography_questionsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.geography_questionsTableAdapter = this.geography_questionsTableAdapter;
            this.tableAdapterManager.geography_questionTableAdapter = null;
            this.tableAdapterManager.geography_temples1TableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // geography_temples1TableAdapter
            // 
            this.geography_temples1TableAdapter.ClearBeforeFill = true;
            // 
            // geographytemples1BindingSource1
            // 
            this.geographytemples1BindingSource1.DataMember = "geography_temples1";
            this.geographytemples1BindingSource1.DataSource = this.ancienttempledbDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "questid";
            this.dataGridViewTextBoxColumn1.HeaderText = "questid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "questtext_gr";
            this.dataGridViewTextBoxColumn2.HeaderText = "questtext_gr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "questtext_en";
            this.dataGridViewTextBoxColumn3.HeaderText = "questtext_en";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "templeid";
            this.dataGridViewTextBoxColumn4.DataSource = this.geographytemples1BindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "templename_gr";
            this.dataGridViewTextBoxColumn4.HeaderText = "templeid";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "templeid";
            // 
            // temple_file
            // 
            this.temple_file.DataPropertyName = "templeid";
            this.temple_file.DataSource = this.geographytemples1BindingSource1;
            this.temple_file.DisplayMember = "templeimg";
            this.temple_file.HeaderText = "temple_file";
            this.temple_file.Name = "temple_file";
            this.temple_file.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.temple_file.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.temple_file.ValueMember = "templeid";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "feedbacktext_gr";
            this.dataGridViewTextBoxColumn5.HeaderText = "feedbacktext_gr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "feedbacktext_en";
            this.dataGridViewTextBoxColumn6.HeaderText = "feedbacktext_en";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // feedbackImg
            // 
            this.feedbackImg.DataPropertyName = "feedback_img";
            this.feedbackImg.HeaderText = "feedbackImg";
            this.feedbackImg.Name = "feedbackImg";
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.Image = ((System.Drawing.Image)(resources.GetObject("details.Image")));
            this.details.Name = "details";
            this.details.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.details.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmGeographyQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.geography_questionsDataGridView);
            this.Controls.Add(this.geography_questionsBindingNavigator);
            this.Name = "frmGeographyQuestions";
            this.Load += new System.EventHandler(this.frmGeographyQuestions_Load);
            this.Controls.SetChildIndex(this.geography_questionsBindingNavigator, 0);
            this.Controls.SetChildIndex(this.geography_questionsDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionsBindingNavigator)).EndInit();
            this.geography_questionsBindingNavigator.ResumeLayout(false);
            this.geography_questionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_questionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemples1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geographytemples1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource geography_questionsBindingSource;
        private ancienttempledbDataSetTableAdapters.geography_questionsTableAdapter geography_questionsTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator geography_questionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton geography_questionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView geography_questionsDataGridView;
        private System.Windows.Forms.BindingSource geographytemples1BindingSource;
        private ancienttempledbDataSetTableAdapters.geography_temples1TableAdapter geography_temples1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn temple_file;
        private System.Windows.Forms.BindingSource geographytemples1BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackImg;
        private System.Windows.Forms.DataGridViewImageColumn details;
    }
}
