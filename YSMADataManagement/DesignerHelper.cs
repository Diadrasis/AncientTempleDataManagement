using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YSMADataManagement
{
    class DesignerHelper
    {
        public static void MarkDropDownColumns(DataGridView dgv, string name)
        {
            dgv.Columns[name].DefaultCellStyle.BackColor = Color.GhostWhite;
        }

        public static void InactivateColumn(DataGridView dgv, string ColumnName)
        {
            dgv.Columns[ColumnName].ReadOnly = true;
            dgv.Columns[ColumnName].DefaultCellStyle.ForeColor = Color.Gray;
            dgv.Columns[ColumnName].DefaultCellStyle.BackColor = Color.Beige;
        }

        public static void InactivateNavigator(BindingNavigator nav)
        {
            nav.AddNewItem.Visible = false;
            nav.DeleteItem.Visible = false;
            nav.Enabled = true;
        }

        public static void InactivateDataGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
        }

        public static void DesignDataGridView(DataGridView dg)
        {

            dg.MultiSelect = false;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.EditMode = DataGridViewEditMode.EditOnEnter;
            //dg.Columns(0).Visible = False
            dg.Location = new Point(9, 140);
            dg.Size = new Size(1400, 450);
            dg.Font = new Font("Century Gothic", 8.75f);
            dg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            dg.AllowUserToAddRows = false;
            //dg.Dock = DockStyle.Fill;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dg.AllowUserToResizeRows = false;
            dg.RowTemplate.Height = 30;
            //dg.Columns(0).Visible = False

        }

        public static void DesignDataGridNavigator(BindingNavigator dgn)
        {
            dgn.Location = new Point(9, 105);
            dgn.Dock = DockStyle.None;
        }

        public static void DesignSmallDataGridView(DataGridView dg)
        {
            //dg.Columns(0).Visible = False
            dg.Location = new Point(9, 120);
            dg.Size = new Size(420, 250);
            dg.Font = new Font("Century Gothic", 8.75f);
            dg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            dg.AllowUserToAddRows = false;
            //dg.Dock = DockStyle.Fill;
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dg.AllowUserToResizeRows = false;
            dg.RowTemplate.Height = 30;
            //dg.Columns(0).Visible = False
        }

        public static void DesignSmallDataGridNavigator(BindingNavigator dgn)
        {
            dgn.Location = new Point(9, 90);
            dgn.Dock = DockStyle.None;
        }

    }

}
