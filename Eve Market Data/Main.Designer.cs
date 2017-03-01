namespace Eve_Market_Data
{
    partial class Main
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
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsList = new System.Windows.Forms.DataGridView();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.marginFilterPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.marginFilterLabel = new System.Windows.Forms.Label();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uiProgressBarStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.itemLoadProgressBarBGW = new System.ComponentModel.BackgroundWorker();
            this.marginBGW = new System.ComponentModel.BackgroundWorker();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margin_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsList)).BeginInit();
            this.filterBox.SuspendLayout();
            this.marginFilterPanel.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(558, 24);
            this.mainFormMenuStrip.TabIndex = 1;
            this.mainFormMenuStrip.Text = "Main Form Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // itemsList
            // 
            this.itemsList.AllowUserToAddRows = false;
            this.itemsList.AllowUserToDeleteRows = false;
            this.itemsList.AllowUserToOrderColumns = true;
            this.itemsList.AllowUserToResizeRows = false;
            this.itemsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.itemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.name_column,
            this.margin_column,
            this.volume_column,
            this.rank_column});
            this.itemsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.itemsList.Location = new System.Drawing.Point(12, 200);
            this.itemsList.MultiSelect = false;
            this.itemsList.Name = "itemsList";
            this.itemsList.ReadOnly = true;
            this.itemsList.RowHeadersVisible = false;
            this.itemsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsList.Size = new System.Drawing.Size(534, 351);
            this.itemsList.StandardTab = true;
            this.itemsList.TabIndex = 1;
            this.itemsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsList_CellContentClick);
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.marginFilterPanel);
            this.filterBox.Location = new System.Drawing.Point(12, 27);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(534, 100);
            this.filterBox.TabIndex = 2;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Filters";
            // 
            // marginFilterPanel
            // 
            this.marginFilterPanel.Controls.Add(this.textBox1);
            this.marginFilterPanel.Controls.Add(this.marginFilterLabel);
            this.marginFilterPanel.Location = new System.Drawing.Point(6, 19);
            this.marginFilterPanel.Name = "marginFilterPanel";
            this.marginFilterPanel.Size = new System.Drawing.Size(145, 20);
            this.marginFilterPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(45, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // marginFilterLabel
            // 
            this.marginFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.marginFilterLabel.AutoSize = true;
            this.marginFilterLabel.Location = new System.Drawing.Point(0, 3);
            this.marginFilterLabel.Name = "marginFilterLabel";
            this.marginFilterLabel.Size = new System.Drawing.Size(39, 13);
            this.marginFilterLabel.TabIndex = 0;
            this.marginFilterLabel.Text = "Margin";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uiProgressBarStatusLabel,
            this.uiProgressBar});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 554);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(558, 22);
            this.mainStatusStrip.TabIndex = 3;
            this.mainStatusStrip.Text = "Status";
            // 
            // uiProgressBarStatusLabel
            // 
            this.uiProgressBarStatusLabel.Name = "uiProgressBarStatusLabel";
            this.uiProgressBarStatusLabel.Size = new System.Drawing.Size(82, 17);
            this.uiProgressBarStatusLabel.Text = "Items Loading";
            // 
            // uiProgressBar
            // 
            this.uiProgressBar.Name = "uiProgressBar";
            this.uiProgressBar.Size = new System.Drawing.Size(100, 16);
            this.uiProgressBar.Step = 1;
            this.uiProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.uiProgressBar.ToolTipText = "Loading items from database...";
            // 
            // itemLoadProgressBarBGW
            // 
            this.itemLoadProgressBarBGW.WorkerReportsProgress = true;
            this.itemLoadProgressBarBGW.WorkerSupportsCancellation = true;
            this.itemLoadProgressBarBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.itemLoadProgressBarBGW_DoWork);
            this.itemLoadProgressBarBGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.itemLoadProgressBarBGW_ProgressChanged);
            this.itemLoadProgressBarBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.itemLoadProgressBarBGW_RunWorkerComplete);
            // 
            // marginBGW
            // 
            this.marginBGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.marginBGW_DoWork);
            this.marginBGW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.marginBGW_ProgressChanged);
            this.marginBGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.marginBGW_RunWorkerCompleted);
            // 
            // id_column
            // 
            this.id_column.HeaderText = "ID";
            this.id_column.Name = "id_column";
            this.id_column.ReadOnly = true;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Name";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            // 
            // margin_column
            // 
            this.margin_column.HeaderText = "Margin";
            this.margin_column.Name = "margin_column";
            this.margin_column.ReadOnly = true;
            // 
            // volume_column
            // 
            this.volume_column.HeaderText = "Volume";
            this.volume_column.Name = "volume_column";
            this.volume_column.ReadOnly = true;
            // 
            // rank_column
            // 
            this.rank_column.HeaderText = "Rank";
            this.rank_column.Name = "rank_column";
            this.rank_column.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(558, 576);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Eve Market Data";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsList)).EndInit();
            this.filterBox.ResumeLayout(false);
            this.marginFilterPanel.ResumeLayout(false);
            this.marginFilterPanel.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView itemsList;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.Panel marginFilterPanel;
        private System.Windows.Forms.Label marginFilterLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel uiProgressBarStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar uiProgressBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker itemLoadProgressBarBGW;
        private System.ComponentModel.BackgroundWorker marginBGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn margin_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank_column;
    }
}

