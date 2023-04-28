using QuickTools.QData;
using QuickTools.QNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickToolsGUI
{
  
    public partial class EntryBox : Form
    {
        public EntryBox()
        {
            InitializeComponent();
            this.IsAccessible = true;   
        }
        /// <summary>
        /// define the status of this class
        /// </summary>
        public bool IsAlive;
        private void EntryBoxOkBtn_Click(object sender, EventArgs e)
        {
            if(this.EntryTexBox.Text != "")
            {
                GlobalSettings.SaveSetting("TextEntry", this.EntryTexBox.Text);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Please type something or hit Cancell");
            }
            
        }

        private void EntryBoxCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
