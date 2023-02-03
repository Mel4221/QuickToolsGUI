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
            this.FileCompressOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileEncryptOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowConsoleBox = new System.Windows.Forms.RichTextBox();
            this.FileDecompressFileOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCompressFileOpt = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MainMenuFileOpt});
            this.MainWindowTopMenu.Location = new System.Drawing.Point(0, 0);
            this.MainWindowTopMenu.Name = "MainWindowTopMenu";
            this.MainWindowTopMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainWindowTopMenu.Size = new System.Drawing.Size(1062, 41);
            this.MainWindowTopMenu.TabIndex = 0;
            // 
            // MainWindowCloseBtn
            // 
            this.MainWindowCloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainWindowCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainWindowCloseBtn.Image")));
            this.MainWindowCloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainWindowCloseBtn.Name = "MainWindowCloseBtn";
            this.MainWindowCloseBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainWindowCloseBtn.Size = new System.Drawing.Size(40, 35);
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
            this.MainWindowMaxBtn.Size = new System.Drawing.Size(40, 38);
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
            this.MainWindowMiniBtn.Size = new System.Drawing.Size(40, 38);
            this.MainWindowMiniBtn.Text = "toolStripButton1";
            this.MainWindowMiniBtn.Click += new System.EventHandler(this.MainWindowMiniBtn_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 44);
            // 
            // MainMenuFileOpt
            // 
            this.MainMenuFileOpt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenOpt,
            this.FileSaveOpt,
            this.FileCreateOpt,
            this.FileCompressFileOpt,
            this.FileDecompressFileOpt,
            this.FileCompressOpt,
            this.FileEncryptOpt});
            this.MainMenuFileOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuFileOpt.ForeColor = System.Drawing.Color.Black;
            this.MainMenuFileOpt.Name = "MainMenuFileOpt";
            this.MainMenuFileOpt.Size = new System.Drawing.Size(79, 35);
            this.MainMenuFileOpt.Text = "File";
            // 
            // FileOpenOpt
            // 
            this.FileOpenOpt.Name = "FileOpenOpt";
            this.FileOpenOpt.Size = new System.Drawing.Size(315, 40);
            this.FileOpenOpt.Text = "Open";
            this.FileOpenOpt.Click += new System.EventHandler(this.FileOpen);
            // 
            // FileSaveOpt
            // 
            this.FileSaveOpt.Name = "FileSaveOpt";
            this.FileSaveOpt.Size = new System.Drawing.Size(315, 40);
            this.FileSaveOpt.Text = "Save";
            this.FileSaveOpt.Click += new System.EventHandler(this.FileSaveOpt_Click);
            // 
            // FileCreateOpt
            // 
            this.FileCreateOpt.Name = "FileCreateOpt";
            this.FileCreateOpt.Size = new System.Drawing.Size(315, 40);
            this.FileCreateOpt.Text = "Create";
            this.FileCreateOpt.Click += new System.EventHandler(this.FileCreateOpt_Click);
            // 
            // FileCompressOpt
            // 
            this.FileCompressOpt.Name = "FileCompressOpt";
            this.FileCompressOpt.Size = new System.Drawing.Size(315, 40);
            this.FileCompressOpt.Text = "Compress";
            this.FileCompressOpt.Click += new System.EventHandler(this.FileCompressOpt_Click);
            // 
            // FileEncryptOpt
            // 
            this.FileEncryptOpt.Name = "FileEncryptOpt";
            this.FileEncryptOpt.Size = new System.Drawing.Size(315, 40);
            this.FileEncryptOpt.Text = "Encrypt";
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
            this.MainWindowConsoleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindowConsoleBox_KeyDown);
            // 
            // FileDecompressFileOpt
            // 
            this.FileDecompressFileOpt.Name = "FileDecompressFileOpt";
            this.FileDecompressFileOpt.Size = new System.Drawing.Size(315, 40);
            this.FileDecompressFileOpt.Text = "Decompress";
            this.FileDecompressFileOpt.Click += new System.EventHandler(this.FileDecompressFileOpt_Click);
            // 
            // FileCompressFileOpt
            // 
            this.FileCompressFileOpt.Name = "FileCompressFileOpt";
            this.FileCompressFileOpt.Size = new System.Drawing.Size(315, 40);
            this.FileCompressFileOpt.Text = "Compress";
            this.FileCompressFileOpt.Click += new System.EventHandler(this.FileCompressOpt_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 48F);
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
        private System.Windows.Forms.ToolStripMenuItem FileCompressOpt;
        private System.Windows.Forms.ToolStripMenuItem FileEncryptOpt;
        private System.Windows.Forms.ToolStripMenuItem FileSaveOpt;
        private System.Windows.Forms.ToolStripMenuItem FileCompressFileOpt;
        private System.Windows.Forms.ToolStripMenuItem FileDecompressFileOpt;
    }
}

