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
        
        public DataSet patient = DatabaseConnection.Sample.createDataSet("select * FROM Patient");
        public RunningData()
        {

            beds = new Bed[8];

            GenerateBed();
            GeneratePatientList();
            AssignPatientToBed();
            
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
        
        public static void AlarmData()
        {      
                        
            for (int i = 0; i <= patients.Count; i++)
            {
                if (beds[i].currentPatient == null)
                {
                    return;
                }
                else
                {
                    //Sets patient levels for measurables
                    beds[i].currentPatient.Pulse = RandomNum.NextRandom();
                    beds[i].currentPatient.Temp = RandomNum.NextRandom();
                    beds[i].currentPatient.Breathing = RandomNum.NextRandom();
                    beds[i].currentPatient.Blood = RandomNum.NextRandom();

                    if (beds[i].currentPatient.Pulse > beds[i].moduleList[0].Upperlimit || beds[i].currentPatient.Pulse < beds[i].moduleList[0].Lowerlimit) 
                        {                        
                        alarm = true;
                        Constants.alarmingBed = i;
                        Constants.alarmingModule = 0;
                        }
                        else if (beds[i].currentPatient.Breathing > beds[i].moduleList[1].Upperlimit || beds[i].currentPatient.Breathing < beds[i].moduleList[1].Lowerlimit)
                           {
                            alarm = true;
                        Constants.alarmingBed = i;
                        Constants.alarmingModule = 1;
                    }
                        else if (beds[i].currentPatient.Blood > beds[i].moduleList[2].Upperlimit || beds[i].currentPatient.Blood < beds[i].moduleList[2].Lowerlimit)
                        {
                            alarm = true;
                        Constants.alarmingBed = i;
                        Constants.alarmingModule = 2;
                    }
                        else if (beds[i].currentPatient.Temp > beds[i].moduleList[3].Upperlimit || beds[i].currentPatient.Temp < beds[i].moduleList[3].Lowerlimit)
                        {
                            alarm = true;
                        Constants.alarmingBed = i;
                        Constants.alarmingModule = 3;
                    }
                        else
                        {
                     
                    }

                    


                }

            }
        }
    }
}
