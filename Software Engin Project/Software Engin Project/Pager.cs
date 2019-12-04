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
    public partial class Pager : Form
    {
        public string pager, phoneNumber;

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {
            phoneNumber = phoneNum.Text;
        }

        private void PagerID_TextChanged(object sender, EventArgs e)
        {
            pager = PagerID.Text;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            Console.WriteLine(pager + "\n" + phoneNumber);
            this.Close();
        }

        public Pager()
        {
            InitializeComponent();
        }
    }
}
