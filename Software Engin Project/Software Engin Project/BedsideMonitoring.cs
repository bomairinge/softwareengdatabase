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
            if (RunningData.beds[Constants.currentBed].currentPatient == null)
            {
                Namelabel.Text = "No Patient";
                return;
            }
            else
            {
                string FirstName = RunningData.beds[Constants.currentBed].currentPatient.Firstname;
                string LastName = RunningData.beds[Constants.currentBed].currentPatient.LastName;
                Namelabel.Text =   FirstName + LastName;
                
                Thread thr = new Thread(new ThreadStart(DisplayVitals));
                
                thr.Start();
                
            }            

        }
        public void DisplayVitals()
        {
            for (int i = 0; i < 99999999; i++)
            {
                if (RunningData.beds[Constants.currentBed].currentPatient == null)
                {
                    break;
                }
                else
                {

                    string pulse = RunningData.beds[Constants.currentBed].currentPatient.Pulse.ToString("00.00");
                    if (PulseText.InvokeRequired)
                        this.Invoke(new MethodInvoker(() => PulseText.Text = pulse));
                    else
                        PulseText.Text = pulse;

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
            
            this.Hide();
            BedOverview bed = new BedOverview();

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
