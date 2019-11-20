using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engin_Project
{
    class Modules
    {
        private int moduleID;
        private string moduleName;
		//>>CL
		private double lowerLimit;
		private double upperLimit;
		//<<CL     
        public double Lowerlimit
        {
            get
            {
                return lowerLimit;
            }
            set
            {
                lowerLimit = value;
            }
        }
        public double Upperlimit
        {
            get
            {
                return upperLimit;
            }
            set
            {
                upperLimit = value;
            }
        }
        public string Modulename
        {
            get
            {
                return moduleName;
            }
            set
            {
                moduleName = value;
            }
        }
        public int ModuleID
        {
            get
            {
                return moduleID;
            }
            set
            {
                moduleID = value;
            }
        }
    }
}
