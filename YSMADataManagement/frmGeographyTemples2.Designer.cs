﻿namespace YSMADataManagement
{
    partial class frmGeographyTemples2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeographyTemples2));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.geography_templesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geography_templesTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.geography_templesTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.geography_templesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.geography_templesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.geography_templesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previewImg = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_templesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_templesBindingNavigator)).BeginInit();
            this.geography_templesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geography_templesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // geography_templesBindingSource
            // 
            this.geography_templesBindingSource.DataMember = "geography_temples";
            this.geography_templesBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // geography_templesTableAdapter
            // 
            this.geography_templesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.didyouknowDetailsTableAdapter = null;
            this.tableAdapterManager.didyouknowTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = null;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = this.geography_templesTableAdapter;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // geography_templesBindingNavigator
            // 
            this.geography_templesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.geography_templesBindingNavigator.BindingSource = this.geography_templesBindingSource;
            this.geography_templesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.geography_templesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.geography_templesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.geography_templesBindingNavigatorSaveItem});
            this.geography_templesBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.geography_templesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.geography_templesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.geography_templesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.geography_templesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.geography_templesBindingNavigator.Name = "geography_templesBindingNavigator";
            this.geography_templesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.geography_templesBindingNavigator.Size = new System.Drawing.Size(1273, 25);
            this.geography_templesBindingNavigator.TabIndex = 1;
            this.geography_templesBindingNavigator.Text = "bindingNavigator1";
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
            // geography_templesBindingNavigatorSaveItem
            // 
            this.geography_templesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.geography_templesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("geography_templesBindingNavigatorSaveItem.Image")));
            this.geography_templesBindingNavigatorSaveItem.Name = "geography_templesBindingNavigatorSaveItem";
            this.geography_templesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.geography_templesBindingNavigatorSaveItem.Text = "Save Data";
            this.geography_templesBindingNavigatorSaveItem.Click += new System.EventHandler(this.geography_templesBindingNavigatorSaveItem_Click);
            // 
            // geography_templesDataGridView
            // 
            this.geography_templesDataGridView.AutoGenerateColumns = false;
            this.geography_templesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.geography_templesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.previewImg});
            this.geography_templesDataGridView.DataSource = this.geography_templesBindingSource;
            this.geography_templesDataGridView.Location = new System.Drawing.Point(48, 173);
            this.geography_templesDataGridView.Name = "geography_templesDataGridView";
            this.geography_templesDataGridView.Size = new System.Drawing.Size(1036, 306);
            this.geography_templesDataGridView.TabIndex = 2;
            this.geography_templesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.geography_templesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "templeid";
            this.dataGridViewTextBoxColumn1.HeaderText = "templeid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "templename_gr";
            this.dataGridViewTextBoxColumn2.HeaderText = "templename_gr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "templename_en";
            this.dataGridViewTextBoxColumn3.HeaderText = "templename_en";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "templeiconx";
            this.dataGridViewTextBoxColumn5.HeaderText = "templeiconx";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "templeicony";
            this.dataGridViewTextBoxColumn6.HeaderText = "templeicony";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "templeimg";
            this.dataGridViewTextBoxColumn4.HeaderText = "templeimg";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // previewImg
            // 
            this.previewImg.HeaderText = "preview";
            this.previewImg.Name = "previewImg";
            // 
            // frmGeographyTemples2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1273, 846);
            this.Controls.Add(this.geography_templesDataGridView);
            this.Controls.Add(this.geography_templesBindingNavigator);
            this.Name = "frmGeographyTemples2";
            this.Load += new System.EventHandler(this.frmGeogrpahyTemples2_Load);
            this.Controls.SetChildIndex(this.geography_templesBindingNavigator, 0);
            this.Controls.SetChildIndex(this.geography_templesDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_templesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geography_templesBindingNavigator)).EndInit();
            this.geography_templesBindingNavigator.ResumeLayout(false);
            this.geography_templesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geography_templesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource geography_templesBindingSource;
        private ancienttempledbDataSetTableAdapters.geography_templesTableAdapter geography_templesTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator geography_templesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton geography_templesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView geography_templesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn previewImg;
    }
}
