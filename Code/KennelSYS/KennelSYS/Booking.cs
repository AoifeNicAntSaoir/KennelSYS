using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;

namespace KennelSYS
{
    class Booking
    {
        int intBookingNo;
        int intKennelNo;
        String strSurname;
        String strForename;
        String dteDateFrom;
        String dteDateTo;
        String strStreet;
        String strTown;
        String strCounty;
        String strMobileNo;
        double dblCost;
        String strCheckedIn;

        //Constructor
        public Booking()
        {
            intBookingNo = 0;
            intKennelNo = 0;
            strSurname = "";
            strForename = "";
            dteDateFrom = "";
            dteDateTo = "";
            strStreet = "";
            strTown = "";
            strCounty = "";
            strMobileNo = "";
            strCheckedIn = "";
            dblCost = 0;
        }

        public Booking(int intBookingNo, int intKennelNo, String strSurname, String strForename, String dteDateFrom, String dteDateTo, String strStreet, String strTown, String strCounty, String strMobileNo, double cost, String strCheckedIn)
        {
            setBookingNo(intBookingNo);
            setKennelNo(intKennelNo);
            setSurname(strSurname);
            setForename(strForename);
            setSurname(strSurname);
            setDateFrom(dteDateFrom);
            setDateTo(dteDateTo);
            setStreet(strStreet);
            setTown(strTown);
            setCounty(strCounty);
            setMobileNo(strMobileNo);
            setCheckedIn(strCheckedIn);
            setCost(dblCost);
        }

        //Getter Methods
        public int getBookingNo()
        {
            return intBookingNo;
        }

        public int getKennelNo()
        {
            return intKennelNo;
        }
        public String getSurname()
        {
            return strSurname;
        }

        public String getForename()
        {
            return strForename;
        }

        public String getDateFrom()
        {
            return dteDateFrom;
        }

        public String getDateTo()
        {
            return dteDateTo;
        }

        public String getStreet()
        {
            return strStreet;
        }

        public String getTown()
        {
            return strTown;
        }

        public String getCounty()
        {
            return strCounty;
        }

        public String getMobileNo()
        {
            return strMobileNo;
        }

        public double getCost()
        {
            return dblCost;
        }
        public String getCheckedIn()
        {
            return strCheckedIn;
        }

        //Seter Methods
        public void setBookingNo(int intBookingNo)
        {
            this.intBookingNo = intBookingNo;
        }

        public void setKennelNo(int intKennelNo)
        {
            this.intKennelNo = intKennelNo;
        }

        public void setSurname(String strSurname)
        {
            this.strSurname = strSurname;
        }

        public void setForename(String strForename)
        {
            this.strForename = strForename;
        }

        public void setDateFrom(String dteDateFrom)
        {
            this.dteDateFrom = dteDateFrom;
        }
        public void setDateTo(String dteDateTo)
        {
            this.dteDateTo = dteDateTo;
        }

        public void setStreet(String strStreet)
        {
            this.strStreet = strStreet;
        }

        public void setTown(String strTown)
        {
            this.strTown = strTown;
        }
        public void setCounty(String strCounty)
        {
            this.strCounty = strCounty;
        }

        public void setMobileNo(String strMobileNo)
        {
            this.strMobileNo = strMobileNo;
        }

        public void setCost(double dblCost)
        {
            this.dblCost = dblCost;
        }

        public void setCheckedIn(String strCheckedIn)
        {
            this.strCheckedIn = strCheckedIn;
        }

        //Get Next Available BookingNo
        public int getAvailableBookingNo()
        {
            int intBookingNo;

            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            //Define SQL query
            String strSQL = "SELECT MAX(BookingNo) FROM Bookings";

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //read the record in dr
            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();


            if (dr.IsDBNull(0))
                intBookingNo = 1;
            else
                intBookingNo = Convert.ToInt16(dr.GetValue(0)) + 1;


            //Close DB connection
            myConn.Close();


            //return the nextRate
            return intBookingNo;



        }

        public void insBooking()
        {
            //Create database connection string
         
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Define SQL query
            String strSQL = "INSERT INTO Bookings VALUES (" + intBookingNo + "," +  intKennelNo + "," +
                                                                "'" + strSurname + "'," + "'" + strForename + "'," +
                                                                "'" + dteDateFrom + "'," + "'" + dteDateTo + "'," + 
                                                                "'" + strStreet + "'," + "'" + strTown + "'," +
                                                                "'" + strCounty + "'," + "'" + strMobileNo + "', " +
                                                                dblCost + ", " + "'No')";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();
           
            //execute
            cmd.ExecuteNonQuery();
            

            //Close DB connectopn
            myConn.Close();



        }

        public void Checkout (int bookingNum)
        {
            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Define SQL query
            String strSQL = "UPDATE Bookings SET CheckedIn = 'NO' WHERE BookingNo = " + bookingNum;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            myConn.Close();
        }

    }
}
