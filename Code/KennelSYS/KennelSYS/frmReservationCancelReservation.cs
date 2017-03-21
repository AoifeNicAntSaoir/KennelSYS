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
    public partial class frmReservationCancelReservation : Form
    {
        frmMain parent;
        public frmReservationCancelReservation(frmMain Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }
        public frmReservationCancelReservation()
        {
            InitializeComponent();
        }

        //Fills names into combo box BY NAMES SEARCHED
        public void fillNames()
        {
            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //Define SQL query
            String strSQL = "SELECT Surname,Forename From Bookings WHERE Surname LIKE " + "'" + txtSurname.Text + "%' OR Forename LIKE " + "'" + txtForename.Text + "%' ORDER BY Surname";
                                                                  
            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;
            
            //Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(strSQL, myConn);

            //DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            //Open DB Connection
            myConn.Open();

            //DataReader to add to combo box
            OracleDataReader dr = cmd.ExecuteReader();
         
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + "," + dr.GetString(1)); // + dr.GetString(2));
            }   
      
            //Close Connection
            myConn.Close();
        }//End fill Nmes

        //Search by name btn clicked
        private void btnSearchName_Click_1(object sender, EventArgs e)
        {
         //Validation
            //If Surname & Text is empty
            if (txtSurname.Text == "" && txtForename.Text == "")
            {
                MessageBox.Show("Please enter a surname or forename", "Field Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txtSurname.Text == "")
                {
                    txtSurname.Focus();
                }
                else if (txtForename.Text == "")
                {
                    txtForename.Focus();
                }
                return;
            }
        //End Validation

            //Clear cbo of already existing items
            cboName.Items.Clear();

            //Fill Cbo Box with this Booking No
            fillNames();
            grpCancel.Visible = true;
        }//End btn click handler


        //Fills name by booking no
        public void fillNamesBookingNo() 
        {
            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //Define SQL query
           String strSQL = "SELECT Surname,Forename From Bookings WHERE BookingNo= " + "'" + Convert.ToInt32(txtBookingNo.Text) + "'";

            //Clear preexisting items from cbo box
            cboName.Items.Clear();

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;

            //DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(strSQL, myConn);

            //DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            //Open DB Connection
            myConn.Open();

            //read the record in dr
            OracleDataReader dr = cmd.ExecuteReader();

            //Add items to combo box
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + " \t" + dr.GetString(1)); // + dr.GetString(2));
            }

           //Close DB Connection
            myConn.Close();
        }//End fill names by booking no



        //Search by booking no clicked
        private void btnSearchBookingNo_Click(object sender, EventArgs e)
        {
         //Validation
            //No Booking Num
            if(txtBookingNo.Text == "")
            {
                MessageBox.Show("Must enter Booking No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingNo.Focus();
                return;
            }
            //BookingNo Not a number
            Double dblBookingNo;
            if (!Double.TryParse(txtBookingNo.Text, out dblBookingNo))
            {
                MessageBox.Show("This is a number only field", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingNo.Focus();
                return;
            }

            if(dblBookingNo<0)
            {
                MessageBox.Show("Booking No cannot be less than 0","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingNo.Focus();
                txtBookingNo.Text = "";
                return;
            }
            if(dblBookingNo>9999)
            {
                MessageBox.Show("Booking No too large", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingNo.Focus();
                txtBookingNo.Text = "";
                return;
            }
        //End Validation
        
        //Shows up group box with table of bookings
            grpCancel.Visible = true;
      
       //Fills Names with booking no searched
            fillNamesBookingNo();
        }
      


        //Deletes a booking
        public void deleteBooking()
        {
            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //Define SQL query
            String strSQL = "DELETE FROM Bookings WHERE Surname = " + "'" + cboName.Text.Substring(0, 20) + "' AND Forename = " + "'" + cboName.Text.Substring(21, 20) + "'"; 

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(strSQL, myConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");

            //Open DB connection
            myConn.Open();
            
            //read the record in dr
            OracleDataReader dr = cmd.ExecuteReader();
            //Fill Cbo box
            while (dr.Read())
            {
                cboName.Items.Add(dr.GetString(0) + " "); 
            }
            
            //Close DB Connection
            myConn.Close();
        }//End deleteBooking()



        public String getDateOfArr()
        {
            String strArrDate;

            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
  
            //Define SQL query
            String strSQL = "SELECT DateFrom FROM Bookings WHERE Surname = " + "'" + cboName.Text.Substring(0, 20) + "' AND Forename = " + "'" + cboName.Text.Substring(21, 20) + "'"; //Was working before .Trim()

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB Connection
            myConn.Open();

            //read the record in dr
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            strArrDate = (dr.ToString());


            //Close DB connection
            myConn.Close();

            //return the KennelTypes
            return strArrDate;
        }//end getDateOfArr()


        //frm Load
        private void frmReservationCancelReservation_Load(object sender, EventArgs e)
        {
            //Gets Date Now
            String time = String.Format("{0:dd-MMM-yy}", DateTime.Now).Substring(0, 2);
            //Clears existing items in cbo
            cboName.Items.Clear();
            //sets bookingno grp to invisible by default
            grpBookingNo.Visible = false;
            //makes name visible by default
            grpName.Visible = true;
        }//end frm load


        //Home button clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
          parent.Visible = true;
            this.Close();
        }//End home button clicked


        //BookingNO Radio button checked
        private void rdoBookingNo_CheckedChanged(object sender, EventArgs e)
        {
            grpName.Visible = false;
            grpBookingNo.Visible = true;
        }

        //Name Radio Button checked
        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            //Resets UI part hidden
            txtBookingNo.Clear();
            grpBookingNo.Visible = false;
            grpName.Visible = true;
            grpCancel.Visible = false;
            txtSurname.Clear();
            txtForename.Clear();
            cboName.Items.Clear();
        }

        //Cancel Booking button clicked
        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
        //Validation - if name unselected from box
            if(cboName.SelectedIndex == -1)
            {
                MessageBox.Show("No names selected to cancel booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //gets date of arrival
            getDateOfArr();

           //get selected items for confirmation message
           String strSurnameTrimmed = cboName.SelectedItem.ToString().Substring(0,20).Trim();
            String strForenameTrimmed = cboName.SelectedItem.ToString().Substring(21, 20).Trim();
          
          //Confirmation Message
          DialogResult dialogResult = MessageBox.Show("Are you sure you wish to cancel this Booking: \n\t" + strForenameTrimmed + " " + strSurnameTrimmed,"Deletion Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //Deletes Booking
                deleteBooking();
                //Confirmation Mesage
                MessageBox.Show("Reservation has been cancelled", "Reservation Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                //Error Message & Returns
                MessageBox.Show("Reservation has not been cancelled", "Reservation Not Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtBookingNo.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
        }//End Cancel Button clicked method

        private void grpBookingNo_Enter(object sender, EventArgs e)
        {

        }
    }
}
