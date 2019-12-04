using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engin_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Creates a new running Data which initialises beds and assigns patients/modules
            RunningData run = new RunningData();
            //creation of a thread to run the Method which controls alarms
            Thread loginthr = new Thread(new ThreadStart(Login.PatientVitals));
            //Starts the thread
            loginthr.Start();
            Application.Run(new Login());


        }
    }
}
