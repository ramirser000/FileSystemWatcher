using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace MyFileSystemWatcher
{
    public partial class Form1 : Form
    {

        FileSystemWatcher watcher;
        Form dataQuery;
        private string[] extensionsToWatch;
        private string directoryToWatch;
        private bool validPath;
        private bool validSelectedExtensions;
        private ArrayList data;

        public Form1()
        {
            InitializeComponent();
            initializeFileWatcher();
            WatcherChangedRaisingEvents += WatcherChanged;
            dataQuery = new Form2();
            data = new ArrayList();
            DataManager.start();
            toolTipAddExt.SetToolTip(listBoxMonitorByExtension, "Hold CTRL to select multiple extensions.");


        }

        private void WatcherChanged(object source, WatcherChangedRaisingEventsArgs a)
        {
            if (a.Watching)
            {
                lblRunning.ForeColor = System.Drawing.Color.Green;
                lblRunning.Text = "Running";
            }
            else
            {
                lblRunning.ForeColor = System.Drawing.Color.Orange;
                lblRunning.Text = "Paused";
            }
        }



        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void initializeFileWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.IncludeSubdirectories = true;

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);


            watcher.EnableRaisingEvents = false;

            btnStart.Enabled = true;

        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            printToDisplay(source, e);
        }

        private void OnRenamed(object source, FileSystemEventArgs e)
        {
            printToDisplay(source, e);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        private void printToDisplay(object source, FileSystemEventArgs e)
        {

            string fileName = e.Name;
            string ext = fileName;
            string[] split = fileName.Split('\\');
            string[] extSplit = ext.Split('.');
            ext = extSplit[extSplit.Length - 1];
            fileName = split[split.Length - 1];

            string extensions = "";
            for (int i = 0; i < extensionsToWatch.Length; i++)
            {
                if (i == extensionsToWatch.Length - 1)
                {
                    extensions += extensionsToWatch[i].Substring(1);
                }
                else
                {
                    extensions += extensionsToWatch[i].Substring(1) + "|";
                }

            }

            if (Regex.IsMatch(fileName, @"^.*\.(" + extensions + ")$", RegexOptions.IgnoreCase))
            {
                setText(fileName + ", " + e.FullPath + ", " + e.ChangeType + ", " + DateTime.Now.ToString() + "\n");
                data.Add(new string[] { " ", ext, fileName, e.FullPath, e.ChangeType.ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm.ss.fff") });
            }




        }

        //Dispatcher to fix cross-thread operation error.
        //example from http://stackoverflow.com/questions/10775367/cross-thread-operation-not-valid-control-textbox1-accessed-from-a-thread-othe
        private void setText(string str)
        {
            if (richTextBoxOutput.InvokeRequired)
            {
                SetTextCallback callback = new SetTextCallback(setText);
                this.Invoke(callback, new object[] { str });
            }
            else
            {
                richTextBoxOutput.AppendText(str + "\n");
                richTextBoxOutput.SelectionStart = richTextBoxOutput.Text.Length;
                richTextBoxOutput.ScrollToCaret();
                btnWrite.Enabled = true;

            }
        }


        private void listBoxMonitorByExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Grabbing selected extensions to watch for.
            validSelectedExtensions = checkExtensions();

        }

        private void WriteToDataBase()
        {
            foreach (string[] ara in data)
            {
                DataManager.WriteToDataBase(ara);
            }
        }


        private void textBoxDirectoryToWatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //When user hits enter key we check if its a valid file path.
            if (e.KeyChar == (char)Keys.Enter)
            {
                validPath = checkDirectoryPath();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            validPath = checkDirectoryPath();
            validSelectedExtensions = checkExtensions();

            if (validPath && validSelectedExtensions)
            {
                if (watcher != null)
                {
                    btnStart.Enabled = false;
                    watcher.EnableRaisingEvents = true;
                    btnStop.Enabled = true;
                    WatcherChangedRaisingEventsArgs args = new WatcherChangedRaisingEventsArgs();
                    args.Watching = true;
                    OnWatcherChangingRaisingEvents(args);
                }
            }
        }

        private bool checkDirectoryPath()
        {
            try
            {
                string path = textBoxDirectoryToWatch.Text;
                if (Path.IsPathRooted(path))
                {
                    lblDirectoryToMonitorError.Text = "";
                    directoryToWatch = Path.GetFullPath(path);
                    watcher.Path = directoryToWatch;
                    return true;
                }

            }
            catch (Exception ex)
            {
                lblDirectoryToMonitorError.Text = "Invalid path.";
                return false;

            }
            lblDirectoryToMonitorError.Text = "Invalid path.";
            return false;
        }

        private bool checkExtensions()
        {
            int count = listBoxMonitorByExtension.SelectedItems.Count;
            if (count > 0)
            {
                extensionsToWatch = new string[count];
                listBoxMonitorByExtension.SelectedItems.CopyTo(extensionsToWatch, 0);
                lblExtensionError.Text = "";
                return true;
            }
            lblExtensionError.Text = "Must select an extension.";
            return false;

        }

        delegate void SetTextCallback(string text);

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
                WatcherChangedRaisingEventsArgs args = new WatcherChangedRaisingEventsArgs();
                args.Watching = false;
                OnWatcherChangingRaisingEvents(args);
                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        protected virtual void OnWatcherChangingRaisingEvents(WatcherChangedRaisingEventsArgs e)
        {
            WatcherChangedRaisingEvents?.Invoke(this, e);
        }

        private event EventHandler<WatcherChangedRaisingEventsArgs> WatcherChangedRaisingEvents;

        public class WatcherChangedRaisingEventsArgs : EventArgs
        {
            public bool Watching { get; set; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (data.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Save current results to database?", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    WriteToDataBase();

                }
            }

            DataManager.stop();
      
        }

        private void queryDatabasefileExtensionToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            richTextBoxOutput.AppendText("test");
            dataQuery.Show();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            dataQuery.Show();
        }

        private void queryDatabasefileExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataQuery.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about();
        }

        private void about()
        {
            string message = "Author: Sergio Ramirez \n Version: 1.0 \n" +
                                "Hold CTRL to select multiple extensions. \n" +
                                "You can add custom extensions by typing it in the text box and hitting the \"Add\" button.\n" +
                                "CTRL+Q - Open query database window. \n" +
                                "CTRL+C - Close application.\n" +
                                "CTRL+A - Help/About.\n";
            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataQuery.Close();
            Close();

        }



        private void txtExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                validateExtension();
            }
        }

        private void btnAddExt_Click(object sender, EventArgs e)
        {
            validateExtension();
        }

        private void validateExtension()
        {
            if ((Regex.IsMatch(txtExt.Text, @"^((\.{1})(\w+))", RegexOptions.IgnoreCase)))
            {
                string[] items = new string[listBoxMonitorByExtension.Items.Count + 1];
                listBoxMonitorByExtension.Items.CopyTo(items, 1);
                items[0] = txtExt.Text;
                listBoxMonitorByExtension.DataSource = null;
                listBoxMonitorByExtension.DataSource = items;
                txtExt.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid extension. (format= \".ext\")", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExt.Text = "";
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (data.Count > 0)
            {
                WriteToDataBase();
                data.Clear();
                btnWrite.Enabled = false;
            }
            else
            {
                MessageBox.Show("Database uptodate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.Q)
            {
                dataQuery.Show();

            }else if(ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.C)
            {
                Application.Exit();
            }else if(ModifierKeys.HasFlag(Keys.Control) && e.KeyCode == Keys.A)
            {
                about();
            }

           
        }
    }
}
