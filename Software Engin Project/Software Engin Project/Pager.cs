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
		// Creating strings for pager/phone number (Public to allow access)
        public string pager, phoneNumber;

        private void PhoneNum_TextChanged(object sender, EventArgs e)
        {
			//setting phone number var
            phoneNumber = phoneNum.Text;
        }

        private void PagerID_TextChanged(object sender, EventArgs e)
        {
			// setting pager var
            pager = PagerID.Text;
        }

        private void Okay_Click(object sender, EventArgs e)
        {
			// closes form on click okay
            this.Close();
        }

        public Pager()
        {
            InitializeComponent();
        }
    }
}
