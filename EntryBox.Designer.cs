namespace QuickToolsGUI
{
    partial class EntryBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryBox));
            this.EntryBoxOkBtn = new System.Windows.Forms.Button();
            this.EntryBoxCancelBtn = new System.Windows.Forms.Button();
            this.EntryTexBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // EntryBoxOkBtn
            // 
            this.EntryBoxOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryBoxOkBtn.Location = new System.Drawing.Point(367, 210);
            this.EntryBoxOkBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EntryBoxOkBtn.Name = "EntryBoxOkBtn";
            this.EntryBoxOkBtn.Size = new System.Drawing.Size(268, 102);
            this.EntryBoxOkBtn.TabIndex = 1;
            this.EntryBoxOkBtn.Text = "OK";
            this.EntryBoxOkBtn.UseVisualStyleBackColor = true;
            this.EntryBoxOkBtn.Click += new System.EventHandler(this.EntryBoxOkBtn_Click);
            // 
            // EntryBoxCancelBtn
            // 
            this.EntryBoxCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryBoxCancelBtn.Location = new System.Drawing.Point(653, 210);
            this.EntryBoxCancelBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EntryBoxCancelBtn.Name = "EntryBoxCancelBtn";
            this.EntryBoxCancelBtn.Size = new System.Drawing.Size(268, 102);
            this.EntryBoxCancelBtn.TabIndex = 2;
            this.EntryBoxCancelBtn.Text = "Cancel";
            this.EntryBoxCancelBtn.UseVisualStyleBackColor = true;
            this.EntryBoxCancelBtn.Click += new System.EventHandler(this.EntryBoxCancelBtn_Click);
            // 
            // EntryTexBox
            // 
            this.EntryTexBox.Location = new System.Drawing.Point(12, 12);
            this.EntryTexBox.Name = "EntryTexBox";
            this.EntryTexBox.Size = new System.Drawing.Size(1316, 174);
            this.EntryTexBox.TabIndex = 3;
            this.EntryTexBox.Text = "";
            // 
            // EntryBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1340, 338);
            this.Controls.Add(this.EntryTexBox);
            this.Controls.Add(this.EntryBoxCancelBtn);
            this.Controls.Add(this.EntryBoxOkBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EntryBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EntryBoxOkBtn;
        private System.Windows.Forms.Button EntryBoxCancelBtn;
        private System.Windows.Forms.RichTextBox EntryTexBox;
    }
}