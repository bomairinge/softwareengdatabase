using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_Engin_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int rows = DatabaseConnection.Sample.getSelectCount("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");

            
            
           

              if(rows==1)
            {
                this.Hide();

                string time = Constants.TimeStamp(DateTime.Now);

                int employeeID = Convert.ToInt32(textBox1.Text);
                Constants.currentEmployee = textBox1.Text;

                DatabaseConnection.Sample.loginRecord(employeeID, time);

                BedOverview bed = new BedOverview();

                bed.Show();
            }
            else
            {
                MessageBox.Show("No user with these credentials.");
            } 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginAlarmPic1.Hide();
            RunningData run = new RunningData();

            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoginAlarmPic1_Click(object sender, EventArgs e)
        {
            
        }
        public void AlarmsShow()
        {
            if (RunningData.alarm == true)
            {
                LoginAlarmPic1.Show();
            }
        }
    }
}
