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
    public partial class Question6 : Form

    {
        int score = 0;
        public Question6()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q6questions.txt");

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
            string answer2 = GetAnswers(questionArray[2]);
            string answer3 = GetAnswers(questionArray[3]);

            //decide which answer starts with a '#'
            if (questionArray[1].StartsWith("#"))
            {
                //then returns answer without the #
                GetCorrectAns(questionArray[1]);
            }
            if (questionArray[2].StartsWith("#"))
            {
                GetCorrectAns(questionArray[2]);
            }
            if (questionArray[3].StartsWith("#"))
            {
                GetCorrectAns(questionArray[3]);
            }

            //assigns questions and answers to the buttons and labels
            lblQuestion.Text = question;
            btnIncorrect1.Text = answer1;
            btnCorrect.Text = answer2;
            btnIncorrect2.Text = answer3;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide();
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Correct");
            score = score + 1;
            PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
            disableButton();
            scoremarks6();
            btnNextQ6.Visible = true;
        }

        private void disableButton()
        {
            btnCorrect.Enabled = false;
            btnIncorrect1.Enabled = false;
            btnIncorrect2.Enabled = false;
        }

        private void scoremarks6()
        {
            MessageBox.Show("your score for this question: " + score);
        }

        private void Question6_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void btnIncorrect1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That is Incorrect");
            scoremarks6();
            disableButton();
            btnNextQ6.Visible = true;
        }

        private void btnIncorrect2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That is Incorret");
            scoremarks6();
            disableButton();
            btnNextQ6.Visible = true;

        }

        private void btnNextQ6_Click(object sender, EventArgs e)
        {
            Question7 newform = new Question7();
            newform.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Question7 newform = new Question7();
            newform.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            People.SaveScoreToFile();

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            btnIncorrect1.Visible = false;
        }

        //IGNORE
        private void lblQuestion1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
