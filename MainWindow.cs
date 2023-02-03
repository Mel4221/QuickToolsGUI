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
    public partial class MainWindow : Form
    {
        public bool ConsoleModeStatus { get; set; } 
        public MainWindow()
        { 
            InitializeComponent();
            this.TurnOffConsoleMode();
        }

        public void TurnOnConsoleMode()
        {
            ConsoleModeStatus = true;   
            this.MainWindowConsoleBox.Visible = true;
            this.MainWindowConsoleBox.ReadOnly = false;
            this.MainWindowConsoleBox.UseWaitCursor = true;
        }
        public void TurnOffConsoleMode()
        {
            this.ConsoleModeStatus= false;  
            this.MainWindowConsoleBox.ReadOnly = true;
            this.MainWindowConsoleBox.Visible = false;
            this.MainWindowConsoleBox.UseWaitCursor = false; 
        }

        private void MainWindowCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void MainWindowMaxBtn_Click(object sender, EventArgs e)
        {
            // MainWindow main = new MainWindow();
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; 
            }
            
           
        }

        private void MainWindowMiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
