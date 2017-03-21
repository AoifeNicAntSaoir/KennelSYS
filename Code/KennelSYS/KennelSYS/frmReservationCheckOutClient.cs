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
    public partial class frmReservationCheckOutClient : Form
    {
        frmMain parent;
        Booking b2 = new Booking();
        public frmReservationCheckOutClient(frmMain Parent)
        {
            this.parent = Parent;
            InitializeComponent();
        }
        public frmReservationCheckOutClient()
        {
            InitializeComponent();
        }
        
        //Check Out Button Clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //invoke method CheckOut on object
            if (grdCheckout.SelectedCells.Count > 0)
            {
                //Get selected row & items in cells 
                int selectedrowindex = grdCheckout.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = grdCheckout.Rows[selectedrowindex];

                string strSelSurname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                string strSelForename = Convert.ToString(selectedRow.Cells["Forename"].Value);
                string strSelBookingNo = Convert.ToString(selectedRow.Cells["BookingNo"].Value);
                string strSelArrivalDate = Convert.ToString(selectedRow.Cells["DateFrom"].Value);
                string strSelDepartureDate = Convert.ToString(selectedRow.Cells["DateTo"].Value);

                //Selected cells trimmed for message dialog
                String strMessage = "\tCheck Out: " +
                                    "\nSurname: " + "\t\t" + strSelSurname.Trim() +
                                    "\nForename: " + "\t" + strSelForename.Trim() +
                                    "\nBooking No: " + "\t" + strSelBookingNo.Trim() +
                                    "\nArrival Date: " + "\t" + strSelArrivalDate.Trim() +
                                    "\nDeparture Date: " + "\t" + strSelArrivalDate.Trim();
                
                //Dialog Message
                DialogResult answer = MessageBox.Show(strMessage, "Check Out This Client", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (answer == DialogResult.Yes)
                {
                    b2.Checkout(Convert.ToInt32(grdCheckout.Rows[grdCheckout.CurrentCell.RowIndex].Cells[0].Value));
                    String strCheckOutMessage = strSelForename.Trim() + " " + strSelSurname.Trim() + " is now checked out \n\n\tCome back again soon!";
                    MessageBox.Show(strCheckOutMessage, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //ResetUI
                txtEntSurname.Text = "";
                fillGrid("Surname");
            }
        }

        //Cancel Res Button clicked
        private void btnCancelReservationSubmit_Click(object sender, EventArgs e)
        {
        //Validation
            //Surname empty
            if (txtEntSurname.Text.Equals(""))
            {
                MessageBox.Show("Please enter a Surname", "Field Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEntSurname.Focus();
                return;
            }
            //Fill grid by name searched
            fillGridNameSearched(txtEntSurname.Text);
            grpCheckIn.Visible = true; 
        }

        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
           parent.Visible = true;
            this.Close();
        }

        //Form load - fill grid
        private void frmReservationCheckOutClient_Load(object sender, EventArgs e)
        {
            fillGrid("Surname");
        }

        //FillGridMethod
        public void fillGrid(String sortOrder)
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();


            String strToday = String.Format("{0:dd-MMM-yy}", DateTime.Today);

            //Define SQL Query
            String strSQL = "SELECT * FROM Bookings WHERE CheckedIn = 'Yes'  AND DateTo LIKE '" + DateTime.Now.ToString("dd-MMM-yy").ToUpper() + "' ";


            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdCheckout.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }

        //Fills Grid with checked in name searched
        public void fillGridNameSearched(String sortOrder)
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //InstantiateVariables
            b2.setSurname(txtEntSurname.Text);


            //Define SQL Query
            String strSQL = "SELECT * FROM Bookings WHERE Surname LIKE '" + txtEntSurname.Text + "%' AND CheckedIn = 'Yes' AND DateTo LIKE '" + DateTime.Now.ToString("dd-MMM-yy").ToUpper() + "' ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdCheckout.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }
        
        //Reset search
        private void btnReset_Click(object sender, EventArgs e)
        {
            fillGrid("Surname");
            txtEntSurname.Text = "";
        }

     

    }
}
