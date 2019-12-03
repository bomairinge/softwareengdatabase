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

        private void label10_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Generates a management page
            Management man = new Management();
            //Shows the Management Page
            man.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            Constants.currentBed = 0;

            //creates new bedside monitoring page
            BedsideMonitoring bed = new BedsideMonitoring();

            //Shows the Bedside Monitoring Page
            bed.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            Constants.currentBed = 1;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void BedOverview_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            Constants.currentBed = 2;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            Constants.currentBed = 3;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            Constants.currentBed = 4;
            BedsideMonitoring bed = new BedsideMonitoring();
           
            bed.Show();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            Constants.currentBed = 5;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 6;
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 7;
            //Assigns a value to the Constant currentBed variable so we know which bed we are working with
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }
    }
}
