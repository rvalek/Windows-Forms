using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FileSearch1 : Form
    {
        public FileSearch1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FileSearch2().Show();
        }
    }
}
