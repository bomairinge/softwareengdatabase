using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engin_Project
{
    class Bed
    {
        public Bed occupied = null;
        public Patient currentPatient;

        public List<Modules> moduleList;

        private DataSet modules = DatabaseConnection.Sample.createDataSet("select * FROM Modules");

        public  Bed()
        {
            moduleList = new List<Modules>();

            foreach (DataTable table in modules.Tables)
            {
                foreach (DataRow row in table.Rows)
                {

                    Modules m = new Modules();
                    m.ModuleID = row.Field<int>("Module_ID");
                    m.Modulename = row.Field<string>("Module_Name");
                    m.Lowerlimit = row.Field<decimal>("Lower");
                    m.Upperlimit = row.Field<decimal>("Upper");
                    moduleList.Add(m);
                    
                }
            }
        }

        public bool BedAvailable()
        {
            return occupied == null;
        }

        public void AssignPatient(Patient p, Bed b)
        {
            currentPatient = p;
        }
        
    }
}

        //method to read from the DB the modules
        //for every record in the DataSet, create the moduleList
        //ublic DataSet modules = DatabaseConnection.Sample.createDataSet("select * FROM Modules");
        
		

