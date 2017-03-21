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
    public partial class frmKennelNew : Form
    {
        Kennels NewKennel = new Kennels();
        KennelType NewKennelType = new KennelType();
        frmMain parent;
        frmTypeSet newType = new frmTypeSet();
        frmMain mainMenu = new frmMain();
 
        
        public frmKennelNew(frmMain Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }
        public frmKennelNew()
        {
            InitializeComponent();
        }

        //Fills Kennel Types into combo box
        public void fillTypes()
        {
            String strKennelTypes;

            //Create DB connection with OracleConnnection
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //Define SQL query
            String strSQL = "SELECT * From KennelTypes ORDER BY Rate";

            //Define the Oracle Command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(strSQL, myConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
            
            // Open Connection
            myConn.Open();
           
            //Data Reader to read DataSet
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboType.Items.Add(dr.GetString(0) + " " + dr.GetString(2));
            }

            //Close Database Connection
            myConn.Close();
        }//End Fill Types Method

        //Form Loads
        private void frmKennelNew_Load(object sender, EventArgs e)
        {
            //Resets combo box to unselected
            cboType.SelectedIndex = 0;

            //Gets Next Available KennelNo & puts it into text box
            try
            {
                int intKennelNoAsInt = NewKennel.getAvailableKennelNo();
                String strKennelNo = intKennelNoAsInt.ToString();
                txtKennelNo.Text = strKennelNo;
            }
            catch
            {
                MessageBox.Show("Could not fetch the Kennel No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Returning to main Menu...", "Returning Home", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDialog(mainMenu);
                this.Close();
             }//End getting kennelno

            //gets kennelTypes from **KENNELTYPES**
            try
            {
                //NewKennelType.getKennelTypes();   
                cboType.Items.Clear();
                fillTypes();  
            }
            catch
            {
                DialogResult diaRes = MessageBox.Show("Could not fetch the Kennel Types. Add a Kennel Type?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(diaRes == DialogResult.Yes)
                {
                    newType.ShowDialog();
                    this.Close();
                }
                else if(diaRes == DialogResult.No)
                {
                    MessageBox.Show("KennelSYS will now return to the Main Menu", "Returning Home...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowDialog(mainMenu);
                    this.Close();
                }
            }//end catch

            //adds kenneltypes to cbo
                 cboType.Items.Add(cboType.Text);

        }//End frm load

        //Add new button clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {     
                //instantiate instance variables
                NewKennel.setKennelNo(Convert.ToInt32(txtKennelNo.Text));
                NewKennel.setKennelStatus("A");
                NewKennel.setTypes(cboType.Text.Substring(0,2).ToString());
            
                //Adds a new kennel with status a
                NewKennel.addNewKennel();

                //Display confirmation message
                MessageBox.Show("New Kennel Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKennelNo.Text = NewKennel.getAvailableKennelNo().ToString();
                //reset UI
                //Get next available kennel No
                NewKennel.getAvailableKennelNo();
                cboType.SelectedIndex = -1;
            
                }//End try
            catch
            {
                MessageBox.Show("Error Adding New Kennel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//End catch
            


        }//End add new button click event handler



        //Home Button Clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }//End Home button clicked
            
        }
    }
