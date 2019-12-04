using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engin_Project
{
    class Patient
    {
        private int patientID;
        private string firstName;
        private string lastName;
        private decimal pulse;
        private decimal breathing;
        private decimal blood;
        private decimal temp;
        // Constructors for patients class
        public int PatientID
        {
            get
            {
                return patientID;
            }
            set
            {
                patientID = value;
            }
        }
        public string Firstname
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public decimal Pulse
        {
            get
            {
                return pulse;
            }
            set
            {
                pulse = value;
            }
        }
        public decimal Breathing
        {
            get
            {
                return breathing;
            }
            set
            {
                breathing = value;
            }
        }
        public decimal Blood
        {
            get
            {
                return blood;
            }
            set
            {
                blood = value;
            }
        }
        public decimal Temp
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }
    }
}
