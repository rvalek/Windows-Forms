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
    public partial class AllExcersises : Form
    {
        public AllExcersises()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lesson 1 Task 1 (Short resume that shows average words per window)
            Program.ShowResume();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lesson 1 Task 2 (Guessing game that shows number of tries)
            Program.RunGuessNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Lesson 2 Task 1 (Progress bar for reading from file)
            new ProgressBar().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lesson 2 Task 2 (Survey with input summary)
            new Survey().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Lesson 3 Task 1 (Search Files in selected folder by custom mask)
            new FileSearch1().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Lesson 3 Task 3 (Open/Edit/Save File)
            new EditFile1().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Lesson 4 Task 1 (Text Editor) + Lesson 5 Task 3 (Drag and Drop)
            new TextEditor().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Lesson 4 Task 2 (Directory Explorer) + Lesson 5 Task 1 (Also Directory Explorer with Tree View) 
            // + Lesson Task 2 (List View with Options: Icons/Tiles/Image Preview)
            new Explorer().Show();
        }
    }
}
