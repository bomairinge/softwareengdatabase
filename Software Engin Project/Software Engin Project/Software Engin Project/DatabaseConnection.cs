using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engin_Project
{
    class DatabaseConnection
    {
        //Instance of Class
        private static DatabaseConnection _sample;

        //Stores the connection string defined within the properties of the project
        private static string DataConnectionString;

        private SqlConnection sqlconnect;

        private SqlDataAdapter sqladapt;

        public static DatabaseConnection Sample
        {
            get
            {
                //check if the object has already been created
                if (_sample == null)
                {
                    //create the object "_sample"
                    _sample = new DatabaseConnection();

                    //Links the connection string
                    DatabaseConnection.DataConnectionString = Properties.Settings.Default.Database_Connection;
                }
                return _sample;
            }
        }

        //property for connection string only used within the database connection class.
        public static string DBConnectionString
        {
            set
            {
            DataConnectionString = value;
            }
        }

        //Methods to Open and Close the connection to the database

        //Opens the connection to the Database "Bedside_Database"
        public void AccessDatabase()
        {
            sqlconnect = new SqlConnection(DataConnectionString);

            sqlconnect.Open();
        }

        //Closes the link to the Database "Bedside_Database"
        public void closedatabase()
        {
            sqlconnect.Close();
        }
    

    public DataSet createDataSet(string sqlstatement)
    {
        DataSet employeeData = new DataSet();

        AccessDatabase();

        sqladapt = new SqlDataAdapter(sqlstatement, DataConnectionString);

        sqladapt.Fill(employeeData);

            closedatabase();

            return employeeData;
                                 
    }


}
