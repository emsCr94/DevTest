
namespace DevTest
{
    partial class FileWatcherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileWatcherForm));
            this.watchButton = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderButton = new System.Windows.Forms.Button();
            this.labelFolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // watchButton
            // 
            this.watchButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.watchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.watchButton.Location = new System.Drawing.Point(622, 238);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(122, 78);
            this.watchButton.TabIndex = 0;
            this.watchButton.Text = "Watch";
            this.watchButton.UseVisualStyleBackColor = false;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // Loading
            // 
            this.Loading.AccessibleName = "Loading";
            this.Loading.InitialImage = ((System.Drawing.Image)(resources.GetObject("Loading.InitialImage")));
            this.Loading.Location = new System.Drawing.Point(203, 123);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(300, 275);
            this.Loading.TabIndex = 2;
            this.Loading.TabStop = false;
            this.Loading.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.SelectedPath = "C:\\Users\\Spider-Ban\\Documents";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest_1);
            // 
            // folderButton
            // 
            this.folderButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.folderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.folderButton.Location = new System.Drawing.Point(622, 66);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(122, 35);
            this.folderButton.TabIndex = 3;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = false;
            this.folderButton.Click += new System.EventHandler(this.pathButton_Click);
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFolder.Location = new System.Drawing.Point(59, 70);
            this.labelFolder.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelFolder.MinimumSize = new System.Drawing.Size(500, 28);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(500, 28);
            this.labelFolder.TabIndex = 4;
            this.labelFolder.Text = "C:\\Users\\Spider-Ban\\Documents\\Cirqular";
            this.labelFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.watchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileWatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Consolidation Buiilder";
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.PictureBox Loading;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Label labelFolder;
    }
}

