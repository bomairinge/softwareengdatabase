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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {
            populateLoginData();
        }

        public void populateLoginData()
        {
            DataSet loginDataSet = DatabaseConnection.Sample.createDataSet("SELECT * FROM Login_data");

            DataTable table = loginDataSet.Tables[0];

            dataGridView1.DataSource = table;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            BedOverview bed = new BedOverview();

            bed.Show();
        }
    }
}
