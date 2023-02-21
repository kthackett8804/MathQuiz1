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
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void score_Load(object sender, EventArgs e)
        {
            string[] SchoolDataArray = null;

            //populates array with all lines in text file
            SchoolDataArray = File.ReadAllLines(
                new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName
                 + @"\TxtFile\TeacherInformation.txt");

            foreach (string line in SchoolDataArray)
            {
                //split each word with commas as csv
                string[] schoolArray = line.Split(',');

                //assigns first word as username and second as score
                string username = schoolArray[0];
                string score = schoolArray[2];

                if (username.Contains("student"))
                {
                    listOfScores.Items.Add(username + " | " + score);
                    listOfScores.Sorted = true;
                }

                
                

                
            }

           

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu newform = new MainMenu();
            this.Hide();
            newform.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
