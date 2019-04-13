using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Happy_Magazines_Subscription
{
    static class Program
    {

        public const int maxMemberSubscriber = 30;
        static public MemberSubscriber[] eArray = new MemberSubscriber[maxMemberSubscriber];

        public const int maxSch = 30;
        static public SchoolSubscriber[] schArray = new SchoolSubscriber[maxSch];

        //Member
        // method to get the next null location to store a new subscriber object
        public static int getNextIndex()
        {
            int i;
            for (i = 0; i < maxMemberSubscriber; i++)
            {
                if (eArray[i] == null)
                    break;
            }
            return i;
        }

        // method to find id of member subscriber in array
        public static int getIdIndex(string id)
        {
            int i;
            //bool available = true;
            for (i = 0; i < maxMemberSubscriber; i++)
            {
                if (eArray[i] != null)
                {
                    if (eArray[i].ID == id)
                    {
                        break;
                    }
                }
            }
            return i;
        } 

        //School
        //Method to get next null location to store a new school object
        public static int getNextSchIndex()
        {
            int i;

            for (i = 0; i < maxSch; i++)
            {
                if (schArray[i] == null)
                    break;

            }
            return i;
        }

        
        // method to find id of employee in array
        public static int getSchIdIndex(string id)
        {
            int i;


            for (i = 0; i < maxSch; i++)
            {
                if (schArray[i] != null)
                {
                    if (schArray[i].ID == id)
                        break;
                }
            }
            return i;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}
