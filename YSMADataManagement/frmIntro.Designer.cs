namespace YSMADataManagement
{
    partial class frmIntro
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
            System.Windows.Forms.Label gameidLabel;
            System.Windows.Forms.Label gamecodenameLabel;
            System.Windows.Forms.Label gamename_grLabel;
            System.Windows.Forms.Label gamename_enLabel;
            System.Windows.Forms.Label gametitle_grLabel;
            System.Windows.Forms.Label gametitle_enLabel;
            System.Windows.Forms.Label gameiconLabel;
            System.Windows.Forms.Label gameintro_grLabel;
            System.Windows.Forms.Label gameintro_enLabel;
            System.Windows.Forms.Label gamecharLabel;
            System.Windows.Forms.Label gamecharname_grLabel;
            System.Windows.Forms.Label gamecharname_enLabel;
            System.Windows.Forms.Label gamecharintro_grLabel;
            System.Windows.Forms.Label gamecharintro_enLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntro));
            this.ancienttempledbDataSet = new YSMADataManagement.ancienttempledbDataSet();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new YSMADataManagement.ancienttempledbDataSetTableAdapters.gamesTableAdapter();
            this.tableAdapterManager = new YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager();
            this.gamesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.gamesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gameidTextBox = new System.Windows.Forms.TextBox();
            this.gamecodenameTextBox = new System.Windows.Forms.TextBox();
            this.gamename_grTextBox = new System.Windows.Forms.TextBox();
            this.gamename_enTextBox = new System.Windows.Forms.TextBox();
            this.gametitle_grTextBox = new System.Windows.Forms.TextBox();
            this.gametitle_enTextBox = new System.Windows.Forms.TextBox();
            this.gameiconTextBox = new System.Windows.Forms.TextBox();
            this.gameintro_grTextBox = new System.Windows.Forms.TextBox();
            this.gameintro_enTextBox = new System.Windows.Forms.TextBox();
            this.gamecharTextBox = new System.Windows.Forms.TextBox();
            this.gamecharname_grTextBox = new System.Windows.Forms.TextBox();
            this.gamecharname_enTextBox = new System.Windows.Forms.TextBox();
            this.gamecharintro_grTextBox = new System.Windows.Forms.TextBox();
            this.gamecharintro_enTextBox = new System.Windows.Forms.TextBox();
            gameidLabel = new System.Windows.Forms.Label();
            gamecodenameLabel = new System.Windows.Forms.Label();
            gamename_grLabel = new System.Windows.Forms.Label();
            gamename_enLabel = new System.Windows.Forms.Label();
            gametitle_grLabel = new System.Windows.Forms.Label();
            gametitle_enLabel = new System.Windows.Forms.Label();
            gameiconLabel = new System.Windows.Forms.Label();
            gameintro_grLabel = new System.Windows.Forms.Label();
            gameintro_enLabel = new System.Windows.Forms.Label();
            gamecharLabel = new System.Windows.Forms.Label();
            gamecharname_grLabel = new System.Windows.Forms.Label();
            gamecharname_enLabel = new System.Windows.Forms.Label();
            gamecharintro_grLabel = new System.Windows.Forms.Label();
            gamecharintro_enLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingNavigator)).BeginInit();
            this.gamesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameidLabel
            // 
            gameidLabel.AutoSize = true;
            gameidLabel.Location = new System.Drawing.Point(40, 129);
            gameidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gameidLabel.Name = "gameidLabel";
            gameidLabel.Size = new System.Drawing.Size(63, 17);
            gameidLabel.TabIndex = 3;
            gameidLabel.Text = "gameid:";
            gameidLabel.Visible = false;
            // 
            // gamecodenameLabel
            // 
            gamecodenameLabel.AutoSize = true;
            gamecodenameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamecodenameLabel.Location = new System.Drawing.Point(11, 199);
            gamecodenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamecodenameLabel.Name = "gamecodenameLabel";
            gamecodenameLabel.Size = new System.Drawing.Size(132, 19);
            gamecodenameLabel.TabIndex = 5;
            gamecodenameLabel.Text = "gamecodename:";
            // 
            // gamename_grLabel
            // 
            gamename_grLabel.AutoSize = true;
            gamename_grLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamename_grLabel.Location = new System.Drawing.Point(11, 233);
            gamename_grLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamename_grLabel.Name = "gamename_grLabel";
            gamename_grLabel.Size = new System.Drawing.Size(112, 19);
            gamename_grLabel.TabIndex = 7;
            gamename_grLabel.Text = "gamename gr:";
            // 
            // gamename_enLabel
            // 
            gamename_enLabel.AutoSize = true;
            gamename_enLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamename_enLabel.Location = new System.Drawing.Point(717, 237);
            gamename_enLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamename_enLabel.Name = "gamename_enLabel";
            gamename_enLabel.Size = new System.Drawing.Size(117, 19);
            gamename_enLabel.TabIndex = 9;
            gamename_enLabel.Text = "gamename en:";
            // 
            // gametitle_grLabel
            // 
            gametitle_grLabel.AutoSize = true;
            gametitle_grLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gametitle_grLabel.Location = new System.Drawing.Point(11, 267);
            gametitle_grLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gametitle_grLabel.Name = "gametitle_grLabel";
            gametitle_grLabel.Size = new System.Drawing.Size(96, 19);
            gametitle_grLabel.TabIndex = 11;
            gametitle_grLabel.Text = "gametitle gr:";
            // 
            // gametitle_enLabel
            // 
            gametitle_enLabel.AutoSize = true;
            gametitle_enLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gametitle_enLabel.Location = new System.Drawing.Point(717, 275);
            gametitle_enLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gametitle_enLabel.Name = "gametitle_enLabel";
            gametitle_enLabel.Size = new System.Drawing.Size(101, 19);
            gametitle_enLabel.TabIndex = 13;
            gametitle_enLabel.Text = "gametitle en:";
            // 
            // gameiconLabel
            // 
            gameiconLabel.AutoSize = true;
            gameiconLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gameiconLabel.Location = new System.Drawing.Point(16, 165);
            gameiconLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gameiconLabel.Name = "gameiconLabel";
            gameiconLabel.Size = new System.Drawing.Size(84, 19);
            gameiconLabel.TabIndex = 15;
            gameiconLabel.Text = "gameicon:";
            // 
            // gameintro_grLabel
            // 
            gameintro_grLabel.AutoSize = true;
            gameintro_grLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gameintro_grLabel.Location = new System.Drawing.Point(237, 309);
            gameintro_grLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gameintro_grLabel.Name = "gameintro_grLabel";
            gameintro_grLabel.Size = new System.Drawing.Size(101, 19);
            gameintro_grLabel.TabIndex = 17;
            gameintro_grLabel.Text = "gameintro gr:";
            // 
            // gameintro_enLabel
            // 
            gameintro_enLabel.AutoSize = true;
            gameintro_enLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gameintro_enLabel.Location = new System.Drawing.Point(863, 309);
            gameintro_enLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gameintro_enLabel.Name = "gameintro_enLabel";
            gameintro_enLabel.Size = new System.Drawing.Size(106, 19);
            gameintro_enLabel.TabIndex = 19;
            gameintro_enLabel.Text = "gameintro en:";
            // 
            // gamecharLabel
            // 
            gamecharLabel.AutoSize = true;
            gamecharLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamecharLabel.Location = new System.Drawing.Point(11, 612);
            gamecharLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamecharLabel.Name = "gamecharLabel";
            gamecharLabel.Size = new System.Drawing.Size(86, 19);
            gamecharLabel.TabIndex = 21;
            gamecharLabel.Text = "gamechar:";
            // 
            // gamecharname_grLabel
            // 
            gamecharname_grLabel.AutoSize = true;
            gamecharname_grLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamecharname_grLabel.Location = new System.Drawing.Point(11, 571);
            gamecharname_grLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamecharname_grLabel.Name = "gamecharname_grLabel";
            gamecharname_grLabel.Size = new System.Drawing.Size(144, 19);
            gamecharname_grLabel.TabIndex = 23;
            gamecharname_grLabel.Text = "gamecharname gr:";
            // 
            // gamecharname_enLabel
            // 
            gamecharname_enLabel.AutoSize = true;
            gamecharname_enLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamecharname_enLabel.Location = new System.Drawing.Point(717, 579);
            gamecharname_enLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamecharname_enLabel.Name = "gamecharname_enLabel";
            gamecharname_enLabel.Size = new System.Drawing.Size(149, 19);
            gamecharname_enLabel.TabIndex = 25;
            gamecharname_enLabel.Text = "gamecharname en:";
            // 
            // gamecharintro_grLabel
            // 
            gamecharintro_grLabel.AutoSize = true;
            gamecharintro_grLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamecharintro_grLabel.Location = new System.Drawing.Point(11, 605);
            gamecharintro_grLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamecharintro_grLabel.Name = "gamecharintro_grLabel";
            gamecharintro_grLabel.Size = new System.Drawing.Size(133, 19);
            gamecharintro_grLabel.TabIndex = 27;
            gamecharintro_grLabel.Text = "gamecharintro gr:";
            // 
            // gamecharintro_enLabel
            // 
            gamecharintro_enLabel.AutoSize = true;
            gamecharintro_enLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            gamecharintro_enLabel.Location = new System.Drawing.Point(717, 613);
            gamecharintro_enLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gamecharintro_enLabel.Name = "gamecharintro_enLabel";
            gamecharintro_enLabel.Size = new System.Drawing.Size(138, 19);
            gamecharintro_enLabel.TabIndex = 29;
            gamecharintro_enLabel.Text = "gamecharintro en:";
            // 
            // ancienttempledbDataSet
            // 
            this.ancienttempledbDataSet.DataSetName = "ancienttempledbDataSet";
            this.ancienttempledbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "games";
            this.gamesBindingSource.DataSource = this.ancienttempledbDataSet;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.didyouknowDetailsTableAdapter = null;
            this.tableAdapterManager.didyouknowTableAdapter = null;
            this.tableAdapterManager.gamesTableAdapter = this.gamesTableAdapter;
            this.tableAdapterManager.geography_questionsTableAdapter = null;
            this.tableAdapterManager.geography_questionTableAdapter = null;
            this.tableAdapterManager.geography_templesTableAdapter = null;
            this.tableAdapterManager.playersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = YSMADataManagement.ancienttempledbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gamesBindingNavigator
            // 
            this.gamesBindingNavigator.AddNewItem = null;
            this.gamesBindingNavigator.BindingSource = this.gamesBindingSource;
            this.gamesBindingNavigator.CountItem = null;
            this.gamesBindingNavigator.DeleteItem = null;
            this.gamesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesBindingNavigatorSaveItem});
            this.gamesBindingNavigator.Location = new System.Drawing.Point(0, 97);
            this.gamesBindingNavigator.MoveFirstItem = null;
            this.gamesBindingNavigator.MoveLastItem = null;
            this.gamesBindingNavigator.MoveNextItem = null;
            this.gamesBindingNavigator.MovePreviousItem = null;
            this.gamesBindingNavigator.Name = "gamesBindingNavigator";
            this.gamesBindingNavigator.PositionItem = null;
            this.gamesBindingNavigator.Size = new System.Drawing.Size(1370, 25);
            this.gamesBindingNavigator.TabIndex = 1;
            this.gamesBindingNavigator.Text = "bindingNavigator1";
            // 
            // gamesBindingNavigatorSaveItem
            // 
            this.gamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gamesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gamesBindingNavigatorSaveItem.Image")));
            this.gamesBindingNavigatorSaveItem.Name = "gamesBindingNavigatorSaveItem";
            this.gamesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gamesBindingNavigatorSaveItem.Text = "Save Data";
            this.gamesBindingNavigatorSaveItem.Click += new System.EventHandler(this.gamesBindingNavigatorSaveItem_Click);
            // 
            // gameidTextBox
            // 
            this.gameidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gameid", true));
            this.gameidTextBox.Location = new System.Drawing.Point(178, 126);
            this.gameidTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gameidTextBox.Name = "gameidTextBox";
            this.gameidTextBox.Size = new System.Drawing.Size(132, 23);
            this.gameidTextBox.TabIndex = 4;
            this.gameidTextBox.Visible = false;
            // 
            // gamecodenameTextBox
            // 
            this.gamecodenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamecodename", true));
            this.gamecodenameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamecodenameTextBox.Location = new System.Drawing.Point(232, 199);
            this.gamecodenameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamecodenameTextBox.Name = "gamecodenameTextBox";
            this.gamecodenameTextBox.Size = new System.Drawing.Size(132, 24);
            this.gamecodenameTextBox.TabIndex = 6;
            // 
            // gamename_grTextBox
            // 
            this.gamename_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamename_gr", true));
            this.gamename_grTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamename_grTextBox.Location = new System.Drawing.Point(232, 233);
            this.gamename_grTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamename_grTextBox.Name = "gamename_grTextBox";
            this.gamename_grTextBox.Size = new System.Drawing.Size(260, 24);
            this.gamename_grTextBox.TabIndex = 8;
            // 
            // gamename_enTextBox
            // 
            this.gamename_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamename_en", true));
            this.gamename_enTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamename_enTextBox.Location = new System.Drawing.Point(867, 237);
            this.gamename_enTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamename_enTextBox.Name = "gamename_enTextBox";
            this.gamename_enTextBox.Size = new System.Drawing.Size(231, 24);
            this.gamename_enTextBox.TabIndex = 10;
            // 
            // gametitle_grTextBox
            // 
            this.gametitle_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gametitle_gr", true));
            this.gametitle_grTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gametitle_grTextBox.Location = new System.Drawing.Point(232, 267);
            this.gametitle_grTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gametitle_grTextBox.Name = "gametitle_grTextBox";
            this.gametitle_grTextBox.Size = new System.Drawing.Size(260, 24);
            this.gametitle_grTextBox.TabIndex = 12;
            // 
            // gametitle_enTextBox
            // 
            this.gametitle_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gametitle_en", true));
            this.gametitle_enTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gametitle_enTextBox.Location = new System.Drawing.Point(867, 267);
            this.gametitle_enTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gametitle_enTextBox.Name = "gametitle_enTextBox";
            this.gametitle_enTextBox.Size = new System.Drawing.Size(231, 24);
            this.gametitle_enTextBox.TabIndex = 14;
            // 
            // gameiconTextBox
            // 
            this.gameiconTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gameicon", true));
            this.gameiconTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gameiconTextBox.Location = new System.Drawing.Point(232, 165);
            this.gameiconTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gameiconTextBox.Name = "gameiconTextBox";
            this.gameiconTextBox.Size = new System.Drawing.Size(132, 24);
            this.gameiconTextBox.TabIndex = 16;
            // 
            // gameintro_grTextBox
            // 
            this.gameintro_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gameintro_gr", true));
            this.gameintro_grTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gameintro_grTextBox.Location = new System.Drawing.Point(232, 332);
            this.gameintro_grTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gameintro_grTextBox.Multiline = true;
            this.gameintro_grTextBox.Name = "gameintro_grTextBox";
            this.gameintro_grTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameintro_grTextBox.Size = new System.Drawing.Size(459, 188);
            this.gameintro_grTextBox.TabIndex = 18;
            // 
            // gameintro_enTextBox
            // 
            this.gameintro_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gameintro_en", true));
            this.gameintro_enTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gameintro_enTextBox.Location = new System.Drawing.Point(867, 332);
            this.gameintro_enTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gameintro_enTextBox.Multiline = true;
            this.gameintro_enTextBox.Name = "gameintro_enTextBox";
            this.gameintro_enTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gameintro_enTextBox.Size = new System.Drawing.Size(490, 188);
            this.gameintro_enTextBox.TabIndex = 20;
            // 
            // gamecharTextBox
            // 
            this.gamecharTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamechar", true));
            this.gamecharTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamecharTextBox.Location = new System.Drawing.Point(232, 533);
            this.gamecharTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamecharTextBox.Name = "gamecharTextBox";
            this.gamecharTextBox.Size = new System.Drawing.Size(132, 24);
            this.gamecharTextBox.TabIndex = 22;
            // 
            // gamecharname_grTextBox
            // 
            this.gamecharname_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamecharname_gr", true));
            this.gamecharname_grTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamecharname_grTextBox.Location = new System.Drawing.Point(232, 571);
            this.gamecharname_grTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamecharname_grTextBox.Name = "gamecharname_grTextBox";
            this.gamecharname_grTextBox.Size = new System.Drawing.Size(132, 24);
            this.gamecharname_grTextBox.TabIndex = 24;
            // 
            // gamecharname_enTextBox
            // 
            this.gamecharname_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamecharname_en", true));
            this.gamecharname_enTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamecharname_enTextBox.Location = new System.Drawing.Point(867, 581);
            this.gamecharname_enTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamecharname_enTextBox.Name = "gamecharname_enTextBox";
            this.gamecharname_enTextBox.Size = new System.Drawing.Size(132, 24);
            this.gamecharname_enTextBox.TabIndex = 26;
            // 
            // gamecharintro_grTextBox
            // 
            this.gamecharintro_grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamecharintro_gr", true));
            this.gamecharintro_grTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamecharintro_grTextBox.Location = new System.Drawing.Point(232, 605);
            this.gamecharintro_grTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamecharintro_grTextBox.Multiline = true;
            this.gamecharintro_grTextBox.Name = "gamecharintro_grTextBox";
            this.gamecharintro_grTextBox.Size = new System.Drawing.Size(459, 131);
            this.gamecharintro_grTextBox.TabIndex = 28;
            // 
            // gamecharintro_enTextBox
            // 
            this.gamecharintro_enTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gamesBindingSource, "gamecharintro_en", true));
            this.gamecharintro_enTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.gamecharintro_enTextBox.Location = new System.Drawing.Point(867, 613);
            this.gamecharintro_enTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.gamecharintro_enTextBox.Multiline = true;
            this.gamecharintro_enTextBox.Name = "gamecharintro_enTextBox";
            this.gamecharintro_enTextBox.Size = new System.Drawing.Size(490, 127);
            this.gamecharintro_enTextBox.TabIndex = 30;
            // 
            // frmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(gameidLabel);
            this.Controls.Add(this.gameidTextBox);
            this.Controls.Add(gamecodenameLabel);
            this.Controls.Add(this.gamecodenameTextBox);
            this.Controls.Add(gamename_grLabel);
            this.Controls.Add(this.gamename_grTextBox);
            this.Controls.Add(gamename_enLabel);
            this.Controls.Add(this.gamename_enTextBox);
            this.Controls.Add(gametitle_grLabel);
            this.Controls.Add(this.gametitle_grTextBox);
            this.Controls.Add(gametitle_enLabel);
            this.Controls.Add(this.gametitle_enTextBox);
            this.Controls.Add(gameiconLabel);
            this.Controls.Add(this.gameiconTextBox);
            this.Controls.Add(gameintro_grLabel);
            this.Controls.Add(this.gameintro_grTextBox);
            this.Controls.Add(gameintro_enLabel);
            this.Controls.Add(this.gameintro_enTextBox);
            this.Controls.Add(gamecharLabel);
            this.Controls.Add(this.gamecharTextBox);
            this.Controls.Add(gamecharname_grLabel);
            this.Controls.Add(this.gamecharname_grTextBox);
            this.Controls.Add(gamecharname_enLabel);
            this.Controls.Add(this.gamecharname_enTextBox);
            this.Controls.Add(gamecharintro_grLabel);
            this.Controls.Add(this.gamecharintro_grTextBox);
            this.Controls.Add(gamecharintro_enLabel);
            this.Controls.Add(this.gamecharintro_enTextBox);
            this.Controls.Add(this.gamesBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIntro";
            this.Load += new System.EventHandler(this.frmIntro_Load);
            this.Controls.SetChildIndex(this.gamesBindingNavigator, 0);
            this.Controls.SetChildIndex(this.gamecharintro_enTextBox, 0);
            this.Controls.SetChildIndex(gamecharintro_enLabel, 0);
            this.Controls.SetChildIndex(this.gamecharintro_grTextBox, 0);
            this.Controls.SetChildIndex(gamecharintro_grLabel, 0);
            this.Controls.SetChildIndex(this.gamecharname_enTextBox, 0);
            this.Controls.SetChildIndex(gamecharname_enLabel, 0);
            this.Controls.SetChildIndex(this.gamecharname_grTextBox, 0);
            this.Controls.SetChildIndex(gamecharname_grLabel, 0);
            this.Controls.SetChildIndex(this.gamecharTextBox, 0);
            this.Controls.SetChildIndex(gamecharLabel, 0);
            this.Controls.SetChildIndex(this.gameintro_enTextBox, 0);
            this.Controls.SetChildIndex(gameintro_enLabel, 0);
            this.Controls.SetChildIndex(this.gameintro_grTextBox, 0);
            this.Controls.SetChildIndex(gameintro_grLabel, 0);
            this.Controls.SetChildIndex(this.gameiconTextBox, 0);
            this.Controls.SetChildIndex(gameiconLabel, 0);
            this.Controls.SetChildIndex(this.gametitle_enTextBox, 0);
            this.Controls.SetChildIndex(gametitle_enLabel, 0);
            this.Controls.SetChildIndex(this.gametitle_grTextBox, 0);
            this.Controls.SetChildIndex(gametitle_grLabel, 0);
            this.Controls.SetChildIndex(this.gamename_enTextBox, 0);
            this.Controls.SetChildIndex(gamename_enLabel, 0);
            this.Controls.SetChildIndex(this.gamename_grTextBox, 0);
            this.Controls.SetChildIndex(gamename_grLabel, 0);
            this.Controls.SetChildIndex(this.gamecodenameTextBox, 0);
            this.Controls.SetChildIndex(gamecodenameLabel, 0);
            this.Controls.SetChildIndex(this.gameidTextBox, 0);
            this.Controls.SetChildIndex(gameidLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ancienttempledbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingNavigator)).EndInit();
            this.gamesBindingNavigator.ResumeLayout(false);
            this.gamesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ancienttempledbDataSet ancienttempledbDataSet;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private ancienttempledbDataSetTableAdapters.gamesTableAdapter gamesTableAdapter;
        private ancienttempledbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gamesBindingNavigator;
        private System.Windows.Forms.ToolStripButton gamesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gameidTextBox;
        private System.Windows.Forms.TextBox gamecodenameTextBox;
        private System.Windows.Forms.TextBox gamename_grTextBox;
        private System.Windows.Forms.TextBox gamename_enTextBox;
        private System.Windows.Forms.TextBox gametitle_grTextBox;
        private System.Windows.Forms.TextBox gametitle_enTextBox;
        private System.Windows.Forms.TextBox gameiconTextBox;
        private System.Windows.Forms.TextBox gameintro_grTextBox;
        private System.Windows.Forms.TextBox gameintro_enTextBox;
        private System.Windows.Forms.TextBox gamecharTextBox;
        private System.Windows.Forms.TextBox gamecharname_grTextBox;
        private System.Windows.Forms.TextBox gamecharname_enTextBox;
        private System.Windows.Forms.TextBox gamecharintro_grTextBox;
        private System.Windows.Forms.TextBox gamecharintro_enTextBox;
    }
}
