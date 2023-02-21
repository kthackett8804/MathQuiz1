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
    public partial class Question9 : Form
    {
        int score = 0;

        public Question9()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q9questions.txt");

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
            btnIncorrect2.Text = answer2;
            btnCorrect.Text = answer3;

        }

        private void btnIncorrect2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That is Incorret");
            scoremarks9();
            disableButton();
            btnNextQ9.Visible = true;
        }

        private void btnIncorrect1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That is Incorret");
            scoremarks9();
            disableButton();
            btnNextQ9.Visible = true;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Correct");
            score = score + 1;
            PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
            disableButton();
            scoremarks9();
            btnNextQ9.Visible = true;
        }

        private void disableButton()
        {
            btnCorrect.Enabled = false;
            btnIncorrect1.Enabled = false;
            btnIncorrect2.Enabled = false;
        }

        private void scoremarks9()
        {
            MessageBox.Show("your score for this question: " + score);
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            this.Hide();
            newform.Show();
        }

        private void Question9_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void btnNextQ9_Click(object sender, EventArgs e)
        {
            Question10 newform = new Question10();
            this.Hide();
            newform.Show();
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
        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion6_Click(object sender, EventArgs e)
        {

        }

        private void btnNextQ6_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

       
    }
}
