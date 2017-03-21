using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace KennelSYS
{
    class Kennels
    {
        //Attributes
        public int intKennelNo;
        public String strKennelStatus;
        public String strTypes;

        //Constructor
        public Kennels()
        {
            intKennelNo = 0;
            strKennelStatus = "";
            strTypes = "";
        }

        //Getter methods
        public int getKennelNo()
        {
            return intKennelNo;
        }
        public String getKennelStatus()
        {
            return strKennelStatus;
        }
        public String getTypes()
        {
            return strTypes;
        }

        //Setter methods
        public void setKennelNo(int intKennelNo)
        {
            this.intKennelNo = intKennelNo;
        }
        public void setKennelStatus(String strKennelStatus)
        {
            this.strKennelStatus = strKennelStatus;
        }
        public void setTypes(String strTypes)
        {
            this.strTypes = strTypes;
        }

        //toString()
        public String toString()
        {
            return "Kennel Number " + getKennelNo() +
                    "\nKennel Status " + getKennelStatus() +
                    "\nType:" + getTypes();
        }



        //Gets next available KennelNo
        public int getAvailableKennelNo()
        {
            int intKennelNo;

            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            //Define SQL query
            String strSQL = "SELECT MAX(KennelNo) FROM Kennels";

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //read the record in dr
            myConn.Open();

            //Use Data Reader
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //if nothing in db = sets default no to 0 otherwise gets max no +=1
            if (dr.IsDBNull(0))
                intKennelNo = 1;
            else
                intKennelNo = Convert.ToInt16(dr.GetValue(0)) + 1;


            //Close DB connection
            myConn.Close();


            //return the nextRate
            return intKennelNo;
        }//end getavailablekennelno

       
        //adds a new kennel with kennel no and status set to 'a' for available
        public void addNewKennel()
        {
            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Define SQL query
            String strSQL = "INSERT INTO Kennels VALUES (" + this.intKennelNo + ",'" + this.strTypes + "','A')";
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();
            
            //execute
            cmd.ExecuteNonQuery();

            //Close DB connectopn
            myConn.Close();
        }//End addnewkennel method


    }
}
