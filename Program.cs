using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            // Lesson 1 Task 1
            // showResume();

            // Lesson 1 Task 2
            //DialogResult result;
            //do
            //{
            //    result = guessNumber();
            //} while (result == DialogResult.Retry);

            // Lesson 2 Task 1
            //Application.Run(new ProgressBar());

            // Lesson 2 Task 2
            //Application.Run(new Survey());
        }

        static void showResume()
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

        static DialogResult guessNumber()
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
