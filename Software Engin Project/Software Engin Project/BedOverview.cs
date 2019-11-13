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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Management man = new Management();

            man.Show();
        }
    }
}
