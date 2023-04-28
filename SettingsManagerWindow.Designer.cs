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
            ((System.ComponentModel.ISupportInitialize)(this.SettingsViewerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsViewerGrid
            // 
            this.SettingsViewerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SettingsViewerGrid.Location = new System.Drawing.Point(104, 66);
            this.SettingsViewerGrid.Name = "SettingsViewerGrid";
            this.SettingsViewerGrid.Size = new System.Drawing.Size(741, 395);
            this.SettingsViewerGrid.TabIndex = 0;
            // 
            // SettingsManagerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1393, 660);
            this.Controls.Add(this.SettingsViewerGrid);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsManagerWindow";
            this.Text = "SettingsManagerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsViewerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SettingsViewerGrid;
    }
}