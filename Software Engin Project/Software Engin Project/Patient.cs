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
        private double pulse;
        private double breathing;
        private double blood;
        private double temp;
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
        public double Pulse
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
        public double Breathing
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
        public double Blood
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
        public double Temp
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
