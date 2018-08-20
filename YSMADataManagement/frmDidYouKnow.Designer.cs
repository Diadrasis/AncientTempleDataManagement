namespace YSMADataManagement
{
    partial class frmDidYouKnow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDidYouKnow));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.didyouknowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.didyouknowTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.didyouknowTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.didyouknowBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.didyouknowBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.didyouknowDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowBindingNavigator)).BeginInit();
            this.didyouknowBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // didyouknowBindingSource
            // 
            this.didyouknowBindingSource.DataMember = "didyouknow";
            this.didyouknowBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // didyouknowTableAdapter
            // 
            this.didyouknowTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.didyouknowDetailsTableAdapter = null;
            this.tableAdapterManager.didyouknowTableAdapter = this.didyouknowTableAdapter;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // didyouknowBindingNavigator
            // 
            this.didyouknowBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.didyouknowBindingNavigator.BindingSource = this.didyouknowBindingSource;
            this.didyouknowBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.didyouknowBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.didyouknowBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.didyouknowBindingNavigatorSaveItem});
            this.didyouknowBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.didyouknowBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.didyouknowBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.didyouknowBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.didyouknowBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.didyouknowBindingNavigator.Name = "didyouknowBindingNavigator";
            this.didyouknowBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.didyouknowBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.didyouknowBindingNavigator.TabIndex = 1;
            this.didyouknowBindingNavigator.Text = "bindingNavigator1";
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
            // didyouknowBindingNavigatorSaveItem
            // 
            this.didyouknowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.didyouknowBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("didyouknowBindingNavigatorSaveItem.Image")));
            this.didyouknowBindingNavigatorSaveItem.Name = "didyouknowBindingNavigatorSaveItem";
            this.didyouknowBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.didyouknowBindingNavigatorSaveItem.Text = "Save Data";
            this.didyouknowBindingNavigatorSaveItem.Click += new System.EventHandler(this.didyouknowBindingNavigatorSaveItem_Click);
            // 
            // didyouknowDataGridView
            // 
            this.didyouknowDataGridView.AutoGenerateColumns = false;
            this.didyouknowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.didyouknowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.details});
            this.didyouknowDataGridView.DataSource = this.didyouknowBindingSource;
            this.didyouknowDataGridView.Location = new System.Drawing.Point(43, 164);
            this.didyouknowDataGridView.MultiSelect = false;
            this.didyouknowDataGridView.Name = "didyouknowDataGridView";
            this.didyouknowDataGridView.Size = new System.Drawing.Size(830, 220);
            this.didyouknowDataGridView.TabIndex = 3;
            this.didyouknowDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.didyouknowDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dykid";
            this.dataGridViewTextBoxColumn1.HeaderText = "dykid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gameid";
            this.dataGridViewTextBoxColumn2.HeaderText = "gameid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "questiontext_gr";
            this.dataGridViewTextBoxColumn3.HeaderText = "questiontext_gr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "questiontext_en";
            this.dataGridViewTextBoxColumn4.HeaderText = "questiontext_en";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "answertext_gr";
            this.dataGridViewTextBoxColumn5.HeaderText = "answertext_gr";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "answertext_en";
            this.dataGridViewTextBoxColumn6.HeaderText = "answertext_en";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "imagefile";
            this.dataGridViewTextBoxColumn7.HeaderText = "imagefile";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.Image = global::YSMADataManagement.Properties.Resources.details;
            this.details.Name = "details";
            // 
            // frmDidYouKnow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1273, 846);
            this.Controls.Add(this.didyouknowDataGridView);
            this.Controls.Add(this.didyouknowBindingNavigator);
            this.Name = "frmDidYouKnow";
            this.Load += new System.EventHandler(this.frmDidYouKnow_Load);
            this.Controls.SetChildIndex(this.didyouknowBindingNavigator, 0);
            this.Controls.SetChildIndex(this.didyouknowDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowBindingNavigator)).EndInit();
            this.didyouknowBindingNavigator.ResumeLayout(false);
            this.didyouknowBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.didyouknowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource didyouknowBindingSource;
        private ancienttempledbDataSetTableAdapters.didyouknowTableAdapter didyouknowTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator didyouknowBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton didyouknowBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView didyouknowDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn details;
    }
}
