namespace QuickToolsGUI
{
    partial class SettingsManagerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsManagerWindow));
            this.SettingsViewerGrid = new System.Windows.Forms.DataGridView();
            this.SettingWindowSaveBtn = new System.Windows.Forms.Button();
            this.SettingWindowCloseBtn = new System.Windows.Forms.Button();
            this.SettingWindowLoadDefaultBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsViewerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsViewerGrid
            // 
            this.SettingsViewerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingsViewerGrid.Location = new System.Drawing.Point(12, 12);
            this.SettingsViewerGrid.Name = "SettingsViewerGrid";
            this.SettingsViewerGrid.Size = new System.Drawing.Size(544, 591);
            this.SettingsViewerGrid.TabIndex = 0;
            // 
            // SettingWindowSaveBtn
            // 
            this.SettingWindowSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingWindowSaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingWindowSaveBtn.Location = new System.Drawing.Point(12, 609);
            this.SettingWindowSaveBtn.Name = "SettingWindowSaveBtn";
            this.SettingWindowSaveBtn.Size = new System.Drawing.Size(92, 39);
            this.SettingWindowSaveBtn.TabIndex = 1;
            this.SettingWindowSaveBtn.Text = "Save";
            this.SettingWindowSaveBtn.UseVisualStyleBackColor = true;
            this.SettingWindowSaveBtn.Click += new System.EventHandler(this.SettingWindowSaveBtn_Click);
            // 
            // SettingWindowCloseBtn
            // 
            this.SettingWindowCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingWindowCloseBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingWindowCloseBtn.Location = new System.Drawing.Point(464, 609);
            this.SettingWindowCloseBtn.Name = "SettingWindowCloseBtn";
            this.SettingWindowCloseBtn.Size = new System.Drawing.Size(92, 39);
            this.SettingWindowCloseBtn.TabIndex = 2;
            this.SettingWindowCloseBtn.Text = "Close";
            this.SettingWindowCloseBtn.UseVisualStyleBackColor = true;
            this.SettingWindowCloseBtn.Click += new System.EventHandler(this.SettingWindowCloseBtn_Click);
            // 
            // SettingWindowLoadDefaultBtn
            // 
            this.SettingWindowLoadDefaultBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingWindowLoadDefaultBtn.ForeColor = System.Drawing.Color.Black;
            this.SettingWindowLoadDefaultBtn.Location = new System.Drawing.Point(203, 609);
            this.SettingWindowLoadDefaultBtn.Name = "SettingWindowLoadDefaultBtn";
            this.SettingWindowLoadDefaultBtn.Size = new System.Drawing.Size(159, 39);
            this.SettingWindowLoadDefaultBtn.TabIndex = 3;
            this.SettingWindowLoadDefaultBtn.Text = "Load Default";
            this.SettingWindowLoadDefaultBtn.UseVisualStyleBackColor = true;
            this.SettingWindowLoadDefaultBtn.Click += new System.EventHandler(this.SettingWindowLoadDefaultBtn_Click);
            // 
            // SettingsManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(571, 660);
            this.Controls.Add(this.SettingWindowLoadDefaultBtn);
            this.Controls.Add(this.SettingWindowCloseBtn);
            this.Controls.Add(this.SettingWindowSaveBtn);
            this.Controls.Add(this.SettingsViewerGrid);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsManagerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsViewerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SettingsViewerGrid;
        private System.Windows.Forms.Button SettingWindowSaveBtn;
        private System.Windows.Forms.Button SettingWindowCloseBtn;
        private System.Windows.Forms.Button SettingWindowLoadDefaultBtn;
    }
}