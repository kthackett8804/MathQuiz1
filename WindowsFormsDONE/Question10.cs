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
    public partial class Question10 : Form
    {
        int score = 0;
        public Question10()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q10questions.txt");

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
            string answer4 = GetAnswers(questionArray[4]);

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
            if (questionArray[4].StartsWith("#"))
            {
                GetAnswers(questionArray[4]);
            }

            //assigns questions and answers to the buttons and labels
            lblQuestion.Text = question;
            rdButton1.Text = answer1;
            rdButton2.Text = answer2;
            rdButton3.Text = answer3;
            rdButton4.Text = answer4;

        }

        private void scoreMarks10()
        {
            MessageBox.Show("your score for this question: " + score);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void submitAns_Click(object sender, EventArgs e)
        {
            if (rdButton3.Checked == true)
            {
                MessageBox.Show("That is correct");
                score = score + 1;
                PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
                scoreMarks10();
                DisableButton();

                People.SaveScoreToFile();
                

            }
            else
            {
                MessageBox.Show("that is incorrect!");
                scoreMarks10();
                DisableButton();
                People.SaveScoreToFile();
                
            }
            btnNextQ10.Visible = true;
            submitAns.Enabled = false;
            btnNextQ10.Visible = true;
        }

        private void DisableButton()
        {
            rdButton1.Enabled = false;
            rdButton2.Enabled = false;
            rdButton3.Enabled = false;
            rdButton4.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Score newform = new Score();
            this.Hide();
            newform.Show();
        }

        private void Question10_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            rdButton1.Visible = false;
            rdButton4.Visible = false;
        }
    } 
}
