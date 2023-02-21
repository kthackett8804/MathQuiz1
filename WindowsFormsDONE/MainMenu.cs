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
    public partial class MainMenu : Form


    {


        public MainMenu()
        {
            InitializeComponent();
            currentUser();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            //does not allow teacher accounts into the quiz
            if (PublicVars.publicCurrentUser.publicUsername.StartsWith("teacher"))
            {

                MessageBox.Show("UNAUTHORIZED ACCESS\nonly students can take the quiz");
            }
            else
            {
                //when clicked code below will open next form
                //the current form (mainmenu) will be hidden
                Question1 newform = new Question1();
                newform.Show();
                this.Hide();
            }

        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            FrmLogin newform = new FrmLogin();
            newform.Show();
            this.Hide();

        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            //allows accounts with username 'teacher' access to RegChild Form
            if (PublicVars.publicCurrentUser.publicUsername.StartsWith("teacher"))
            {
                RegChild newform = new RegChild();
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("UNAUTHORIZED ACCESS\nStudents are not permitted to register other children");
            }

        }

        private void btnViewScore_Click_1(object sender, EventArgs e)
        {
            Score newform = new Score();
            newform.Show();
            this.Hide();
        }


        private void currentUser()
        {
            //if the account is a teacher account then make button visible 
            if (PublicVars.publicCurrentUser.publicUsername.Contains("teacher"))
            {
                btnViewScore.Visible = true;
            }
        }

        //ignore
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblViewScore_Click(object sender, EventArgs e)
        {

        }

        
    }
}
