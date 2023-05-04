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
    public partial class SettingsManagerWindow : Form
    {
        public SettingsManagerWindow()
        {
            InitializeComponent();
        }

        private void SettingWindowSaveBtn_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void SettingWindowCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingWindowLoadDefaultBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you yes you will not be able to restore your settings","Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
