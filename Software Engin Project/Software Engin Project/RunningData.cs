using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Software_Engin_Project
{
    class RunningData
    {
        public static Bed[] beds;
        public static List<Patient> patients;

        private static Timer timer;

        public DataSet patient = DatabaseConnection.Sample.createDataSet("select * FROM Patient");
        public RunningData()
        {

            beds = new Bed[8];

            GenerateBed();
            GeneratePatientList();
            AssignPatientToBed();
            Run();
            

        }
        public void GenerateBed()
        {
            for (int i = 0; i < beds.Length; i++)
            {
                beds[i] = new Bed();

            }
        }
        public void GeneratePatientList()
        {
            patients = new List<Patient>();

            foreach (DataTable table in patient.Tables)
            {
                foreach (DataRow row in table.Rows)
                {

                    Patient p = new Patient();
                    p.PatientID = row.Field<int>("Patient_ID");
                    p.Firstname = row.Field<string>("First_Name");
                    p.LastName = row.Field<string>("Last_Name");
                    p.Pulse = row.Field<double>("Pulse");
                    p.Breathing = row.Field<double>("Breathing");
                    p.Blood = row.Field<double>("Blood");
                    p.Temp = row.Field<double>("Temp");
                    patients.Add(p);
                }
            }
        }

        public static void AssignPatientToBed()
        {
            Patient p;
            Bed b;

            for (int i = 0; i < 7; i++)
            {
                if(beds[i].BedAvailable() == true)
                {
                    b = beds[i];
                    p = patients[i];
                    b.AssignPatient(p, b);
                }
            }
         }
        private static void Run()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += AlarmData;
            timer.Enabled = true;
            timer.Start();

        }
        static void AlarmData(object sender, ElapsedEventArgs e)
        {
            
            for (int i = ; i < 7; i++)
            {
                if (beds[i].BedAvailable() == true)
                    return;
                else
                {
                    //Sets patient levels for measurables
                    beds[i].currentPatient.Pulse = Constants.pulseRng;
                    beds[i].currentPatient.Temp = Constants.tempRng;
                    beds[i].currentPatient.Breathing = Constants.breathingRng;
                    beds[i].currentPatient.Blood = Constants.bloodRng;

                    if(beds[i].currentPatient.Pulse > beds[i].moduleList. 
                }

            }
    }
}
