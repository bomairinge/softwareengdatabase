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
        private static Management _Management;

        public static Management ManagementInstance
        {
            get
            {
                if (_Management == null)
                {
                    _Management = new Management();
                }
                return _Management;
            }
        }
        public Management()
        {
            InitializeComponent();
        }

        private void Management_Load(object sender, EventArgs e)
        {
            //Upon load activates the methods to populate the Alarms and Login record Grid views
            populateLoginData();
            populateAlarmData();
        }

        //Method to populate a grid view with the Login Data
        public void populateLoginData()
        {
            //creates a dataset containing all login/logout records
            DataSet loginDataSet = DatabaseConnection.Sample.createDataSet("SELECT * FROM Login_data");

            //converts the dataset to a table
            DataTable table = loginDataSet.Tables[0];

            //Assigns that datatable to the datagridview
            dataGridView1.DataSource = table;
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            //On button click returns to bedoverview hiding this form
            this.Hide();
            BedOverview.BedOverviewInstance.Show();
        }

        //Method to Show the Alarm data 
        public void populateAlarmData()
        {
            //Creates a dataset containing all alarm data
            DataSet alarmDataSet = DatabaseConnection.Sample.createDataSet("SELECT * FROM Alarms");

            //converts the dataset to a datatable
            DataTable table1 = alarmDataSet.Tables[0];

            //displays the datatable
            dataGridView2.DataSource = table1;
        }
    }
}
