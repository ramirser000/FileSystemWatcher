namespace MyFileSystemWatcher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblMonitorByExtension = new System.Windows.Forms.Label();
            this.listBoxMonitorByExtension = new System.Windows.Forms.ListBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.textBoxDirectoryToWatch = new System.Windows.Forms.TextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.lblDirectoryToMonitorError = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblExtensionError = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabasefileExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.btnAddExt = new System.Windows.Forms.Button();
            this.toolTipAddExt = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonitorByExtension
            // 
            this.lblMonitorByExtension.AutoSize = true;
            this.lblMonitorByExtension.Location = new System.Drawing.Point(60, 59);
            this.lblMonitorByExtension.Name = "lblMonitorByExtension";
            this.lblMonitorByExtension.Size = new System.Drawing.Size(104, 13);
            this.lblMonitorByExtension.TabIndex = 0;
            this.lblMonitorByExtension.Text = "Monitor by extension";
            // 
            // listBoxMonitorByExtension
            // 
            this.listBoxMonitorByExtension.FormattingEnabled = true;
            this.listBoxMonitorByExtension.Items.AddRange(new object[] {
            ".tmp",
            ".log",
            ".txt",
            ".xml",
            ".dat",
            ".doc",
            ".exe"});
            this.listBoxMonitorByExtension.Location = new System.Drawing.Point(63, 94);
            this.listBoxMonitorByExtension.Name = "listBoxMonitorByExtension";
            this.listBoxMonitorByExtension.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMonitorByExtension.Size = new System.Drawing.Size(135, 43);
            this.listBoxMonitorByExtension.TabIndex = 1;
            this.listBoxMonitorByExtension.SelectedIndexChanged += new System.EventHandler(this.listBoxMonitorByExtension_SelectedIndexChanged);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(276, 59);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(98, 13);
            this.lblDirectory.TabIndex = 2;
            this.lblDirectory.Text = "Directory to monitor";
            // 
            // textBoxDirectoryToWatch
            // 
            this.textBoxDirectoryToWatch.Location = new System.Drawing.Point(279, 81);
            this.textBoxDirectoryToWatch.Name = "textBoxDirectoryToWatch";
            this.textBoxDirectoryToWatch.Size = new System.Drawing.Size(201, 20);
            this.textBoxDirectoryToWatch.TabIndex = 3;
            this.textBoxDirectoryToWatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDirectoryToWatch_KeyPress);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(15, 218);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(510, 188);
            this.richTextBoxOutput.TabIndex = 4;
            this.richTextBoxOutput.Text = "";
            // 
            // lblDirectoryToMonitorError
            // 
            this.lblDirectoryToMonitorError.AutoSize = true;
            this.lblDirectoryToMonitorError.ForeColor = System.Drawing.Color.Red;
            this.lblDirectoryToMonitorError.Location = new System.Drawing.Point(396, 59);
            this.lblDirectoryToMonitorError.Name = "lblDirectoryToMonitorError";
            this.lblDirectoryToMonitorError.Size = new System.Drawing.Size(0, 13);
            this.lblDirectoryToMonitorError.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(279, 114);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(377, 114);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(12, 202);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(140, 13);
            this.lblEvents.TabIndex = 8;
            this.lblEvents.Text = "File System Watcher Events";
            // 
            // lblExtensionError
            // 
            this.lblExtensionError.AutoSize = true;
            this.lblExtensionError.ForeColor = System.Drawing.Color.Red;
            this.lblExtensionError.Location = new System.Drawing.Point(60, 140);
            this.lblExtensionError.Name = "lblExtensionError";
            this.lblExtensionError.Size = new System.Drawing.Size(0, 13);
            this.lblExtensionError.TabIndex = 9;
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.ForeColor = System.Drawing.Color.Green;
            this.lblRunning.Location = new System.Drawing.Point(197, 202);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRunning.Size = new System.Drawing.Size(0, 13);
            this.lblRunning.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryDatabasefileExtensionToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // queryDatabasefileExtensionToolStripMenuItem
            // 
            this.queryDatabasefileExtensionToolStripMenuItem.Name = "queryDatabasefileExtensionToolStripMenuItem";
            this.queryDatabasefileExtensionToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.queryDatabasefileExtensionToolStripMenuItem.Text = "Query Database(file extension)  CTRL+Q";
            this.queryDatabasefileExtensionToolStripMenuItem.Click += new System.EventHandler(this.queryDatabasefileExtensionToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.closeToolStripMenuItem.Text = "Close                                              CTRL+C";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About  CTRL+A";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(418, 189);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(105, 23);
            this.btnWrite.TabIndex = 12;
            this.btnWrite.Text = "Write to database";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(63, 75);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(83, 20);
            this.txtExt.TabIndex = 13;
            this.txtExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExt_KeyPress);
            // 
            // btnAddExt
            // 
            this.btnAddExt.Location = new System.Drawing.Point(143, 75);
            this.btnAddExt.Name = "btnAddExt";
            this.btnAddExt.Size = new System.Drawing.Size(55, 20);
            this.btnAddExt.TabIndex = 14;
            this.btnAddExt.Text = "Add";
            this.btnAddExt.UseVisualStyleBackColor = true;
            this.btnAddExt.Click += new System.EventHandler(this.btnAddExt_Click);
            // 
            // toolTipAddExt
            // 
            this.toolTipAddExt.AutomaticDelay = 0;
            this.toolTipAddExt.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 418);
            this.Controls.Add(this.btnAddExt);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.lblExtensionError);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDirectoryToMonitorError);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.textBoxDirectoryToWatch);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.listBoxMonitorByExtension);
            this.Controls.Add(this.lblMonitorByExtension);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File System Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonitorByExtension;
        private System.Windows.Forms.ListBox listBoxMonitorByExtension;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox textBoxDirectoryToWatch;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label lblDirectoryToMonitorError;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblExtensionError;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabasefileExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Button btnAddExt;
        private System.Windows.Forms.ToolTip toolTipAddExt;
    }
}

