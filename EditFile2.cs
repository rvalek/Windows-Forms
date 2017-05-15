using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditFile2 : Form
    {
        EditFile1 parent;

        public EditFile2(EditFile1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void EditFile2_Load(object sender, EventArgs e)
        {
            labelFileName.Text = parent.fileName;
            textBox1.Text = parent.fileContents;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            parent.UpdateFile(textBox1.Text);
        }

    }
}
