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
    public partial class frmListKennelStatus : Form
    {
        frmMain parent;
        public frmListKennelStatus(frmMain Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }
        public frmListKennelStatus()
        {
            InitializeComponent();
        }


        //Occupied Radio Button Checked
        private void rdoOccupied_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOccupied.Checked == true)
            {
                grpOccupied.Visible = false;
                grpVacant.Visible = false;
                fillOccupiedGrid();
                grpOccupied.Visible = true;
                grpVacant.Visible = false;
            }          
        }

        //Vacant Radio Button Checked
        private void rdoVacant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVacant.Checked == true)
            {
                grpOccupied.Visible = false;
                grpVacant.Visible = false;
                fillVacantGrid();
                grpVacant.Visible = true;
                grpOccupied.Visible = false;
            }
        }

        //All Radio Button Checked
        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAll.Checked == true)
            {
                grpOccupied.Visible = false;
                grpVacant.Visible = false;
                fillOccupiedGrid();
                fillVacantGrid();
                grpOccupied.Visible = true;
                grpVacant.Visible = true;
            }
        }

        //Fill occcupied grid
       public void fillOccupiedGrid()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //Define SQL Query

            String strSQL = "SELECT Kennels.KennelNo, Kennels.Types, Bookings.DateFrom, Bookings.DateTo FROM Kennels INNER JOIN Bookings ON Kennels.KennelNo = Bookings.BookingNo WHERE KennelStatus = 'O' ORDER BY KennelNo";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdOccupied.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        } //emd fill occupied grid

        //Fill vacant grid
        public void fillVacantGrid()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //Define SQL Query

            String strSQL = "SELECT KennelNo, Types FROM Kennels WHERE KennelStatus = 'A' ORDER BY KennelNo";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdVacant.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        } // end fill vacant grid


        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void frmListKennelStatus_Load(object sender, EventArgs e)
        {

        }

        private void grdOccupied_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
