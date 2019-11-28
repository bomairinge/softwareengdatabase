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

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int rows = DatabaseConnection.Sample.getSelectCount("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");

            
            
           

              if(rows==1)
            {
                this.Hide();

                string time = Constants.TimeStamp(DateTime.Now);

                int employeeID = Convert.ToInt32(textBox1.Text);
                Constants.currentEmployee = textBox1.Text;

                DatabaseConnection.Sample.loginRecord(employeeID, time);

                BedOverview bed = new BedOverview();

                bed.Show();
            }
            else
            {
                // Initialises message box variables


                // Displays message box
                MessageBox.Show("No Username or Password found with those credentials.");
            } 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            AlarmPic1.Hide();

            RunningData run = new RunningData();

            Thread loginthr = new Thread(new ThreadStart(PatientVitals));
            loginthr.Start();
            
        }
        public void PatientVitals()
        {
            for (int i = 0; i < 999999999; i++)
            {
                RunningData.AlarmData();
                AlarmsShow();

                if(RunningData.alarm == true)
                {
                    string time = Constants.TimeStamp(DateTime.Now);

                    int employeeID = Convert.ToInt32(Constants.currentEmployee);
                    int ModuleID = Convert.ToInt32(Constants.alarmingModule);
                    int BedID = Convert.ToInt32(Constants.alarmingBed+1);
                    
                    

                    DialogResult result = MessageBox.Show("Patient: " + RunningData.beds[Constants.alarmingBed].currentPatient.Firstname + " " + 
                    RunningData.beds[Constants.alarmingBed].currentPatient.LastName + "\nBed: " + (Constants.alarmingBed + 1) + "\nMute Alarm?"
                    , caption:"Alarm" , MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        string mutedTime = Constants.TimeStamp(DateTime.Now);

                        //Create initial alarm record
                        DatabaseConnection.Sample.alarmRecord(employeeID, ModuleID, BedID, time, mutedTime);
                    }
                    
                    RunningData.alarm = false;
                }
                Thread.Sleep(1000);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoginAlarmPic1_Click(object sender, EventArgs e)
        {
            
        }
        public void AlarmsShow()
        {
            if (RunningData.alarm == true)
            {
                AlarmPic1.Show();
                
            }
            else
            {
                AlarmPic1.Hide();
            }
        }
    }
}
