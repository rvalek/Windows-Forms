using System;
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
            sexField.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] info = new String[5];

            info[0] = "Name: " + nameField.Text;
            info[1] = "Age: " + ageField.Value;
            info[2] = "Sex: " + sexField.Text;
            info[3] = "Married: " + marriedField.Checked;// ? "Married" : "Not married";
            info[4] = "Student: " + studentField.Checked;

            resultTextBox.Text = String.Join("\n", info);
            resultTextBox.Show();
        }
    }
}
