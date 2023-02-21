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
    public partial class Question3 : Form
    {
        int score = 0;
        public Question3()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q3questions.txt");

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
            lblQuestion3.Text = question;
            

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide();
        }

        private void submitAns3_Click(object sender, EventArgs e)
        {
            if ( txtboxQ3.Text == correctAnswer)
            {
                MessageBox.Show("correct!");
                score = score + 1;
                PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
                ScoreMarks3();
                submitAns3.Enabled = false;
                txtboxQ3.Enabled = false;
                
                
            }
            else
            {
                MessageBox.Show("incorrect!");
                submitAns3.Enabled = false;
                txtboxQ3.Enabled = false;
                ScoreMarks3();

            }
            btnNext.Visible = true;
        }

        private void TxtboxQ3_KeyDown(object sender, KeyEventArgs e)
        {
           
        }


        private void ScoreMarks3()
        {
            MessageBox.Show("your score for this question: " + score);
        }


        private void Question3_Load(object sender, EventArgs e)
        {
            lblScore3.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Question4 newform = new Question4();
            newform.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            People.SaveScoreToFile();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblHints.Visible = true;
            lblHints.Text = $"Possible answers\n{Convert.ToInt32(correctAnswer) + 1}\n{correctAnswer}\n{Convert.ToInt32(correctAnswer)-3}";
        }

        //ignore
        private void Question3label_Click(object sender, EventArgs e)
        {

        }

        private void lblscore3_Click(object sender, EventArgs e)
        {

        }

       
    }
    }

