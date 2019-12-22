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
        // Variabless needed to create and assign patients to bed. - A list is used to do this
        public static Bed[] beds;
        public static List<Patient> patients;
        public static bool alarm, fatalAlarm = false;

        public DataSet patient = DatabaseConnection.Sample.createDataSet("select * FROM Patient");
        public RunningData()
        {

            beds = new Bed[8];
            // Calling the GenerateBed, Patient and Assingpatient methods - creates 8 beds, creates x amount of patients and adds them to a bed if available.
            GenerateBed();
            GeneratePatientList();
            AssignPatientToBed();

        }
        public void GenerateBed()
        {
            // Loop to generate beds 
            for (int i = 0; i < beds.Length; i++)
            {
                beds[i] = new Bed();

            }
        }
        // Method to generate patients
        public void GeneratePatientList()
        {
            patients = new List<Patient>();

            foreach (DataTable table in patient.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    // Adding list of patient details and vitals
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
        // Method to assign patients to an available bed
        public static void AssignPatientToBed()
        {
            Patient p;
            Bed b;
            Int32 length = patients.Count;
            for (int i = 0; i < 7; i++)
            {

                if (beds[i].BedAvailable() == true)
                {
                    if (i <= length && i < length)
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
        // Alarm data - generates patient vitals and checks to see if they exceed the set alarm limits
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
                    //Sets patient levels for measurables - Will generate a new random for vitals (simulating a patient)
                    beds[i].currentPatient.Pulse = RandomNum.NextRandom();
                    beds[i].currentPatient.Temp = RandomNum.NextRandom();
                    beds[i].currentPatient.Breathing = RandomNum.NextRandom();
                    beds[i].currentPatient.Blood = RandomNum.NextRandom();
                    if (beds[i].currentPatient.Pulse == 0 || beds[i].currentPatient.Temp == 0 || beds[i].currentPatient.Breathing == 0 || beds[i].currentPatient.Blood == 0)
                    {
                        fatalAlarm = true;
                    }
                    // If statements to check Patient[i] vitals and triggers alarm if exceeds limtis
                    else if (beds[i].currentPatient.Pulse > beds[i].moduleList[0].Upperlimit || beds[i].currentPatient.Pulse < beds[i].moduleList[0].Lowerlimit)
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
