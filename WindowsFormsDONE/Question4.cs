using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDONE
{
    public partial class Question4 : Form
    {

        int score = 0;
        public Question4()
        {
            InitializeComponent();

            //allows elemts to be dropped onto pic
            Mathpic.AllowDrop = true;  
        }

        private void Scoremarks()
        {
            MessageBox.Show("your score for this question: " + score);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide();
        }

        private void Question4_Load(object sender, EventArgs e)
        {
            lblScore4.Text = "Score: " + PublicVars.QuizScoreOverall.ToString();
        }

        private void selected(object sender, MouseEventArgs e)
        {
            Label selectedlabel = (Label)sender;
            selectedlabel.DoDragDrop(selectedlabel.Text, DragDropEffects.Copy);
        }

        private void DataDropCheck(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Check(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text).ToString();

            if (droppedText == "Six")
            {
                MessageBox.Show("correct");
                score = score + 1;
                PublicVars.QuizScoreOverall = PublicVars.QuizScoreOverall + score;
                scoremarks4();
                DisabledButton();

            }
            else
            {
                MessageBox.Show("incorrect answer");
                DisabledButton();
                scoremarks4();
            }
            btnNext.Visible = true;
        }

        private void DisabledButton()
        {
            lblCorrect.Enabled = false;
            lblWrong1.Enabled = false;
            lblWrong2.Enabled = false;
            lblWrong3.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Question5 newform = new Question5();
            newform.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            People.SaveScoreToFile();

        }

        private void scoremarks4()
        {
            MessageBox.Show("your score for this question: " + score);
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblWrong1.Visible = false;
            lblWrong3.Visible = false;
        }

        //ignore
        private void Mathpic_Click(object sender, EventArgs e)
        {

        }

       
    }
}
