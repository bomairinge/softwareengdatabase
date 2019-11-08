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
            // DatabaseConnection.Sample.createDataSet test = ("Select Count(*) from Employee where Username'" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");
            // DataSet employeedata = new Sample.("Select Count(*) from Employee where Username'" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");
            int rows = DatabaseConnection.Sample.getSelectCount("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");
            /*  DataSet data = DatabaseConnection.createDataSet("Select Count(*) from Employee where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'");
              DataTable dt = new DataTable();
              dt = data.Tables[0];

              //this.Hide(); // Code will need to go    nto an IF statement once database connection created
              //BedOverview bed = new BedOverview(); // Code will need to go into an IF statement once database connection created
              //bed.Show(); // Code will need to go into an IF statement once database connection created



              if (dt.Rows[0][0].ToString() == "1")
           */
              if(rows==1)
            {
                this.Hide(); 
                BedOverview bed = new BedOverview(); 
                bed.Show(); 
            }
            else
            {
            //Messagebox.Show("No Username or Password found with those credentials");
            } 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginAlarmPic1.Hide();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
