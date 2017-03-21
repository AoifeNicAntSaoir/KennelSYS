using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennelSYS
{
    public partial class frmMain : Form
    {
        frmMain parent;
        public frmMain()
        {
            InitializeComponent();
        }

       
        //Close on click
        //Kennels
        private void setKennelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmTypeSet frmTypeSet = new frmTypeSet(this);
            this.Hide();
            frmTypeSet.Show();
        }

        private void changeKennelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTypeChg frmTypeChange = new frmTypeChg(this);
            this.Hide();
            frmTypeChange.Show();
        }
        private void addANewKennelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKennelNew frmKennelNew = new frmKennelNew(this);
            this.Hide();
            frmKennelNew.Show();
        }
        
 //Reservation Menu
         private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationsMakeReservation frmReservationsMakeReservation = new frmReservationsMakeReservation(this);
            this.Hide();
            frmReservationsMakeReservation.Show();
        }
        private void cancelReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationCancelReservation frmReservationCancelReservation = new frmReservationCancelReservation(this);
            this.Hide();
            frmReservationCancelReservation.Show();
        }
        private void checkinClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationCheckInClient frmReservationCheckInClient = new frmReservationCheckInClient(this);
            this.Hide();
            frmReservationCheckInClient.Show();
        }
        private void checkoutClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservationCheckOutClient frmReservationCheckOutClient = new frmReservationCheckOutClient(this);
            this.Hide();
            frmReservationCheckOutClient.Show(); 
        }
 //Administration
        private void listDailyArrivalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDailyArrivals frmListDailyArrivals = new frmListDailyArrivals(this);
            this.Hide();
            frmListDailyArrivals.Show();
        }
        private void listDailyDeparturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDailyDepartures frmListDailyDepartures = new frmListDailyDepartures(this);
            this.Hide();
            frmListDailyDepartures.Show();
        }
        private void listRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListRevenueAnalysis frmListRevenueAnalysis = new frmListRevenueAnalysis(this);
            this.Hide();
            frmListRevenueAnalysis.Show();
        }
        private void listKennelAnalysisReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListKennelAnalysis frmListKennelAnalysis = new frmListKennelAnalysis(this);
            this.Hide();
            frmListKennelAnalysis.Show();
         
        }
        private void mnuItemCurrentKennelStatus_Click(object sender, EventArgs e)
        {
            frmListKennelStatus frmListKennelStatus = new frmListKennelStatus(this);
            this.Hide();
            frmListKennelStatus.Show();

        }
        //Exit
        private void mnuExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

    }
}
