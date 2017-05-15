using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FileSearch2 : Form
    {
        String selectedPath;

        public FileSearch2()
        {
            InitializeComponent();
        }

        private void buttonChooseFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog chooseFolder = new FolderBrowserDialog();
            if (chooseFolder.ShowDialog() == DialogResult.OK)
            {
                this.selectedPath = chooseFolder.SelectedPath;
                labelPath.Text = selectedPath;
                buttonSearch.Enabled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Join("\r\n", Directory.GetFiles(selectedPath,
                textBox1.Text != "" ? textBox1.Text : "*.*",
                checkboxSearchSubs.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
        }
    }
}
