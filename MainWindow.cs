using QuickTools.QCore;
using QuickTools.QIO;
using QuickTools.QNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
             this.WindowState = FormWindowState.Minimized;
           // this.Hide();
        }
        
        public string CurrentFile { get; set; } 
        void ProperSettupForBackGroundWorker()
        {
           

                   //Check if the worker is active 
           if (!this.BackGroundWorker_A.IsBusy)
           {
                   // set the function that the BackGround will execute
               this.ProcessToBeExecuted =(BackgroundWorker worker) => {
                   this.MainMenuProgressBarsOpt.Value = 0;
                   this.MainMenuProgressBarsOpt.Maximum = 100;
                   int current, goal, number;
                   string status;
                   goal = 100;
                   number = 0;
                   for (current = 0; current<goal; current++)
                   {
                       //set the text progress to 
                         status = Get.Status(current, goal-1);

                       this.TextStatus = status;
                       // just in case 
                       try { number = int.Parse(status.Replace("%", "")); } catch { number = 0; };
                       this.Status =  number;
                       Thread.Sleep(100);
                       //reports the progress 
                       worker.ReportProgress(0);

                   }
               };
               //start the background process
               this.BackGroundWorker_A.RunWorkerAsync();
           }
 

        }
        private void FileOpen(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(); 
            string fileName = openFileDialog.FileName;
            if (!File.Exists(fileName))
            {
                MessageBox.Show("The File Could not be found or not exist");
                return; 
            }
            this.CurrentFile = fileName;
            this.TurnOnConsoleMode();
            try
            {
                this.MainWindowConsoleBox.Text = Reader.Read(fileName); 
            }
            catch
            {
                MessageBox.Show("It Looks like either the file is too big or not supported");
                
            }
            //MessageBox.Show(fileName); 
        }

        private void FileCreateOpt_Click(object sender, EventArgs e)
        {
            this.TurnOnConsoleMode();
            this.MainWindowConsoleBox.Text = "Type Something";
        }

        private void MainWindowConsoleBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.MainWindowConsoleBox.Text == "Type Something")
            {
                this.MainWindowConsoleBox.Text = ""; 
            } 
        }

        private void FileSaveOpt_Click(object sender, EventArgs e)
        {
            if (this.MainWindowConsoleBox.Text == "" || this.MainWindowConsoleBox.Text == "Type Something")
            {
                MessageBox.Show("Please type something to save");
                return; 
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;  

            if (fileName.IndexOf('.') == -1)
            {
                fileName+=".txt"; 
            }
            try
            {
                Writer.Write(fileName, this.MainWindowConsoleBox.Text);
            }
            catch
            {
                MessageBox.Show("Something went wrong while saving the file"); 
            }

        }

        private void FileCompressOpt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();   
            openFileDialog.ShowDialog();
            if (!File.Exists(openFileDialog.FileName))
            {
                MessageBox.Show("Please Select a file");
                return;
            }
            QZip qZip = new QZip();
            try
            {
                qZip.Compress(openFileDialog.FileName);
                DialogResult dialogResult = MessageBox.Show("Would you like to delete the old file ?","Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) { File.Delete(openFileDialog.FileName); }
            }
            catch
            {
                MessageBox.Show("Something went wrong while compressing the file and it could not be compressed"); 
            }

        }

        private void FileDecompressFileOpt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;


            QZip qZip = new QZip();
            if (!File.Exists(fileName))
            {
               // MessageBox.Show("Please Select a file");
                return;
            }
            //try
            //{
          
                DialogResult dialogResult = MessageBox.Show($"Would you like to delete the zip file : {fileName}", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) { 
                 // File.Move(fileName,Get.Path);
                    File.Delete(Get.FileNameFromPath(fileName));
                }
            //}
            //catch
            //{
            //    MessageBox.Show($"Something went wrong while compressing the file and it could not be compressed");
            //}
        }

        private void FileEncryptOpt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (!File.Exists(openFileDialog.FileName))
            {
                //MessageBox.Show("Please Select a file");
                return;
            }
            try
            {
                byte[] bytes = Binary.Reader(openFileDialog.FileName);
                EntryBox entry = new EntryBox();
                entry.Show();
                
                //MessageBox.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("The File Could not be readed due to: "+ex.Message);
            }
        }

        private void FileDecryptOpt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (!File.Exists(openFileDialog.FileName))
            {
               // MessageBox.Show("Please Select a file");
                return;
            }
        }

        private void MainWindowTopMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainWindowConsoleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageBoxInput_Click(object sender, EventArgs e)
        {
            EntryBox entry = new EntryBox();
            entry.Show();
        }

        private void GeneralSettingsOpt_Click(object sender, EventArgs e)
        {
            SettingsManagerWindow window = new SettingsManagerWindow();
            window.Show(); 
        }

        public Action<BackgroundWorker> ProcessToBeExecuted;

        public int Status;
        public string TextStatus; 

        private void BackGroundWorker_A_DoWork(object sender, DoWorkEventArgs e)
        {
            if(this.ProcessToBeExecuted != null)
            {
                 
                this.ProcessToBeExecuted(this.BackGroundWorker_A);

            }
        }

        private void BackGroundWorker_A_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            if(this.MainMenuProgressBarsOpt.Value != 100)
            {
                this.MainMenuPorcentLabelOpt.Text = this.TextStatus;
                this.MainMenuProgressBarsOpt.Value++;
            }
            
             
        }

        private void BackGroundWorker_A_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DialogResult reult =  MessageBox.Show("Task Completed!!!");
            if(DialogResult.OK == reult)
            {
                this.MainMenuProgressBarsOpt.Value = 0;
                this.MainMenuPorcentLabelOpt.Text = "0%"; 
            }

        }

        private void MainWindowConsoleBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MainWindowConsoleBox.ClientRectangle.Contains(e.Location))
            {
                MainWindowConsoleBox.Capture = false;
            }
            else if (!MainWindowConsoleBox.Capture)
            {
                MainWindowConsoleBox.Capture = true;
            }
        }
    }
}
