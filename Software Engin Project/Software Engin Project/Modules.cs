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
        private decimal lowerLimit;
        private decimal upperLimit;
        
        
        
        public decimal Lowerlimit
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
        public decimal Upperlimit
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
