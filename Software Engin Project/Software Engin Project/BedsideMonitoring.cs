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
    public partial class BedsideMonitoring : Form
    {
        public BedsideMonitoring()
        {
            InitializeComponent();
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
            BedOverview bed = new BedOverview();

            bed.Show();
        }

        private void BedsideMonitoring_Load(object sender, EventArgs e)
        {
            //create the objects of Module class
            //call a method that generates randomly numbers for the modules and check them against the limits
        }
    }
}
