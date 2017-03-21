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
    public partial class frmListDailyArrivals : Form
    {
        frmMain parent;
        public frmListDailyArrivals(frmMain Parent)
        {
            this.parent = Parent;
            InitializeComponent();
        }
        public frmListDailyArrivals()
        {
            InitializeComponent();
        }
        
      //Form load
        private void frmListDailyArrivals_Load(object sender, EventArgs e)
        {
            //Set minimum date of dtp to today.
            dtpArrDate.MinDate = DateTime.Today;   
        }

        //Search Arrivals Button clicked
        private void btnSearchArrivals_Click(object sender, EventArgs e)
        {
            fillGrid();
            grpArrivals.Visible = true;
            grdArrivals.Visible = true;
        }

        //FillGrid with date selected
        public void fillGrid()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT BookingNo, KennelNo, Surname, Forename, DateTo AS DepartDate FROM Bookings WHERE DateFrom = '" + String.Format("{0:dd-MMM-yy}", dtpArrDate.Value) + "' AND CheckedIn = 'No' ORDER BY KennelNo";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdArrivals.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }//End fillGrid() method

        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        { 
            parent.Visible = true;
            this.Close();
        }

     
    }
}
