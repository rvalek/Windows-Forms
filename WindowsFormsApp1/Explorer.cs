using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Explorer : Form
    {

        ArrayList Addresses = new ArrayList();
        int currentIndex = -1;
        string currentAddress = "";

        public Explorer()
        {
            InitializeComponent();

            string[] localDrives = Environment.GetLogicalDrives();
            int n = 0;
            foreach (string s in localDrives)
            {
                TreeNode tn = new TreeNode();
                tn.Name = s;
                tn.Text = "Local Drive " + s;
                treeView1.Nodes.Add(tn.Name, tn.Text, 2);
                FileInfo f = new FileInfo(@s);
                string t = "";
                string[] directories = Directory.GetDirectories(@s);
                foreach (string dir in directories)
                {
                    t = dir.Substring(dir.LastIndexOf('\\') + 1);
                    ((TreeNode)treeView1.Nodes[n]).Nodes.Add(dir, t, 0);
                }
                n++;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (Addresses.Count != 0)
            {
                string lastAddress = (string)Addresses[Addresses.Count - 1];
                Addresses.Clear();
                Addresses.Add(lastAddress);
                currentIndex = 0;
            }

            Addresses.Add(e.Node.Name);
            StepForward(@e.Node.Name);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            int i = 0;

            foreach (TreeNode tn in e.Node.Nodes)
            {
                try
                {
                    foreach (string subDir in Directory.GetDirectories(@tn.Name))
                    {
                        TreeNode child = new TreeNode();
                        child.Name = subDir;
                        child.Text = subDir.Substring(subDir.LastIndexOf('\\') + 1);
                        e.Node.Nodes[i].Nodes.Add(child);
                    }
                }
                catch (UnauthorizedAccessException) { }
                i++;
            }
        }

        private void UpdateNavButtons()
        {
            toolStripButton1.Enabled = currentIndex - 1 != -1;
            toolStripButton2.Enabled = currentIndex + 1 != Addresses.Count;
            toolStripButton3.Enabled = currentAddress.Length > 3;
        }

        private void StepForward(string place)
        {
            currentIndex++;
            UpdateInterface(place);
        }

        private void StepBackward(string place)
        {
            currentIndex--;
            UpdateInterface(place);
        }

        private void UpdateInterface(string place)
        {
            // A small shitty fix
            place = place.Contains("\\") ? place : place + "\\";

            currentAddress = place;
            UpdateNavButtons();
            toolStripTextBox1.Text = place;

            try
            {
                string[] dirs = Directory.GetDirectories(place);
                string[] files = Directory.GetFiles(place);

                listView1.Items.Clear();

                FillListView(dirs, true);
                FillListView(files, false);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Insufficent premissions to open this folder.", "Error");
            }
        }

        private void FillListView(string[] contents, bool dirs)
        {
            FileInfo fileInfo;
            string name, s, type;
            ListViewItem lw;

            type = dirs ? "Folder" : "File";

            foreach (string item in contents)
            {
                fileInfo = new FileInfo(item);
                name = item.Substring(item.LastIndexOf('\\') + 1);
                s = dirs ? "" : s = fileInfo.Length.ToString() + " bytes";
                string[] data = (listView1.View != View.Tile) ?
                    new string[] { name, s, type, fileInfo.LastWriteTime.ToString() } : new string[] { name };
                lw = new ListViewItem(data, 0);
                lw.Name = item;
                listView1.Items.Add(lw);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!listView1.SelectedItems[0].Text.Contains('.'))
            {
                Addresses.Add(listView1.SelectedItems[0].Name);
                StepForward(listView1.SelectedItems[0].Name);
            }
            else
            {
                System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
                MyProc.StartInfo.FileName = @listView1.SelectedItems[0].Name;
                try
                {
                    MyProc.Start();
                }
                catch (Win32Exception) { }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currentIndex--;
            UpdateInterface((string)Addresses[currentIndex]);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            StepForward((string)Addresses[currentIndex+1]);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StepBackward(currentAddress.Substring(0, currentAddress.LastIndexOf('\\')));
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && @toolStripTextBox1.Text != currentAddress)
            {
                try
                {
                    StepForward(@toolStripTextBox1.Text);
                    Addresses.Add(@toolStripTextBox1.Text);
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show("No such directory.", "Error");
                }
            }
        }
    }
}
