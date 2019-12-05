using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engin_Project
{
    public partial class BedOverview : Form
    {
        public BedOverview()
        {
            InitializeComponent();
        }

        //Logout button
        private void Button5_Click(object sender, EventArgs e)
        {
            //Hides the current page
            this.Hide();
            //Pulls a timestamp for the Login Log records
            string time = Constants.TimeStamp(DateTime.Now);
            //Pulls a employee ID for the employee Logging out
            int employeeID = Convert.ToInt32(Constants.currentEmployee);
            //Method to input the Logout record
            DatabaseConnection.Sample.loginRecord(employeeID, time);

            //Creates a Login Page
            Login log = new Login();
            //Shows the Login Page
            log.Show();

        }

        private void Logs_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Generates a management page
            Management man = new Management();
            //Shows the Management Page
            man.Show();
        }

        private void Bed1_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[0].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                Constants.currentBed = 0;

                //creates new bedside monitoring page
                BedsideMonitoring bed = new BedsideMonitoring();

                //Shows the Bedside Monitoring Page
                bed.Show();
            }

        }

        private void Bed2_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[1].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                Constants.currentBed = 1;
                BedsideMonitoring bed = new BedsideMonitoring();

                bed.Show();
            }

        }

        private void Bed3_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[2].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                Constants.currentBed = 2;
                BedsideMonitoring bed = new BedsideMonitoring();

                bed.Show();

            }
        }

        private void Bed4_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[3].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                Constants.currentBed = 3;
                BedsideMonitoring bed = new BedsideMonitoring();

                bed.Show();
            }

        }

        private void Bed5_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[4].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                Constants.currentBed = 4;
                BedsideMonitoring bed = new BedsideMonitoring();

                bed.Show();
            }

        }

        private void Bed6_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[5].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                Constants.currentBed = 5;
                BedsideMonitoring bed = new BedsideMonitoring();

                bed.Show();
            }

        }

        private void Bed7_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[6].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                Constants.currentBed = 6;
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                BedsideMonitoring bed = new BedsideMonitoring();

                bed.Show();
            }

        }

        private void Bed8_Click(object sender, EventArgs e)
        {
            if (RunningData.beds[7].currentPatient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                Constants.currentBed = 7;
                //Assigns a value to the Constant currentBed variable so we know which bed we are working with
                BedsideMonitoring bed = new BedsideMonitoring();
                bed.Show();
            }

        }
    }
}
