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
        static Random rng = new Random();

        private Timer timer;

        public static double pulseRng, tempRng, breathingRng, bloodRng;

        public static string currentEmployee;

        public static int currentBed;
        public static string TimeStamp(DateTime value)
        {
            return value.ToString("yy-MM-dd HH:mm:ss");
        }
        public static string insertLogData = "INSERT INTO Login_data (Employee_ID, Login_DateTime) VALUES (@EmployeeID, @DateTime)";
              
        public void AlarmRandoms()
        {
            pulseRng = rng.Next(0, 75);
            tempRng = rng.Next(0, 75);
            breathingRng = rng.Next(0, 75);
            bloodRng = rng.Next(0, 75);

        }
    }
}
