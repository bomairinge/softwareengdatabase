using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Software_Engin_Project
{
    public partial class BedsideMonitoring : Form
    {
        public BedsideMonitoring()
        {
            
            InitializeComponent();
            //checks upon loading if current bed is occupied
            if (RunningData.beds[Constants.currentBed].currentPatient == null)
            {
                //If unnoccupied displays no patient
                Namelabel.Text = "No Patient";
                return;
            }
            else
            {
                //If Occupied pulls Patient name from the patient linked to the bed
                string FirstName = RunningData.beds[Constants.currentBed].currentPatient.Firstname;
                string LastName = RunningData.beds[Constants.currentBed].currentPatient.LastName;

                //Displays patients name
                Namelabel.Text =   FirstName + LastName;
                
                //Creation of a thread to loop through patient vitals for the current bed
                Thread thr = new Thread(new ThreadStart(DisplayVitals));
                
                //starts the thread
                thr.Start();
                
            }            

        }
        public void DisplayVitals()
        {
            //creation of the for loop that will run as long as needed
            for (int i = 0; i < 99999999; i++)
            {
                //Checks if bed is empty so it doesnt run with an empty bed, which would crash the program
                if (RunningData.beds[Constants.currentBed].currentPatient == null)
                {
                    break;
                }
                else
                {
                    //Pulls the variable from running data for current bed and patient to a string to be displayed.
                    string pulse = RunningData.beds[Constants.currentBed].currentPatient.Pulse.ToString("00.00");
                    //Assigns the variable to the required vital to display to the user
                    if (PulseText.InvokeRequired)
                        this.Invoke(new MethodInvoker(() => PulseText.Text = pulse));
                    else
                        PulseText.Text = pulse;

                    // as above just for the other 3 vitals
                    string breath = RunningData.beds[Constants.currentBed].currentPatient.Breathing.ToString("00.00");
                    if (PulseText.InvokeRequired)
                        this.Invoke(new MethodInvoker(() => BreathingText.Text = breath));
                    else
                        BreathingText.Text = breath;

                    string temp = RunningData.beds[Constants.currentBed].currentPatient.Temp.ToString("00.00");
                    if (TempText.InvokeRequired)
                        this.Invoke(new MethodInvoker(() => TempText.Text = temp));
                    else
                        TempText.Text = pulse;

                    string blood = RunningData.beds[Constants.currentBed].currentPatient.Blood.ToString("00.00");
                    if (Bloodtext.InvokeRequired)
                        this.Invoke(new MethodInvoker(() => Bloodtext.Text = blood));
                    else
                        Bloodtext.Text = pulse;

                    Thread.Sleep(0);
                }
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Hides this Page
            this.Hide();
            //creates the bed overview
            BedOverview bed = new BedOverview();
            //Displays the bed overview allowing the user to change beds/logout/access management
            bed.Show();
        }

        private void BedsideMonitoring_Load(object sender, EventArgs e)
        {
            
        }
           

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BreathingText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click_1(object sender, EventArgs e)
        {

        }
        
        
    }
}
