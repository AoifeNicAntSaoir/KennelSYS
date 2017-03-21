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
using System.Globalization;

namespace KennelSYS
{
    public partial class frmListKennelAnalysis : Form
    {
        frmMain parent;
        public frmListKennelAnalysis(frmMain Parent)
        {
            this.parent = Parent;
            InitializeComponent();

        }
        public frmListKennelAnalysis()
        {
            InitializeComponent();
        }

        //Form load
        private void frmListKennelAnalysis_Load(object sender, EventArgs e)
        {
            fillGrid();  
        }


        //FillGridMethod
        public void fillGrid()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //Open DB
            myConn.Open();

            //Define SQL Query
            String strSQL = "SELECT T.KennelType, T.Description, Count(B.Surname) AS NumBookings, Sum(B.cost) AS TotalRevenue FROM KennelTypes T, Kennels K, Bookings B WHERE  K.Types = T.KennelType AND K.KennelNo = B.KennelNo AND B.DATETO LIKE '%16' GROUP BY T.KennelType, T.Description ";

            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;


            //Execute Query using Data Adapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "K");
            grdKennelAnalysis.DataSource = ds.Tables["K"];

            //Close DB
            //myConn.Close();
        }//End Fill Grid method

      
        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

    }
}
