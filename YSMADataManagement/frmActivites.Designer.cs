namespace YSMADataManagement
{
    partial class frmActivites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivites));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.construction_activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.construction_activitiesTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.construction_activitiesTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.construction_activitiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.construction_activitiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.construction_activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preview = new System.Windows.Forms.DataGridViewImageColumn();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activitiesBindingNavigator)).BeginInit();
            this.construction_activitiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // construction_activitiesBindingSource
            // 
            this.construction_activitiesBindingSource.DataMember = "construction_activities";
            this.construction_activitiesBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // construction_activitiesTableAdapter
            // 
            this.construction_activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.construction_activitiesTableAdapter = this.construction_activitiesTableAdapter;
            this.tableAdapterManager.construction_activityTableAdapter = null;
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
            // construction_activitiesBindingNavigator
            // 
            this.construction_activitiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.construction_activitiesBindingNavigator.BindingSource = this.construction_activitiesBindingSource;
            this.construction_activitiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.construction_activitiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.construction_activitiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.construction_activitiesBindingNavigatorSaveItem});
            this.construction_activitiesBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.construction_activitiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.construction_activitiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.construction_activitiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.construction_activitiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.construction_activitiesBindingNavigator.Name = "construction_activitiesBindingNavigator";
            this.construction_activitiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.construction_activitiesBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.construction_activitiesBindingNavigator.TabIndex = 1;
            this.construction_activitiesBindingNavigator.Text = "bindingNavigator1";
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
            // construction_activitiesBindingNavigatorSaveItem
            // 
            this.construction_activitiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.construction_activitiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("construction_activitiesBindingNavigatorSaveItem.Image")));
            this.construction_activitiesBindingNavigatorSaveItem.Name = "construction_activitiesBindingNavigatorSaveItem";
            this.construction_activitiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.construction_activitiesBindingNavigatorSaveItem.Text = "Save Data";
            this.construction_activitiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.construction_activitiesBindingNavigatorSaveItem_Click);
            // 
            // construction_activitiesDataGridView
            // 
            this.construction_activitiesDataGridView.AutoGenerateColumns = false;
            this.construction_activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.construction_activitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.preview,
            this.details});
            this.construction_activitiesDataGridView.DataSource = this.construction_activitiesBindingSource;
            this.construction_activitiesDataGridView.Location = new System.Drawing.Point(85, 202);
            this.construction_activitiesDataGridView.Name = "construction_activitiesDataGridView";
            this.construction_activitiesDataGridView.Size = new System.Drawing.Size(887, 220);
            this.construction_activitiesDataGridView.TabIndex = 3;
            this.construction_activitiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.construction_activitiesDataGridView_CellContentClick);
            this.construction_activitiesDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.construction_activitiesDataGridView_RowEnter);
             // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "activity_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "activity_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stage_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "stage_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "activity_desc_gr";
            this.dataGridViewTextBoxColumn3.HeaderText = "activity_desc_gr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "activity_desc_en";
            this.dataGridViewTextBoxColumn4.HeaderText = "activity_desc_en";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "activity_image";
            this.dataGridViewTextBoxColumn5.HeaderText = "activity_image";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // preview
            // 
            this.preview.HeaderText = "preview";
            this.preview.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.preview.Name = "preview";
            // 
            // details
            // 
            this.details.HeaderText = "detail";
            this.details.Image = global::YSMADataManagement.Properties.Resources.details;
            this.details.Name = "details";
            // 
            // frmActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1273, 749);
            this.Controls.Add(this.construction_activitiesDataGridView);
            this.Controls.Add(this.construction_activitiesBindingNavigator);
            this.Name = "frmActivites";
            this.Load += new System.EventHandler(this.frmActivites_Load);
            this.Controls.SetChildIndex(this.construction_activitiesBindingNavigator, 0);
            this.Controls.SetChildIndex(this.construction_activitiesDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activitiesBindingNavigator)).EndInit();
            this.construction_activitiesBindingNavigator.ResumeLayout(false);
            this.construction_activitiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.construction_activitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource construction_activitiesBindingSource;
        private ancienttempledbDataSetTableAdapters.construction_activitiesTableAdapter construction_activitiesTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator construction_activitiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton construction_activitiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView construction_activitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn preview;
        private System.Windows.Forms.DataGridViewImageColumn details;
    }
}
