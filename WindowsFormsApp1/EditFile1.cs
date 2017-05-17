using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditFile1 : Form
    {
        public String fileName;
        public String fileContents;

        public EditFile1()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt||";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.fileName = openFile.FileName;
                labelFileName.Text = fileName;
                this.fileContents = File.ReadAllText(this.fileName); ;
                textBox1.Text = this.fileContents;
                buttonEditFile.Enabled = true;
            }
        }

        private void buttonEditFile_Click(object sender, EventArgs e)
        {
            new EditFile2(this).Show();
        }

        public void UpdateFile(String newContents)
        {
            File.WriteAllText(this.fileName, newContents);
            textBox1.Text = newContents;
        }
    }
}
