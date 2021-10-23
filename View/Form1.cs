using DevTest.View;
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
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DevTest
{
    public partial class FileWatcherForm : Form
    {
        readonly FileWatcherView fileWatcherView = new FileWatcherView();
        public FileWatcherForm()
        {
            InitializeComponent();
            Loading.Load("Stopped.jpg");
            labelFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void WatchFiles(bool state, string folder) 
        {
            fileWatcherView.WatchFiles(state, folderBrowserDialog.SelectedPath);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {
           
        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelFolder.Text = folderBrowserDialog.SelectedPath;
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void watchButton_Click(object sender, EventArgs e)
        {
            //watchButton.ForeColor = new Color("red");
            if (fileWatcherView.getState() == false)
            {
                Loading.Load("Loading.gif");
                watchButton.Text = "Stop";
                WatchFiles(true, folderBrowserDialog.SelectedPath);
            }
            else {
                Loading.Load("Stopped.jpg");           
                watchButton.Text = "Watch";
                WatchFiles(false, folderBrowserDialog.SelectedPath);
            }
            
            
        }
    }
}
