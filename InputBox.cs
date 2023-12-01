using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickToolsGUI
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }
        public MainWindow Window;

        public bool RequireVerification; 
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Window.Show(); 
        }
        private List<string> TextInput = new List<string>(); 
        private void OkBtn_Click(object sender, EventArgs e)
        {
            TextInput.Add(this.Input.Text);
            if (this.RequireVerification && TextInput.Count < 2) {
                this.InputLabel.Text = "One More Time";
                this.Input.Text = "";
                return;
            }
            if (this.RequireVerification)
            {
                if (TextInput[0] == TextInput[1])
                {
                    new Thread(() => {
                        this.Window.CurrentAction(this.TextInput[0]);
                    }).Start();
                    this.Window.Show();
                    this.Close();
                    this.TextInput = new List<string>();
                    return;
                }
            }
            else
            {
                new Thread(() => {
                    this.Window.CurrentAction(this.TextInput[0]);
                }).Start();
            }
        }
    }
}
