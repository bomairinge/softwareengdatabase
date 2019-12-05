using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Software_Engin_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Upon Login click runs the method to check if the login credentials exist
            int rows = DatabaseConnection.Sample.getSelectCount("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");




            //will trigger if a employees credentials match
            if (rows == 1)
            {
                //hides this form
                this.Hide();

                //creates a timestamp
                string time = Constants.TimeStamp(DateTime.Now);
                //Logs the current employee logging in as currentEmployee
                int employeeID = Convert.ToInt32(textBox1.Text);
                Constants.currentEmployee = textBox1.Text;

                //Creates the Login record
                DatabaseConnection.Sample.loginRecord(employeeID, time);
                //creates new bed overview form
                BedOverview bed = new BedOverview();
                Pager page = new Pager();
                //shows the bed overview form
                bed.Show();
                page.Show();
            }
            else
            {
                //if No credentials this else will trigger


                // Displays message box
                MessageBox.Show("No Username or Password found with those credentials.");


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //Hides the alarm pic until we want to show it
            AlarmPic1.Hide();

        }
        public static void PatientVitals()
        {
            //the For loop runs for the entirity of the program hence the large range
            for (int i = 0; i < 999999999; i++)
            {
                //Runs the alarm data method which checks if a bed should be alarming out or not
                RunningData.AlarmData();
                //method to show the Alarm picture if a bed is alarming

                //If a patient died/vital hits 0 a permanent messagebox will appear
                if (RunningData.fatalAlarm == true)
                {
                    while (true)
                    {
                        DialogResult newResult = MessageBox.Show("Patient: " + RunningData.beds[Constants.alarmingBed].currentPatient.Firstname + " " +
                        RunningData.beds[Constants.alarmingBed].currentPatient.LastName + "\nBed: " + (Constants.alarmingBed + 1) + "\nPatient is DEAD!"
                        , caption: "Fatal", MessageBoxButtons.OK);
                    }
                }
                // if a patient vital exceeds the limits a message box will appear/alarm sound
                if (RunningData.alarm == true)
                {
                    //Pulls a timestamp for the alarm
                    string time = Constants.TimeStamp(DateTime.Now);
                    //Pulls the EmployeeID for the employee currently logged in
                    int employeeID = Convert.ToInt32(Constants.currentEmployee);
                    //Pulls which Module is alarming out
                    int ModuleID = Convert.ToInt32(Constants.alarmingModule);
                    //Pulls which bed is alarming out increases by 1 as bed 0 does not exist
                    int BedID = Convert.ToInt32(Constants.alarmingBed + 1);


                    //Creates a Messagebox showing which patient/bed is alarming out and give the user the option to mute the alarm

                    DialogResult result = MessageBox.Show("Patient: " + RunningData.beds[Constants.alarmingBed].currentPatient.Firstname + " " +
                    RunningData.beds[Constants.alarmingBed].currentPatient.LastName + "\nBed: " + (Constants.alarmingBed + 1) + "\nMute Alarm?"
                    , caption: "Alarm", MessageBoxButtons.OK);

                    //activates on a user clicking Ok within messagebox
                    if (result == DialogResult.OK)
                    {
                        //Creates a timestamp for the time alarm is muted
                        string mutedTime = Constants.TimeStamp(DateTime.Now);

                        //Create initial alarm record
                        DatabaseConnection.Sample.alarmRecord(employeeID, ModuleID, BedID, time, mutedTime);
                    }
                    //sets the alarms back to false so they can be reactivated upon next alarm
                    RunningData.alarm = false;
                }
                Thread.Sleep(2000);
            }
        }
        //method to show alarms upon a bed alarming out
        public void AlarmsShow()
        {
            if (RunningData.alarm == true)
            {
                //shows the alarming picture
                AlarmPic1.Show();

            }
            else
            {
                //hides the alarm picture
                AlarmPic1.Hide();
            }
        }
    }
}
