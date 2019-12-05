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
    public partial class Set_Alarms : Form
    {
        private static Set_Alarms _SetAlarms;

        public static Set_Alarms SetAlarmsInstance
        {
            get
            {
                if (_SetAlarms == null)
                {
                    _SetAlarms = new Set_Alarms();
                }
                return _SetAlarms;
            }
        }
        // converting vars for alarmlimit page
        decimal currentLower = RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Lowerlimit;
        decimal currentUpper = RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Upperlimit;
        public Set_Alarms()
        {
            InitializeComponent();
            string module = RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Modulename;
            ModuleName.Text = module;

            SetCurrentLower.Text = Convert.ToString(currentLower);
            SetCurrentUpper.Text = Convert.ToString(currentUpper);
        }

        // Will return to home page
      
        // Will return to patient page
        private void ReturnToPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            BedsideMonitoring.GetBedsideMonitoringInstance.Show();
        }
        // This will set the limits which have been entered
        private void SetLimits_Click(object sender, EventArgs e)
        {
            decimal newUpper = Convert.ToDecimal(UpperLimit.Text);
            decimal newLower = Convert.ToDecimal(LowerLimit.Text);
            RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Upperlimit = newUpper;
            RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Lowerlimit = newLower;
            Console.WriteLine(RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Upperlimit + "\n" + RunningData.beds[Constants.currentBed].moduleList[Constants.currentModule].Lowerlimit);
            SetCurrentLower.Text = Convert.ToString(currentLower);
            SetCurrentUpper.Text = Convert.ToString(currentUpper);
            this.Hide();
            Set_Alarms.SetAlarmsInstance.Show();

        }

        private void DeleteModule_Click(object sender, EventArgs e)
        {
            // Code to delete module needed 
        }
    }
}
