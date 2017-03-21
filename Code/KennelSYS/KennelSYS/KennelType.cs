using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data.Services;

namespace KennelSYS
{
    class KennelType
    {
        //Attribiutes
        public String type;
        public String description;
        public double rate;

        //Constructor
        public KennelType()
        {
            type = "";
            description = "";
            rate = 0;
        }

        // Getter Methods
        public String getType()
        {
            return type;
        }
        public String getDescription()
        {
            return description;
        }
        public double getRate()
        {
            return rate;
        }


        //Setter Methods
        public void setType(String type)
        {
            this.type = type;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public void setRate(double rate)
        {
            this.rate = rate;
        }


       //frmTypeSet calls insKennelType()
        public void insKennelType()
        {
            //Database connection string
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT); //For College
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome); //For home

            //Define SQL query
            String strSQL = "INSERT INTO KennelTypes (KennelType, Description, Rate) VALUES (" + "'" + this.type + "'," +
                                                                                            "'" + this.description + "',"
                                                                                                + this.rate + ")";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
                myConn.Open();
           
            //Execute query
                cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();
        }//End insKennelType()

        

        //frmTypeChg() calls this method
        public void updateKennelType()
        {
            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT); //College
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome); //Home

            //Define SQL query
            String strSQL = " UPDATE KennelTypes SET  Description = '" + this.description +
                "', Rate = " + this.rate + " WHERE KennelType = " + "'" + this.type + "'";


            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //Execute Query
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();

        }//End updateKennelType();


        //Used in frmReservationMakeReservation()
        public decimal getKennelRate(String type)
        {
            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            // OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);


            //Define SQL query
            String strSQL = "SELECT * From KennelTypes WHERE KennelType = '" + type + "'";

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open Connection
            myConn.Open();

            //Read the record in dr
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            decimal rate = dr.GetDecimal(1);
            
            //Close DB Connection
            myConn.Close();

            //Return Decimal value
            return rate;
        }//End getKennelRate()


    }
}
