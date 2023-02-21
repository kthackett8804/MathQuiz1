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
    public partial class Question5 : Form
    {
        int score = 0;
        public Question5()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q5questions.txt");

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
            lblQ5.Text = question;
            rdbtnWrong1.Text = answer1;
            rdbtnWrong2.Text = answer2;
            rdbtnCorrect.Text = answer3;
            rdbtnWrong3.Text = answer4;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newForm = new MainMenu();
            newForm.Show();
            this.Hide();
        }

        private void scoremarks5()
        {
            MessageBox.Show("your score for this question: " + score);
        }

        private void submitAns5_Click(object sender, EventArgs e)
        {
            if (rdbtnCorrect.Checked == true)
            {
                MessageBox.Show("That is correct");
                score = score + 1;
                PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
                scoremarks5();
                disableButton();

            }
            else
            {
                MessageBox.Show("that is incorrect!");
                scoremarks5();
                disableButton();
            }

            //if answer correct cant submit another answer,
            //then allows to go to next question
            submitAns5.Enabled = false;
            btnNext5.Visible = true;
            btnNext5.Visible = true;
        }

        private void disableButton()
        {
            rdbtnCorrect.Enabled = false;
            rdbtnWrong1.Enabled = false;
            rdbtnWrong2.Enabled = false;
            rdbtnWrong3.Enabled = false;
        }

        private void Question5_Load(object sender, EventArgs e)
        {
            lblScore5.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            Question6 newform = new Question6();
            newform.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            People.SaveScoreToFile();

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            rdbtnWrong1.Visible = false;
            rdbtnWrong3.Visible = false;
        }
    }
    }

