using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace KennelSYS
{
    public partial class frmListDailyDepartures : Form
    {
        frmMain parent;
        public frmListDailyDepartures(frmMain Parent)
        {
            this.parent = Parent;
            InitializeComponent();
        }
        public frmListDailyDepartures()
        {
            InitializeComponent();
        }

        //Fill Grid with date selected departures
        public void fillGrid()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT BookingNo, KennelNo, Surname, Forename FROM Bookings WHERE DateTo = '" + String.Format("{0:dd-MMM-yy}", dtpDepartDate.Value) + "' AND CheckedIn = 'No' ORDER BY KennelNo";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdDepartures.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }
     
        //Departure Button clicked
        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            fillGrid();
            grpDeparture.Visible = true;
        }

        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.Visible = true;
        }
    }
}
