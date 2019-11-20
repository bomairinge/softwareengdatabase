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
        public static bool alarm = false;
        public static Random rng = new Random();

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
                    p.Pulse = row.Field<decimal>("Pulse");
                    p.Breathing = row.Field<decimal>("Breathing");
                    p.Blood = row.Field<decimal>("Blood");
                    p.Temp = row.Field<decimal>("Temp");
                    patients.Add(p);
                }
            }
        }

        public static void AssignPatientToBed()
        {
            Patient p;
            Bed b;
            Int32 length = patients.Count;
            for (int i = 0; i < 7; i++)
            {
                
                if (beds[i].BedAvailable() == true)
                {
                    if(i <= length && i < length)
                    {
                        b = beds[i];
                        p = patients[i];
                        b.AssignPatient(p, b);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private static void Run()
        {
            timer = new Timer();
            timer.Interval = 5000;
            timer.AutoReset = true;
            timer.Elapsed += AlarmData;
            timer.Enabled = true;
            timer.Start();

        }
        static void AlarmData(object sender, ElapsedEventArgs e)
        {
            //decimal pulseRng, tempRng, breathingRng, bloodRng;
           
            decimal pulseRng = rng.Next(0, 75);
            decimal tempRng = rng.Next(0, 75);
            decimal breathingRng = rng.Next(0, 75);
            decimal bloodRng = rng.Next(0, 75);

            for (int i = 0; i <= patients.Count; i++)
            {
                if (beds[i].BedAvailable() == false)
                {
                    return;
                }
                else
                {
                    //Sets patient levels for measurables
                    beds[i].currentPatient.Pulse = pulseRng;
                    beds[i].currentPatient.Temp = tempRng;
                    beds[i].currentPatient.Breathing = breathingRng;
                    beds[i].currentPatient.Blood = bloodRng;

                    for (int j = 0; j < beds[i].moduleList.Count; i++)
                    {

                        if (beds[i].currentPatient.Pulse > beds[i].moduleList[j].Upperlimit || beds[i].currentPatient.Pulse < beds[i].moduleList[j].Lowerlimit) 
                        {
                            alarm = true;
                        }
                        //else if (beds[i].currentPatient.Temp > currentModule.Upperlimit || beds[i].currentPatient.Temp < currentModule.Lowerlimit)
                       // {

                       // }
                        //else if (beds[i].currentPatient.Breathing > currentModule.Upperlimit || beds[i].currentPatient.Breathing < currentModule.Lowerlimit)
                        //{

                        //}
                       // else if (beds[i].currentPatient.Blood > currentModule.Upperlimit || beds[i].currentPatient.Blood < currentModule.Lowerlimit)
                       // {

                       // }
                        else
                        {
                            return;
                        }

                    }


                }

            }
        }
    }
}
