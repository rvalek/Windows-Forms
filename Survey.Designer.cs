namespace WindowsFormsApp1
{
    partial class Survey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.studentField = new System.Windows.Forms.CheckBox();
            this.sexField = new System.Windows.Forms.ComboBox();
            this.ageField = new System.Windows.Forms.NumericUpDown();
            this.marriedField = new System.Windows.Forms.RadioButton();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notMarriedField = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ageField)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentField
            // 
            this.studentField.AutoSize = true;
            this.studentField.Location = new System.Drawing.Point(35, 242);
            this.studentField.Name = "studentField";
            this.studentField.Size = new System.Drawing.Size(93, 17);
            this.studentField.TabIndex = 2;
            this.studentField.Text = "I am a student";
            this.studentField.UseVisualStyleBackColor = true;
            // 
            // sexField
            // 
            this.sexField.FormattingEnabled = true;
            this.sexField.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexField.Location = new System.Drawing.Point(35, 140);
            this.sexField.Name = "sexField";
            this.sexField.Size = new System.Drawing.Size(121, 21);
            this.sexField.TabIndex = 3;
            // 
            // ageField
            // 
            this.ageField.Location = new System.Drawing.Point(35, 96);
            this.ageField.Name = "ageField";
            this.ageField.Size = new System.Drawing.Size(120, 20);
            this.ageField.TabIndex = 4;
            // 
            // marriedField
            // 
            this.marriedField.AutoSize = true;
            this.marriedField.Location = new System.Drawing.Point(35, 186);
            this.marriedField.Name = "marriedField";
            this.marriedField.Size = new System.Drawing.Size(60, 17);
            this.marriedField.TabIndex = 5;
            this.marriedField.Text = "Married";
            this.marriedField.UseVisualStyleBackColor = true;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(35, 53);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Age:";
            // 
            // notMarriedField
            // 
            this.notMarriedField.AutoSize = true;
            this.notMarriedField.Checked = true;
            this.notMarriedField.Location = new System.Drawing.Point(35, 209);
            this.notMarriedField.Name = "notMarriedField";
            this.notMarriedField.Size = new System.Drawing.Size(79, 17);
            this.notMarriedField.TabIndex = 9;
            this.notMarriedField.TabStop = true;
            this.notMarriedField.Text = "Not married";
            this.notMarriedField.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Marital status:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(14, 12);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(258, 259);
            this.resultTextBox.TabIndex = 12;
            this.resultTextBox.Text = "";
            this.resultTextBox.Visible = false;
            // 
            // Survey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notMarriedField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.marriedField);
            this.Controls.Add(this.ageField);
            this.Controls.Add(this.sexField);
            this.Controls.Add(this.studentField);
            this.Controls.Add(this.button1);
            this.Name = "Survey";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox studentField;
        private System.Windows.Forms.ComboBox sexField;
        private System.Windows.Forms.NumericUpDown ageField;
        private System.Windows.Forms.RadioButton marriedField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton notMarriedField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox resultTextBox;
    }
}