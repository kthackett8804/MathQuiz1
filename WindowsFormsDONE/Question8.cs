using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsDONE
{
    public partial class Question8 : Form
    {
        int score = 0;
        public Question8()
        {
            InitializeComponent();
            ChangeQuestion();
        }
        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q8questions.txt");

        string correctAnswer;
        #endregion

        #region answer methods
        private string GetAnswers(string answer)
        {
            //this method finds the ans with '#' and removes it
            string Answer = "";

            for (int pos = 0; pos < answer.Length; pos++)
            {
                if (answer[0] == '#' && pos == 0)
                {
                    //removes first positon which is the #
                    answer.Remove(0);

                }
                else
                {
                    Answer += answer[pos];
                }
            }
            return Answer;
        }

        private string GetCorrectAns(string answer)
        {
            //finds the answer and sets the variable correct answer
            string ans = "";

            for (int pos = 0; pos < answer.Length; pos++)
            {
                if (answer[0] == '#' && pos == 0)
                {
                    answer.Remove(0);
                }
                else
                {
                    ans += answer[pos];
                }
            }
            correctAnswer = ans;
            return ans;
        }
        #endregion

        private void ChangeQuestion()
        {
            //randomly selects a number between 1 and the length of the quiz array
            int position = rnd.Next(0, 10);

            //splits the array into questions and answers
            string[] questionArray = quizDataArray[position].Split(',');

            string question = questionArray[0];
            string answer1 = GetAnswers(questionArray[1]);


            //decide which answer starts with a '#'
            if (questionArray[1].StartsWith("#"))
            {
                //then returns answer without the #
                GetCorrectAns(questionArray[1]);
            }


            //assigns questions and answers to the buttons and labels
            lblQuestion8.Text = question;


        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide();
        }

        private void submitAns8_Click(object sender, EventArgs e)
        {
            if (txtboxQ8.Text == correctAnswer)
            {
                MessageBox.Show("correct!");
                score = score + 1;
                PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
                ScoreMarks8();
                submitAns8.Enabled = false;
                txtboxQ8.Enabled = false;
                
         
            }
            else
            {
                MessageBox.Show("incorrect!");
                ScoreMarks8();
                txtboxQ8.Enabled = false;
                submitAns8.Enabled = false;

            }
            btnNext.Visible = true;
        }
        private void ScoreMarks8()
        {
            MessageBox.Show("your score for this question: " + score);
        }


        private void txtboxQ8_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void Question8_Load(object sender, EventArgs e)
        {
            lblScore8.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Question9 newform = new Question9();
            this.Hide();
            newform.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            People.SaveScoreToFile();

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHints.Visible = true;
            lblHints.Text = $"Possible answers\n{Convert.ToInt32(correctAnswer) + 1}\n{correctAnswer}\n{Convert.ToInt32(correctAnswer) - 3}";
        }

        private void lblHints_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
