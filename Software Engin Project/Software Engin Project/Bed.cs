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
        //set local variables
        public Bed occupied = null;

        //set local accessible instance of class "patient"
        public Patient currentPatient;

        //creation of a list for the creation of modules
        public List<Modules> moduleList;

        //Creation of the dataset modules pulled from the Bedside Database
        private DataSet modules = DatabaseConnection.Sample.createDataSet("select * FROM Modules");

        public  Bed()
        {
            //Creation of the list which is linked to each Bed
            moduleList = new List<Modules>();

            //loop to create a module for each row within the data set
            foreach (DataTable table in modules.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    //creation of modules
                    Modules m = new Modules();

                    //assignment of data fields from the database to Modules variables
                    m.ModuleID = row.Field<int>("Module_ID");
                    m.Modulename = row.Field<string>("Module_Name");
                    m.Lowerlimit = row.Field<decimal>("Lower");
                    m.Upperlimit = row.Field<decimal>("Upper");

                    //adds each module to Module list
                    moduleList.Add(m);
                    
                }
            }
        }

        //method Used to check if a bed is available 
        public bool BedAvailable()
        {
            return occupied == null;
        }

        //Method to Assign a patient to a bed 
        public void AssignPatient(Patient p, Bed b)
        {
            //Sets the current patient dependant on the Patient passed into the method
            currentPatient = p;
        }
        
    }
}

        
        
		

