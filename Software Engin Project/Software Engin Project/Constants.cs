using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Software_Engin_Project
{
    class Constants
    {
        //This class is for constants that will be used throughout the Program to avoid assigning them multiple times in multiple places.
        //keeps track of who is currently using the system used for alarm logs and login records.
        public static string currentEmployee;
        //Keeps track of which bed is currently alarming out used for alarm logs
        public static int alarmingBed;
        //Keeps track of which module is currently alarming out used for alarm logs
        public static int alarmingModule;

        //Keeps track of which bed is currently being viewed
        public static int currentBed;

        //Method to generate a timestamp when called used for both alarm logs and Login records
        public static string TimeStamp(DateTime value)
        {
            return value.ToString("yy-MM-dd HH:mm:ss");
        }
        
              
        }
}
