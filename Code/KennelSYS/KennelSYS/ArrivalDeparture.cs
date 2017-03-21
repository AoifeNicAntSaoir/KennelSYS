using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;

namespace KennelSYS
{
    class ArrivalDeparture
    {

        public int intBookingNo;
        public String strCheckInDate;
        public String strCheckOutDate;
        
        public ArrivalDeparture()
        {
            intBookingNo = 0;
            strCheckInDate = "";
            strCheckOutDate = "";
        }
        //Getter
        public int getBookingNo()
        {
            return intBookingNo;
        }
        public String getCheckInDate()
        {
            return strCheckInDate;
        }
        public String getCheckOutDate()
        {
            return strCheckOutDate;
        }
       
        //Setter
        public void setBookingNo(int intBookingNo)
        {
            this.intBookingNo = intBookingNo;
        }
        public void setCheckInDate(String strCheckInDate)
        {
            this.strCheckInDate = strCheckInDate;
        }
        public void setCheckOutDate(String strCheckOutDate)
        {
            this.strCheckOutDate = strCheckOutDate;
        }

   
       
        public void insArrivalDeparture()
        {
            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Define SQL query
            String strSQL = " ";


            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connection
            myConn.Close();

        }


    }
}
