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
    public partial class frmReservationCheckInClient : Form
    {
        Booking b1 = new Booking();
        frmMain parent;
        public frmReservationCheckInClient(frmMain Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }
        public frmReservationCheckInClient()
        {
            InitializeComponent();
        }

        //Home Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }


        //FillGrid in From Load
        private void frmReservationCheckInClient_Load(object sender, EventArgs e)
        {
            
            fillGrid();
        }

 
        //FillGridMethod - Gets all bookings where CheckedIn = no
        public void fillGrid()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Bookings WHERE CheckedIn = 'No' AND DateFrom LIKE '" + DateTime.Now.ToString("dd-MMM-yy").ToUpper() + "' "; 

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;

            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdBookings.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }
       
        //Fills Grid with a specific name searched
        public void fillGridNameSearched(String sortOrder)
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            //OracleConnection myConn = new OracleConnection(DBConnect.oradbHome);

            //Open DB
            myConn.Open();

            //InstantiateVariables
            b1.setSurname(txtEntSurname.Text);

            //Define SQL Query
            String strSQL = "SELECT * FROM Bookings WHERE Surname LIKE '" + txtEntSurname.Text + "%' AND CheckedIn = 'No' AND DateFrom LIKE '" + DateTime.Now.ToString("dd-MMM-yy").ToUpper() + "' ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdBookings.DataSource = ds.Tables["K"];
        }//End fill grid with name searched

        
        //Find Name on button clicked handler
        private void btnFindName_Click(object sender, EventArgs e)
        {
        //Validation
            //if surname text box is empty
            if(txtEntSurname.Text == "")
            {
                MessageBox.Show("Enter a surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEntSurname.Focus();
                return;
            }

            //Fill Grid with surname searched
            fillGridNameSearched(this.txtEntSurname.Text);
        } // end btnFindName_Click Method

       
        //CheckInMethod - updates booking by setting checkedIn from no to yes
        public void checkIn(int intSelBookingNo)
        {
            //Create database connection string
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
            
            //Define SQL query
            String strSQL = "UPDATE Bookings SET checkedIn='Yes' WHERE BookingNo = " + intSelBookingNo;

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //execute
            cmd.ExecuteNonQuery();

            //Close DB connectopn
            myConn.Close();
        }//end checkIn()

        //CheckInClient button from selected row on table
        private void btnCheckInClient_Click(object sender, EventArgs e)
        {
            if (grdBookings.SelectedCells.Count > 0)
            {
                int selectedrowindex = grdBookings.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = grdBookings.Rows[selectedrowindex];

                //Get selected cells from row selected
                string strSelSurname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                string strSelForename = Convert.ToString(selectedRow.Cells["Forename"].Value);
                string strSelBookingNo = Convert.ToString(selectedRow.Cells["BookingNo"].Value);
                string strSelKennelNo = Convert.ToString(selectedRow.Cells["KennelNo"].Value);
                string strSelCost = Convert.ToString(selectedRow.Cells["Cost"].Value);
                
                //Set Message & trims() whitespace             
                String strMessage = "Surname: " + "\t\t" + strSelSurname.Trim() + 
                                    "\nForename: " + "\t" + strSelForename.Trim() + 
                                    "\nBooking No: " + "\t" + strSelBookingNo.Trim() + 
                                    "\nKennel No: " + "\t" + strSelKennelNo.Trim() + 
                                    "\n\nCost: " + "\t\t" + "€" + strSelCost.Trim();

                //YesNoDialog
                DialogResult dialogResult = MessageBox.Show(strMessage, "Check In Details", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    //Yes Option
                    if(dialogResult == DialogResult.Yes)
                    {
                        int intSelBookingNo = Convert.ToInt32(strSelBookingNo);

                        try {
                            checkIn(intSelBookingNo);
                            String mess1 = strSelForename.Trim() + " " + strSelSurname.Trim() + " is now checked in";
                            MessageBox.Show(mess1,"Check In Confirmation",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            txtEntSurname.Text = "";
                            }
                        catch(Exception)
                            {
                            MessageBox.Show("Error occurred, Sorry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }//End if - yes option
                 //No Option
                else if(dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    return;
                }
  
            }//End if grdBookings.Selected > 0
        }//End check in client button clicked


        //Reset button clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            fillGrid();
            txtEntSurname.Text = "";
        }//end reset button clicked


    }
}
