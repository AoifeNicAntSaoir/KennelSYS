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
    public partial class frmReservationsMakeReservation : Form
    {
        frmMain parent;
        Booking NewBooking = new Booking();
        KennelType BookingKennelType = new KennelType();
        frmTypeSet addTypes = new frmTypeSet();
        frmMain mainMenu = new frmMain();
        public frmReservationsMakeReservation(frmMain Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        public frmReservationsMakeReservation()
        {
            InitializeComponent();
        }
        
        //Fills KennelTypes from KennelTypes
        public void fillTypes()
        {
            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //Define SQL query
            String strSQL = "SELECT * From KennelTypes ORDER BY Rate";

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(strSQL, myConn);

            //DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            //read the record in dr
            myConn.Open();

            //DataReader to add to cbo
            OracleDataReader dr = cmd.ExecuteReader();
                //clear existing types so no duplicates
            cboType.Items.Clear();
            while (dr.Read())
            {
                cboType.Items.Add(dr.GetString(0) + " ");
            }

            //Close DB Connection
            myConn.Close();
        }//End fill types()


        //Gets an int -  kennel no where = type & there is no booking on dates selected
        public int getKennel(String type, DateTime dateFrom, DateTime dateTo)
        {
            //define return value
            int kennelNo = 0;

            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            //Define SQL query
            //ToShortDateString() - just returns the date in format 07/03/2016
            String strSQL = "SELECT KennelNo From Kennels WHERE Types = '" + cboType.Text.Substring(0, 2) + "' AND KennelNo NOT IN " +
                "(SELECT KennelNo FROM Bookings WHERE DateFrom >= '" + String.Format("{0:dd-MMM-yy}", dateFrom) + "' AND DateTo <= '" + String.Format("{0:dd-MMM-yy}", dateTo) + "' )";

            //Open DB Connection
            myConn.Open();

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Use DataReader
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
                kennelNo = dr.GetInt32(0);

            //Close DB Connection
            myConn.Close();

            //Returnrs int value
            return kennelNo;
        }//end getKennel()


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //on load - fills types into cbo
        private void frmReservationsMakeReservation_Load(object sender, EventArgs e)
        {
        //Fill Types into cbo
            try
            {
                fillTypes();
            }
            catch
            {
                DialogResult diaRes = MessageBox.Show("Error Retrieving Kennel Types. Add Kennel Types now?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (diaRes == DialogResult.Yes)
                {
                    addTypes.ShowDialog();
                    this.Close();
                }
                else if (diaRes == DialogResult.No)
                {
                    MessageBox.Show("Returning to Main Menu", "Returning Home...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainMenu.ShowDialog();
                    this.Hide();
                }
            }
           
            //Get Available Booking No
            try
            {
                int intBookingNoAsInt = NewBooking.getAvailableBookingNo();
                String strBookingNo = intBookingNoAsInt.ToString();
                txtBookingNo.Text = strBookingNo;
            }
            catch
            {
                MessageBox.Show("Error retrieving Booking No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Set Arrival Date value on dtp to today's date as a minimum
            dtpArrival.MinDate = DateTime.Today;
            // Set value on dtp to todays date as a minimum  Departure Date +1 day from today
            dtpDeparture.MinDate = dtpArrival.Value.AddDays(1);

        }//End frm load


        private void btnSubmit2_Click(object sender, EventArgs e)
        {
        //Validation
            //Forename empty
            if (txtForename.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Forename", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                picForenameError.Visible = true;
                return;
            }
            //Hides forename error img
            picForenameError.Visible = false;
            
            //Surname empty
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Surname", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                picSurnameError.Visible = true;
                return;
            }
            //Hides surname error img
            picSurnameError.Visible = false;

            //Street empty
            if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Street", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                picStreetError.Visible = true;
                return;
            }
            //Hides street error img
            picStreetError.Visible = false;

            //Town empty
            if (txtTown.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Town", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                picTownError.Visible = true;
                return;
            }
            //Hides town error img
            picTownError.Visible = false;

            //County Empty
            if (txtCounty.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a County", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                picCountyError.Visible = true;
                return;
            }
            //hides county error img
            picCountyError.Visible = false;

            //Mobile No Empty
            if (txtMobileNo.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Mobile No", "Field Empty",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileNo.Focus();
                picMobNoError.Visible = true;
                return;
            }
            //hides mobile no error img
            picMobNoError.Visible = false;

        //End Validation


            //Instantiate instance variables
            NewBooking.setBookingNo(Convert.ToInt32(txtBookingNo.Text));
            NewBooking.setKennelNo(Convert.ToInt32(txtKennelNo.Text));
            NewBooking.setSurname(txtSurname.Text);
            NewBooking.setForename(txtForename.Text);
            NewBooking.setDateFrom(dtpArrival.Text);
            NewBooking.setDateTo(dtpDeparture.Text);
            NewBooking.setStreet(txtStreet.Text);
            NewBooking.setTown(txtTown.Text);
            NewBooking.setCounty(txtCounty.Text);
            NewBooking.setMobileNo(txtMobileNo.Text);
            NewBooking.setCost(Convert.ToDouble(txtCost.Text));


            try
            {
                //Insert Booking into kennnel
                NewBooking.insBooking();
               
                //Display confirmation message
                MessageBox.Show("Reservation Made", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Booking was not made, Sorry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



         //Reset UI
            //Hide error imgs
            picForenameError.Visible = false;
            picSurnameError.Visible = false;
            picStreetError.Visible = false;
            picTownError.Visible = false;
            picCountyError.Visible = false;
            picMobNoError.Visible = false;
            //Empty Text Boxes
            txtSurname.Text = "";
            txtForename.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            txtMobileNo.Text = "";
            txtCost.Text = "";
            grpCustomer.Visible = false;
            //Get Next Available Booking No & add to 
            txtBookingNo.Text = NewBooking.getAvailableBookingNo().ToString();
            //Clear the combo box items and refill
            cboType.Items.Clear();
            fillTypes();
        }//End make booking button click handler


        //Click Home Button
        private void btnHome_Click(object sender, EventArgs e)
        { 
            parent.Visible = true;
            this.Close();
        }


        //Choosing Date of Arrival, date of departure and kennelType confirmation button
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validation
            //Unselected combo box
            if (cboType.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                cboType.Focus();
            }
            //DepDate < ArrDate
            if (dtpDeparture.Value < dtpArrival.Value)
            {
                MessageBox.Show("Departure date cannot be before the Arrival Date", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Cant book more than 30 days in advance
            if (dtpArrival.Value.Subtract(DateTime.Today).Days > 30)
            {
                MessageBox.Show("Cannot make a booking greater than 30 in advance", "Sorry",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //ArrDate > DepDate
            if (dtpArrival.Value > dtpDeparture.Value)
            {
                MessageBox.Show("Arrival Date cannot be greater than Departure Date", "Sorry",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            //Check if kennel is available for chosen type on dates specified
            txtKennelNo.Text = getKennel(cboType.Text.Substring(0, 2), dtpArrival.Value, dtpDeparture.Value).ToString();
            if (txtKennelNo.Text.Equals("0"))
            {
                MessageBox.Show("No Kennels of this type available for dates requested", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Calculate cost of booking
            KennelType kennelType = new KennelType();

            TimeSpan ts = dtpDeparture.Value - dtpArrival.Value;
            int noDays = ts.Days;
            decimal rate = kennelType.getKennelRate(cboType.Text);

            txtCost.Text = (rate * noDays).ToString("000.00");
            
            //if available, get customer details
            grpCustomer.Visible = true;
        }//end confirm selection details method


    }
}
