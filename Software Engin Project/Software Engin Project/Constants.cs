using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engin_Project
{
    class Constants
    {
        public static string currentEmployee;
        public static string TimeStamp(DateTime value)
        {
            return value.ToString("yy-MM-dd HH:mm:ss");
        }
        public static string insertLogData = "INSERT INTO Login_data (Employee_ID, Login_DateTime) VALUES (@EmployeeID, @DateTime)";

    }
}
