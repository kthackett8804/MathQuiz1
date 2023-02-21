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
    public partial class Question1 : Form
    {
        int score = 0;

        public Question1()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        #region Variables
        Random rnd = new Random();

        //puts the questions and answer in one place in the array
        string[] quizDataArray = File.ReadAllLines(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
            + @"\TxtFile\Q1questions.txt");

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
            lblQuestion1.Text = question;
            btn1.Text = answer1;
            btn2.Text = answer2;
            btn3.Text = answer3;

        }


        private void menuButton_Click(object sender, EventArgs e)
        {
           MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide(); 
        }

        private void DisableButton()
        {
            //this is a method as it is more efficient
            //feature of object orientated programming (re-use of code)
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("That is correct");
            score = score + 1;
            PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
            DisableButton();
            scoremarks();
            btnNextQ.Visible = true;

        }

        
        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That is incorrect");

            DisableButton();
            scoremarks();
            btnNextQ.Visible = true;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That is incorrect");

            DisableButton();
            scoremarks();
            btnNextQ.Visible = true;
        }

        private void btnNextQ2_Click(object sender, EventArgs e)
        {
            Question2 newForm = new Question2();
            newForm.Show();
            this.Hide();
        }

        private void Question1_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }
        private void scoremarks()
        {
            MessageBox.Show("your score for this question: " + score);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            People.SaveScoreToFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn3.Visible = false;
        }


        //ignore
        private void lblscore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
    
}
