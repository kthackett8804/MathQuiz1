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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnMenuLogin_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.ToLower().Trim();
            string pass = txtPass.Text.ToLower().Trim();

            
            bool isATeacher1 = rdbtnTeacher.Checked;

            //fixed the problem of validation
            bool isAStudent = rdbtnStudent.Checked;

            //creates list of all info inside text file
            List<People> listofAllPeople = People.LoadSchoolInfo();

            foreach (People peopleInList in listofAllPeople)
            {
                //if the username matches ...
                if (peopleInList.publicUsername == user)
                {
                    //and the password ...
                    if (peopleInList.publicPassword == pass)
                    {
                        //if is a teacher and teacher button clicked....
                        if (peopleInList.IsTeacher == true && isATeacher1 == true)
                        {
                            PublicVars.publicCurrentUser = peopleInList;
                            MessageBox.Show("login successful");

                            //navigate teacher to main menu
                            MainMenu menu = new MainMenu();
                            menu.Show();
                            this.Hide();
                            break;
                        }
                        else if (peopleInList.IsTeacher == false && isAStudent == true)
                        {
                            
                            PublicVars.publicCurrentUser = peopleInList;
                            MessageBox.Show("login successful");

                            //will navigate student to quiz
                            Question1 newform = new Question1();
                            newform.Show();
                            this.Hide();
                            break;
                        }
                        else
                        {
                            MessageBox.Show(" Incorrect, try again!");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Incorrect, try again!");
                    }

                }
            }

            //if textbox is empty or incorrect then not found
            if (txtUser.Text.ToLower() == "" || txtPass.Text.ToLower() == "")
            {
                MessageBox.Show("account not found");
            }
            else if (txtUser.Text.ToLower() != user || txtPass.Text.ToLower() != pass)
            {
                MessageBox.Show("account not found");
            }
            

            
           


        }

        private void rdbtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            lblUser.Visible = true;
            lblPass.Visible = true;
            txtPass.Visible = true;
            txtUser.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblUser.Visible = true;
            lblPass.Visible = true;
            txtPass.Visible = true;
            txtUser.Visible = true;
        }

        //ignore
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
