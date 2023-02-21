using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsDONE
{
    class People
    {
        #region Private Properties
        private string privUsername = "";
        private string privPasssword = "";
        private int scoreOverall = 0;
        private bool isTeacher = false;
       
        
        #endregion

        #region Public Properties
        public string publicUsername
        {
            get { return privUsername; }
            set { privUsername = value; }
        }

        public string publicPassword
        {
            get { return privPasssword; }
            set { privPasssword = value; }
        }

        public int publicScoreOverall
        {
            get { return scoreOverall; }
            set { scoreOverall = value; }
        }

        public bool IsTeacher
        {
            get { return isTeacher; }
            set { isTeacher = value; }
        }

       

       

        #endregion

        #region Constructors

        public People()
        {

        }

        public People(string username, string password)
        {
            publicUsername = username;
            publicPassword = password;
            

        }

        public People(string username, string password, int score, bool Teacher)
        {
            publicUsername = username;
            publicPassword = password;
            publicScoreOverall = score;
            IsTeacher = Teacher;
            
            
            
        }
        #endregion

        #region Methods

        
        public static List<People> LoadSchoolInfo()
        {
            List<People> listofinfo = new List<People>();

            try
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

                    //assigns first word as username and second as password etc...
                    string username = schoolArray[0];
                    string password = schoolArray[1];
                    string score = schoolArray[2];
                    string isaTeacher = schoolArray[3] ;
                    
                    
                    
                    

                    //adds username and password etc... to
                    People singlePerson = new People(username, password, Convert.ToInt32(score), Convert.ToBoolean(isaTeacher));
                    listofinfo.Add(singlePerson);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error with TeacherInformation.txt");
            }


            return listofinfo;
        }



        
        public static void SaveUsers(List<People> myList)
        {
            
            Stream FileStream;

            //opens text file
            FileStream = File.Open(new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName + @"\TxtFile\TeacherInformation.txt", FileMode.Create);
            
            //writes new user to text file
            StringBuilder userDataString = new StringBuilder();
            foreach (People person in myList)
            {
                string line = string.Join(",", person.privUsername, person.privPasssword, person.publicScoreOverall.ToString(), person.IsTeacher);
                userDataString.AppendLine(line);
            }

            byte[] ArrayOfContents = Encoding.ASCII.GetBytes(userDataString.ToString());
            FileStream.Write(ArrayOfContents, 0, ArrayOfContents.Length);

            
            FileStream.Close();
        }

        public static void SaveScoreToFile()
        {
            
            List<People> listOfUsers = new List<People>();
            listOfUsers = People.LoadSchoolInfo();

            
            foreach (People individualUser in listOfUsers)
            {
                if (PublicVars.publicCurrentUser.publicUsername == individualUser.publicUsername)
                {
                    //if the current score is greater than previous score
                    if (PublicVars.QuizScoreOverall > individualUser.publicScoreOverall)
                    {
                        //previous score will be overwritten
                        individualUser.publicScoreOverall = PublicVars.QuizScoreOverall;
                        MessageBox.Show("You have set a new high score");
                        People.SaveUsers(listOfUsers);
                    }
                   
                    break;
                }
            }
        }

        #endregion
    }
}
