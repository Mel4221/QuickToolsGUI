namespace QuickToolsGUI
{
    partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.MainWindowTopMenu = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuFileOpt = new System.Windows.Forms.ToolStripDropDownButton();
			this.FileOpenOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.FileSaveOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.asBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FileCreateOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.FileCompressFileOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.FileDecompressFileOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.FileEncryptOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.FileDecryptOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuDataOpt = new System.Windows.Forms.ToolStripDropDownButton();
			this.DataConvert = new System.Windows.Forms.ToolStripMenuItem();
			this.DataConvertBytesToString = new System.Windows.Forms.ToolStripMenuItem();
			this.stringToBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenuSettingsOpt = new System.Windows.Forms.ToolStripDropDownButton();
			this.GeneralSettingsOpt = new System.Windows.Forms.ToolStripMenuItem();
			this.TestBtn = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseConsoleBtn = new System.Windows.Forms.ToolStripDropDownButton();
			this.MainMenuProgressBarsOpt = new System.Windows.Forms.ToolStripProgressBar();
			this.MainMenuPorcentLabelOpt = new System.Windows.Forms.ToolStripLabel();
			this.MainWindowCloseBtn = new System.Windows.Forms.ToolStripButton();
			this.MainWindowMaxBtn = new System.Windows.Forms.ToolStripButton();
			this.MainWindowMiniBtn = new System.Windows.Forms.ToolStripButton();
			this.HelpBtn = new System.Windows.Forms.ToolStripButton();
			this.MainWindowConsoleBox = new System.Windows.Forms.RichTextBox();
			this.BackGroundWorker_A = new System.ComponentModel.BackgroundWorker();
			this.MainWindowTopMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainWindowTopMenu
			// 
			this.MainWindowTopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainWindowTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.MainMenuFileOpt,
            this.toolStripSeparator1,
            this.MainMenuDataOpt,
            this.toolStripSeparator2,
            this.MainMenuSettingsOpt,
            this.CloseConsoleBtn,
            this.MainMenuProgressBarsOpt,
            this.MainMenuPorcentLabelOpt,
            this.MainWindowCloseBtn,
            this.MainWindowMaxBtn,
            this.MainWindowMiniBtn,
            this.HelpBtn});
			this.MainWindowTopMenu.Location = new System.Drawing.Point(0, 0);
			this.MainWindowTopMenu.Name = "MainWindowTopMenu";
			this.MainWindowTopMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MainWindowTopMenu.Size = new System.Drawing.Size(1062, 38);
			this.MainWindowTopMenu.TabIndex = 0;
			this.MainWindowTopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainWindowTopMenu_ItemClicked);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 38);
			// 
			// MainMenuFileOpt
			// 
			this.MainMenuFileOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenOpt,
            this.FileSaveOpt,
            this.FileCreateOpt,
            this.FileCompressFileOpt,
            this.FileDecompressFileOpt,
            this.FileEncryptOpt,
            this.FileDecryptOpt});
			this.MainMenuFileOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuFileOpt.ForeColor = System.Drawing.Color.Black;
			this.MainMenuFileOpt.Name = "MainMenuFileOpt";
			this.MainMenuFileOpt.Size = new System.Drawing.Size(72, 33);
			this.MainMenuFileOpt.Text = "File";
			this.MainMenuFileOpt.Click += new System.EventHandler(this.MainMenuFileOpt_Click);
			// 
			// FileOpenOpt
			// 
			this.FileOpenOpt.Name = "FileOpenOpt";
			this.FileOpenOpt.Size = new System.Drawing.Size(253, 38);
			this.FileOpenOpt.Text = "Open";
			this.FileOpenOpt.Click += new System.EventHandler(this.FileOpen);
			// 
			// FileSaveOpt
			// 
			this.FileSaveOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asBinaryToolStripMenuItem});
			this.FileSaveOpt.Name = "FileSaveOpt";
			this.FileSaveOpt.Size = new System.Drawing.Size(253, 38);
			this.FileSaveOpt.Text = "Save";
			this.FileSaveOpt.Click += new System.EventHandler(this.FileSaveOpt_Click);
			// 
			// asBinaryToolStripMenuItem
			// 
			this.asBinaryToolStripMenuItem.Name = "asBinaryToolStripMenuItem";
			this.asBinaryToolStripMenuItem.Size = new System.Drawing.Size(216, 38);
			this.asBinaryToolStripMenuItem.Text = "As Binary";
			this.asBinaryToolStripMenuItem.Click += new System.EventHandler(this.asBinaryToolStripMenuItem_Click);
			// 
			// FileCreateOpt
			// 
			this.FileCreateOpt.Name = "FileCreateOpt";
			this.FileCreateOpt.Size = new System.Drawing.Size(253, 38);
			this.FileCreateOpt.Text = "Create";
			this.FileCreateOpt.Click += new System.EventHandler(this.FileCreateOpt_Click);
			// 
			// FileCompressFileOpt
			// 
			this.FileCompressFileOpt.Name = "FileCompressFileOpt";
			this.FileCompressFileOpt.Size = new System.Drawing.Size(253, 38);
			this.FileCompressFileOpt.Text = "Compress";
			this.FileCompressFileOpt.Click += new System.EventHandler(this.FileCompressOpt_Click);
			// 
			// FileDecompressFileOpt
			// 
			this.FileDecompressFileOpt.Name = "FileDecompressFileOpt";
			this.FileDecompressFileOpt.Size = new System.Drawing.Size(253, 38);
			this.FileDecompressFileOpt.Text = "Decompress";
			this.FileDecompressFileOpt.Click += new System.EventHandler(this.FileDecompressFileOpt_Click);
			// 
			// FileEncryptOpt
			// 
			this.FileEncryptOpt.Name = "FileEncryptOpt";
			this.FileEncryptOpt.Size = new System.Drawing.Size(253, 38);
			this.FileEncryptOpt.Text = "Encrypt";
			this.FileEncryptOpt.Click += new System.EventHandler(this.FileEncryptOpt_Click);
			// 
			// FileDecryptOpt
			// 
			this.FileDecryptOpt.Name = "FileDecryptOpt";
			this.FileDecryptOpt.Size = new System.Drawing.Size(253, 38);
			this.FileDecryptOpt.Text = "Decrypt";
			this.FileDecryptOpt.Click += new System.EventHandler(this.FileDecryptOpt_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
			// 
			// MainMenuDataOpt
			// 
			this.MainMenuDataOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataConvert});
			this.MainMenuDataOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuDataOpt.ForeColor = System.Drawing.Color.Black;
			this.MainMenuDataOpt.Name = "MainMenuDataOpt";
			this.MainMenuDataOpt.Size = new System.Drawing.Size(80, 33);
			this.MainMenuDataOpt.Text = "Data";
			// 
			// DataConvert
			// 
			this.DataConvert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataConvertBytesToString,
            this.stringToBytesToolStripMenuItem});
			this.DataConvert.Name = "DataConvert";
			this.DataConvert.Size = new System.Drawing.Size(199, 38);
			this.DataConvert.Text = "Convert";
			// 
			// DataConvertBytesToString
			// 
			this.DataConvertBytesToString.Name = "DataConvertBytesToString";
			this.DataConvertBytesToString.Size = new System.Drawing.Size(268, 38);
			this.DataConvertBytesToString.Text = "BytesToString";
			this.DataConvertBytesToString.Click += new System.EventHandler(this.DataConvertBytesToString_Click);
			// 
			// stringToBytesToolStripMenuItem
			// 
			this.stringToBytesToolStripMenuItem.Name = "stringToBytesToolStripMenuItem";
			this.stringToBytesToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
			this.stringToBytesToolStripMenuItem.Text = "StringToBytes";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
			// 
			// MainMenuSettingsOpt
			// 
			this.MainMenuSettingsOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneralSettingsOpt,
            this.TestBtn});
			this.MainMenuSettingsOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuSettingsOpt.ForeColor = System.Drawing.Color.Black;
			this.MainMenuSettingsOpt.Name = "MainMenuSettingsOpt";
			this.MainMenuSettingsOpt.Size = new System.Drawing.Size(118, 33);
			this.MainMenuSettingsOpt.Text = "Settings";
			// 
			// GeneralSettingsOpt
			// 
			this.GeneralSettingsOpt.Name = "GeneralSettingsOpt";
			this.GeneralSettingsOpt.Size = new System.Drawing.Size(295, 38);
			this.GeneralSettingsOpt.Text = "General Settings";
			this.GeneralSettingsOpt.Click += new System.EventHandler(this.GeneralSettingsOpt_Click);
			// 
			// TestBtn
			// 
			this.TestBtn.Name = "TestBtn";
			this.TestBtn.Size = new System.Drawing.Size(295, 38);
			this.TestBtn.Text = "Test";
			this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
			// 
			// CloseConsoleBtn
			// 
			this.CloseConsoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseConsoleBtn.ForeColor = System.Drawing.Color.Black;
			this.CloseConsoleBtn.Name = "CloseConsoleBtn";
			this.CloseConsoleBtn.Size = new System.Drawing.Size(190, 33);
			this.CloseConsoleBtn.Text = "Close Console";
			this.CloseConsoleBtn.Visible = false;
			this.CloseConsoleBtn.Click += new System.EventHandler(this.CloseConsoleBtn_Click);
			// 
			// MainMenuProgressBarsOpt
			// 
			this.MainMenuProgressBarsOpt.Name = "MainMenuProgressBarsOpt";
			this.MainMenuProgressBarsOpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.MainMenuProgressBarsOpt.Size = new System.Drawing.Size(100, 33);
			// 
			// MainMenuPorcentLabelOpt
			// 
			this.MainMenuPorcentLabelOpt.ForeColor = System.Drawing.Color.Black;
			this.MainMenuPorcentLabelOpt.Name = "MainMenuPorcentLabelOpt";
			this.MainMenuPorcentLabelOpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.MainMenuPorcentLabelOpt.Size = new System.Drawing.Size(37, 33);
			this.MainMenuPorcentLabelOpt.Text = "0%";
			// 
			// MainWindowCloseBtn
			// 
			this.MainWindowCloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.MainWindowCloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainWindowCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowCloseBtn.Image")));
			this.MainWindowCloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainWindowCloseBtn.Name = "MainWindowCloseBtn";
			this.MainWindowCloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MainWindowCloseBtn.Size = new System.Drawing.Size(34, 33);
			this.MainWindowCloseBtn.Text = "Close";
			this.MainWindowCloseBtn.Click += new System.EventHandler(this.MainWindowCloseBtn_Click);
			// 
			// MainWindowMaxBtn
			// 
			this.MainWindowMaxBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.MainWindowMaxBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainWindowMaxBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowMaxBtn.Image")));
			this.MainWindowMaxBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainWindowMaxBtn.Name = "MainWindowMaxBtn";
			this.MainWindowMaxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MainWindowMaxBtn.Size = new System.Drawing.Size(34, 33);
			this.MainWindowMaxBtn.Text = "Maximize";
			this.MainWindowMaxBtn.Click += new System.EventHandler(this.MainWindowMaxBtn_Click);
			// 
			// MainWindowMiniBtn
			// 
			this.MainWindowMiniBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.MainWindowMiniBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.MainWindowMiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowMiniBtn.Image")));
			this.MainWindowMiniBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MainWindowMiniBtn.Name = "MainWindowMiniBtn";
			this.MainWindowMiniBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MainWindowMiniBtn.Size = new System.Drawing.Size(34, 33);
			this.MainWindowMiniBtn.Text = "Minimize";
			this.MainWindowMiniBtn.Click += new System.EventHandler(this.MainWindowMiniBtn_Click);
			// 
			// HelpBtn
			// 
			this.HelpBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
			this.HelpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.HelpBtn.Name = "HelpBtn";
			this.HelpBtn.Size = new System.Drawing.Size(34, 33);
			this.HelpBtn.Text = "Help";
			this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
			// 
			// MainWindowConsoleBox
			// 
			this.MainWindowConsoleBox.AcceptsTab = true;
			this.MainWindowConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainWindowConsoleBox.BackColor = System.Drawing.Color.Black;
			this.MainWindowConsoleBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.MainWindowConsoleBox.EnableAutoDragDrop = true;
			this.MainWindowConsoleBox.ForeColor = System.Drawing.Color.Lime;
			this.MainWindowConsoleBox.Location = new System.Drawing.Point(0, 28);
			this.MainWindowConsoleBox.Name = "MainWindowConsoleBox";
			this.MainWindowConsoleBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.MainWindowConsoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.MainWindowConsoleBox.Size = new System.Drawing.Size(1062, 633);
			this.MainWindowConsoleBox.TabIndex = 3;
			this.MainWindowConsoleBox.Text = "";
			this.MainWindowConsoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindowConsoleBox_KeyDown);
			this.MainWindowConsoleBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindowConsoleBox_MouseMove);
			// 
			// BackGroundWorker_A
			// 
			this.BackGroundWorker_A.WorkerReportsProgress = true;
			this.BackGroundWorker_A.WorkerSupportsCancellation = true;
			this.BackGroundWorker_A.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundWorker_A_DoWork);
			this.BackGroundWorker_A.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackGroundWorker_A_ProgressChanged);
			this.BackGroundWorker_A.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundWorker_A_RunWorkerCompleted);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 40F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1062, 673);
			this.Controls.Add(this.MainWindowConsoleBox);
			this.Controls.Add(this.MainWindowTopMenu);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Lime;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuickTools";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.MainWindowTopMenu.ResumeLayout(false);
			this.MainWindowTopMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainWindowTopMenu;
        private System.Windows.Forms.ToolStripButton MainWindowMiniBtn;
        private System.Windows.Forms.ToolStripButton MainWindowMaxBtn;
        private System.Windows.Forms.ToolStripButton MainWindowCloseBtn;
        public System.Windows.Forms.RichTextBox MainWindowConsoleBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripDropDownButton MainMenuFileOpt;
        private System.Windows.Forms.ToolStripMenuItem FileOpenOpt;
        private System.Windows.Forms.ToolStripMenuItem FileCreateOpt;
        private System.Windows.Forms.ToolStripMenuItem FileEncryptOpt;
        private System.Windows.Forms.ToolStripMenuItem FileSaveOpt;
        private System.Windows.Forms.ToolStripMenuItem FileCompressFileOpt;
        private System.Windows.Forms.ToolStripMenuItem FileDecompressFileOpt;
        private System.Windows.Forms.ToolStripMenuItem FileDecryptOpt;
        private System.Windows.Forms.ToolStripDropDownButton MainMenuDataOpt;
        private System.Windows.Forms.ToolStripDropDownButton MainMenuSettingsOpt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.ComponentModel.BackgroundWorker BackGroundWorker_A;
        private System.Windows.Forms.ToolStripProgressBar MainMenuProgressBarsOpt;
        private System.Windows.Forms.ToolStripLabel MainMenuPorcentLabelOpt;
        private System.Windows.Forms.ToolStripButton HelpBtn;
        private System.Windows.Forms.ToolStripMenuItem DataConvert;
        private System.Windows.Forms.ToolStripMenuItem DataConvertBytesToString;
        private System.Windows.Forms.ToolStripMenuItem stringToBytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GeneralSettingsOpt;
        private System.Windows.Forms.ToolStripMenuItem TestBtn;
        private System.Windows.Forms.ToolStripDropDownButton CloseConsoleBtn;
    }
}

