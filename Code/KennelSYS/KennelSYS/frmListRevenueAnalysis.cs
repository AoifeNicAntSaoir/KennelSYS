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
    public partial class frmListRevenueAnalysis : Form
    {
        frmMain parent;
        public frmListRevenueAnalysis(frmMain Parent)
        {
            this.parent = Parent;
            InitializeComponent();       
        }
        public frmListRevenueAnalysis()
        {
            InitializeComponent();
        }

        private void frmListRevenueAnalysis_Load(object sender, EventArgs e)
        {
            fillGrid();
        }


        private void fillGrid()
        {
            //Get selected Year
            int intSelectedYear = Convert.ToInt32(cboYear.SelectedItem.ToString().Substring(2, 2));
            
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);
           
            //Open DB
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT To_Char(DateFrom, 'mm') AS Month, SUM(cost) AS Revenue " +
                            "FROM Bookings " +
                            "WHERE To_Char(DateFrom, 'yy') LIKE'%" + intSelectedYear + "' AND " +
                                "To_Char(DateFrom, 'mm') LIKE '%01' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%02' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%03' OR " + 
                                "To_Char(DateFrom, 'mm') LIKE '%04' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%05' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%06' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%07' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%08' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%09' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%10' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%11' OR " +
                                "To_Char(DateFrom, 'mm') LIKE '%12' " +   
                            "GROUP BY To_Char(DateFrom, 'mm') " +
                            "ORDER BY To_Char(DateFrom, 'mm') ";
                         
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;

            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdRevAnalysis.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }//end fillGrid()

        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        //Cbo Year Changed
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblSelectedYear.Text = cboYear.SelectedItem.ToString();
            fillGrid();
            grpYearSel.Visible = true;
        }


    }
}
