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
    public partial class RegChild : Form
    {
        public RegChild()
        {
            InitializeComponent();
        }

        private void btnMenuReg_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            newform.Show();
            this.Hide();
        }

        private void btnSaveChild_Click(object sender, EventArgs e)
        {
            
            string studentUser = txtUser.Text;
            string studentPass = txtPass.Text;
            int beginnerScore = 0;
            bool notATeacher = false;

            List<People> myList = new List<People>();
            myList = People.LoadSchoolInfo();

            foreach (People inmylist in myList)
            {
                if (inmylist.publicUsername == studentUser)
                {
                    MessageBox.Show("Username has already been taken, try a different one");
                    txtUser.Text = "";
                }

            }
            if (txtUser.Text != "")
            {
                //writes new student to file
                People newStudent = new People(studentUser, studentPass, beginnerScore, notATeacher);
                myList.Add(newStudent);
                People.SaveUsers(myList);
                MessageBox.Show("Your child has been sucessfully registered!");
            }
            else
            {
                MessageBox.Show("username cannot be empty!");
            }

            if (txtPass.Text == "")
            {
                MessageBox.Show("username cannot be empty!");
            }
            

        }

        private void RegChild_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void borderPic1_Click(object sender, EventArgs e)
        {

        }
    }
}
