using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDONE
{
    static class PublicVars
    {
        private static int privScoreOverall = 0;
       // public static int ScoreOverall = 0;

        private static People privateCurrentUser = null;

        public static People publicCurrentUser
        {
            get { return privateCurrentUser; }
            set { privateCurrentUser = value; }
        }

        public static int QuizScoreOverall
        {
            get { return privScoreOverall; }
            set { privScoreOverall = value; }
        }
    }
}
