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
<<<<<<< HEAD
            int rows = DatabaseConnection.Sample.getSelectCount("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");

=======
            
            int rows = DatabaseConnection.Sample.getSelectCount("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");
           
>>>>>>> 48b356b585f6d377be0360658436d1668c6042c3
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
                // Initialises message box variables
                string message = "No Username or Password found with those credentials. Retry?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays message box
                result = Messagebox.Show("");
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
    }
}
