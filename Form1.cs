﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var files = File.ReadAllLines(@"../../file.txt");
            int lineCount = files.Length;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = lineCount;
            progressBar1.Step = 1;

            for (int i = 0; i < lineCount; i++)
            {
                progressBar1.PerformStep();
                Thread.Sleep(5);
            }

            this.Close();
        }
    }
}
