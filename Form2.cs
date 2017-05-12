using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Survey : Form
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.sexField.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] info = new String[5];

            info[0] = "Name: " + this.nameField.Text;
            info[1] = "Age: " + this.ageField.Value;
            info[2] = "Sex: " + this.sexField.Text;
            info[3] = "Married: " + this.marriedField.Checked;// ? "Married" : "Not married";
            info[4] = "Student: " + this.studentField.Checked;

            this.resultTextBox.Text = String.Join("\n", info);
            this.resultTextBox.Show();
        }
    }
}
