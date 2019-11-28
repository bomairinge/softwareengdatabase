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

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            string time = Constants.TimeStamp(DateTime.Now);

            int employeeID = Convert.ToInt32(Constants.currentEmployee);

            DatabaseConnection.Sample.loginRecord(employeeID, time);

            Login log = new Login();

            log.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management man = new Management();

            man.Show();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 0;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            Constants.currentBed = 2;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 3;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 4;
            BedsideMonitoring bed = new BedsideMonitoring();
           
            bed.Show();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 5;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 6;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Constants.currentBed = 7;
            BedsideMonitoring bed = new BedsideMonitoring();
            
            bed.Show();
        }
    }
}
