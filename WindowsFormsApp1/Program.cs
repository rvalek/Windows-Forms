using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new AllExcersises());

            // Lesson 1 Task 1 (Short resume that shows average words per window)
            //ShowResume();

            // Lesson 1 Task 2 (Guessing game that shows number of tries)
            //RunGuessNumber();

            // Lesson 2 Task 1 (Progress bar for reading from file)
            //Application.Run(new ProgressBar());

            // Lesson 2 Task 2 (Survey with input summary)
            //Application.Run(new Survey());

            // Lesson 3 Task 1 (Search Files in selected folder by custom mask)
            //Application.Run(new FileSearch1());

            // Lesson 3 Task 3 (Open/Edit/Save File)
            //Application.Run(new EditFile1());

            // Lesson 4 Task 1 (Text Editor) + Lesson 5 Task 3 (Drag and Drop)
            //Application.Run(new TextEditor());

            //Lesson 4 Task 1 (Directory Explorer) + Lesson 5 Task 1 (Also Directory Explorer with Tree View) 
            // + Lesson Task 2 (List View with Options: Icons/Tiles/Image Preview)
            //Application.Run(new Explorer());
        }

        public static void ShowResume()
        {
            String[] resume = {"Hi, my name's Robert.",
                "Currently I'm working on my Windows Forms assignment.",
                "And this is the last page, check out the caption." };

            int resumePageCount = resume.Length;
            int resumeWordCount = 0;

            for (int i = 0; i < resumePageCount; i++)
            {
                String message = resume[i];
                resumeWordCount += message.Split(' ').Length;
                MessageBox.Show(message,
                    i != resumePageCount - 1 ? "MessageBox " + (i + 1)
                    : "Average words per Box: " + resumeWordCount / resumePageCount);
            }
        }

        public static void RunGuessNumber()
        {
            DialogResult result;
            do
            {
                result = GuessNumber();
            } while (result == DialogResult.Retry);
        }

        static DialogResult GuessNumber()
        {
            String caption = "Guess My Number";

            MessageBox.Show("Think of a number between 1 and 2000.", caption,
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Random rnd = new Random();
            int tryCount = 0;
            DialogResult isCorrect;
            do
            {
                isCorrect = MessageBox.Show("Is " + rnd.Next(1, 2000) + " your number?", caption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ++tryCount;
            } while (isCorrect != DialogResult.Yes);

            DialogResult result = MessageBox.Show("Cool! I guessed in " + tryCount + " tries.", caption,
                MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
