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
            this.MainWindowCloseBtn = new System.Windows.Forms.ToolStripButton();
            this.MainWindowMaxBtn = new System.Windows.Forms.ToolStripButton();
            this.MainWindowMiniBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuFileOpt = new System.Windows.Forms.ToolStripDropDownButton();
            this.FileOpenOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCreateOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCompressFileOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDecompressFileOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileEncryptOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDecryptOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuDataOpt = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuInputOpt = new System.Windows.Forms.ToolStripDropDownButton();
            this.MessageBoxInput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MainMenuSettingsOpt = new System.Windows.Forms.ToolStripDropDownButton();
            this.GeneralSettingsOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowConsoleBox = new System.Windows.Forms.RichTextBox();
            this.BackGroundWorker_A = new System.ComponentModel.BackgroundWorker();
            this.MainMenuProgressBarsOpt = new System.Windows.Forms.ToolStripProgressBar();
            this.MainMenuPorcentLabelOpt = new System.Windows.Forms.ToolStripLabel();
            this.MainWindowTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowTopMenu
            // 
            this.MainWindowTopMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainWindowTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainWindowCloseBtn,
            this.MainWindowMaxBtn,
            this.MainWindowMiniBtn,
            this.toolStripSeparator,
            this.MainMenuFileOpt,
            this.toolStripSeparator1,
            this.MainMenuDataOpt,
            this.toolStripSeparator2,
            this.MainMenuInputOpt,
            this.toolStripSeparator3,
            this.MainMenuSettingsOpt,
            this.MainMenuProgressBarsOpt,
            this.MainMenuPorcentLabelOpt});
            this.MainWindowTopMenu.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTopMenu.Name = "MainWindowTopMenu";
            this.MainWindowTopMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainWindowTopMenu.Size = new System.Drawing.Size(1062, 27);
            this.MainWindowTopMenu.TabIndex = 0;
            this.MainWindowTopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainWindowTopMenu_ItemClicked);
            // 
            // MainWindowCloseBtn
            // 
            this.MainWindowCloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainWindowCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowCloseBtn.Image")));
            this.MainWindowCloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainWindowCloseBtn.Name = "MainWindowCloseBtn";
            this.MainWindowCloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainWindowCloseBtn.Size = new System.Drawing.Size(24, 24);
            this.MainWindowCloseBtn.Text = "toolStripButton3";
            this.MainWindowCloseBtn.Click += new System.EventHandler(this.MainWindowCloseBtn_Click);
            // 
            // MainWindowMaxBtn
            // 
            this.MainWindowMaxBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainWindowMaxBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowMaxBtn.Image")));
            this.MainWindowMaxBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainWindowMaxBtn.Name = "MainWindowMaxBtn";
            this.MainWindowMaxBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainWindowMaxBtn.Size = new System.Drawing.Size(24, 24);
            this.MainWindowMaxBtn.Text = "toolStripButton2";
            this.MainWindowMaxBtn.Click += new System.EventHandler(this.MainWindowMaxBtn_Click);
            // 
            // MainWindowMiniBtn
            // 
            this.MainWindowMiniBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainWindowMiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowMiniBtn.Image")));
            this.MainWindowMiniBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainWindowMiniBtn.Name = "MainWindowMiniBtn";
            this.MainWindowMiniBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainWindowMiniBtn.Size = new System.Drawing.Size(24, 24);
            this.MainWindowMiniBtn.Text = "toolStripButton1";
            this.MainWindowMiniBtn.Click += new System.EventHandler(this.MainWindowMiniBtn_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.MainMenuFileOpt.Size = new System.Drawing.Size(44, 24);
            this.MainMenuFileOpt.Text = "File";
            // 
            // FileOpenOpt
            // 
            this.FileOpenOpt.Name = "FileOpenOpt";
            this.FileOpenOpt.Size = new System.Drawing.Size(180, 22);
            this.FileOpenOpt.Text = "Open";
            this.FileOpenOpt.Click += new System.EventHandler(this.FileOpen);
            // 
            // FileSaveOpt
            // 
            this.FileSaveOpt.Name = "FileSaveOpt";
            this.FileSaveOpt.Size = new System.Drawing.Size(180, 22);
            this.FileSaveOpt.Text = "Save";
            this.FileSaveOpt.Click += new System.EventHandler(this.FileSaveOpt_Click);
            // 
            // FileCreateOpt
            // 
            this.FileCreateOpt.Name = "FileCreateOpt";
            this.FileCreateOpt.Size = new System.Drawing.Size(180, 22);
            this.FileCreateOpt.Text = "Create";
            this.FileCreateOpt.Click += new System.EventHandler(this.FileCreateOpt_Click);
            // 
            // FileCompressFileOpt
            // 
            this.FileCompressFileOpt.Name = "FileCompressFileOpt";
            this.FileCompressFileOpt.Size = new System.Drawing.Size(180, 22);
            this.FileCompressFileOpt.Text = "Compress";
            this.FileCompressFileOpt.Click += new System.EventHandler(this.FileCompressOpt_Click);
            // 
            // FileDecompressFileOpt
            // 
            this.FileDecompressFileOpt.Name = "FileDecompressFileOpt";
            this.FileDecompressFileOpt.Size = new System.Drawing.Size(180, 22);
            this.FileDecompressFileOpt.Text = "Decompress";
            this.FileDecompressFileOpt.Click += new System.EventHandler(this.FileDecompressFileOpt_Click);
            // 
            // FileEncryptOpt
            // 
            this.FileEncryptOpt.Name = "FileEncryptOpt";
            this.FileEncryptOpt.Size = new System.Drawing.Size(180, 22);
            this.FileEncryptOpt.Text = "Encrypt";
            this.FileEncryptOpt.Click += new System.EventHandler(this.FileEncryptOpt_Click);
            // 
            // FileDecryptOpt
            // 
            this.FileDecryptOpt.Name = "FileDecryptOpt";
            this.FileDecryptOpt.Size = new System.Drawing.Size(180, 22);
            this.FileDecryptOpt.Text = "Decrypt";
            this.FileDecryptOpt.Click += new System.EventHandler(this.FileDecryptOpt_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // MainMenuDataOpt
            // 
            this.MainMenuDataOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuDataOpt.ForeColor = System.Drawing.Color.Black;
            this.MainMenuDataOpt.Name = "MainMenuDataOpt";
            this.MainMenuDataOpt.Size = new System.Drawing.Size(52, 24);
            this.MainMenuDataOpt.Text = "Data";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // MainMenuInputOpt
            // 
            this.MainMenuInputOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MessageBoxInput});
            this.MainMenuInputOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuInputOpt.ForeColor = System.Drawing.Color.Black;
            this.MainMenuInputOpt.Name = "MainMenuInputOpt";
            this.MainMenuInputOpt.Size = new System.Drawing.Size(52, 24);
            this.MainMenuInputOpt.Text = "Input";
            // 
            // MessageBoxInput
            // 
            this.MessageBoxInput.Name = "MessageBoxInput";
            this.MessageBoxInput.Size = new System.Drawing.Size(180, 22);
            this.MessageBoxInput.Text = "Message Box";
            this.MessageBoxInput.Click += new System.EventHandler(this.MessageBoxInput_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // MainMenuSettingsOpt
            // 
            this.MainMenuSettingsOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneralSettingsOpt});
            this.MainMenuSettingsOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuSettingsOpt.ForeColor = System.Drawing.Color.Black;
            this.MainMenuSettingsOpt.Name = "MainMenuSettingsOpt";
            this.MainMenuSettingsOpt.Size = new System.Drawing.Size(74, 24);
            this.MainMenuSettingsOpt.Text = "Settings";
            // 
            // GeneralSettingsOpt
            // 
            this.GeneralSettingsOpt.Name = "GeneralSettingsOpt";
            this.GeneralSettingsOpt.Size = new System.Drawing.Size(185, 22);
            this.GeneralSettingsOpt.Text = "General Settings";
            this.GeneralSettingsOpt.Click += new System.EventHandler(this.GeneralSettingsOpt_Click);
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
            this.MainWindowConsoleBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MainWindowConsoleBox.Size = new System.Drawing.Size(1062, 633);
            this.MainWindowConsoleBox.TabIndex = 3;
            this.MainWindowConsoleBox.Text = "";
            this.MainWindowConsoleBox.TextChanged += new System.EventHandler(this.MainWindowConsoleBox_TextChanged);
            this.MainWindowConsoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindowConsoleBox_KeyDown);
            // 
            // BackGroundWorker_A
            // 
            this.BackGroundWorker_A.WorkerReportsProgress = true;
            this.BackGroundWorker_A.WorkerSupportsCancellation = true;
            this.BackGroundWorker_A.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackGroundWorker_A_DoWork);
            this.BackGroundWorker_A.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackGroundWorker_A_ProgressChanged);
            this.BackGroundWorker_A.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackGroundWorker_A_RunWorkerCompleted);
            // 
            // MainMenuProgressBarsOpt
            // 
            this.MainMenuProgressBarsOpt.Name = "MainMenuProgressBarsOpt";
            this.MainMenuProgressBarsOpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMenuProgressBarsOpt.Size = new System.Drawing.Size(100, 24);
            // 
            // MainMenuPorcentLabelOpt
            // 
            this.MainMenuPorcentLabelOpt.ForeColor = System.Drawing.Color.Black;
            this.MainMenuPorcentLabelOpt.Name = "MainMenuPorcentLabelOpt";
            this.MainMenuPorcentLabelOpt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainMenuPorcentLabelOpt.Size = new System.Drawing.Size(23, 24);
            this.MainMenuPorcentLabelOpt.Text = "0%";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
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
        private System.Windows.Forms.ToolStripDropDownButton MainMenuInputOpt;
        private System.Windows.Forms.ToolStripMenuItem MessageBoxInput;
        private System.Windows.Forms.ToolStripDropDownButton MainMenuSettingsOpt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem GeneralSettingsOpt;
        private System.ComponentModel.BackgroundWorker BackGroundWorker_A;
        private System.Windows.Forms.ToolStripProgressBar MainMenuProgressBarsOpt;
        private System.Windows.Forms.ToolStripLabel MainMenuPorcentLabelOpt;
    }
}

