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
    public partial class frmTypeChg : Form
    {
        frmMain parent;
        frmMain mainMenu = new frmMain();
        KennelType newKennelType = new KennelType();
        frmTypeSet newType = new frmTypeSet();

         public frmTypeChg(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;

        }
         public frmTypeChg()
        {
            InitializeComponent();

        }
      
        
        private void frmTypeChg_Load(object sender, EventArgs e)
        {
            fillTypes(); //Fill Types into cbo box on frm Load
        }


        //fillTypes Method
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
            DataSet ds = new DataSet();
            da.Fill(ds, "ss");
           

            //read the record in dr
            myConn.Open();

            //Clear existing items from combo box - so no duplicates
            cboType.Items.Clear();

            //Fill combobox using Data Reader
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboType.Items.Add(dr.GetString(0).PadRight(2,' ') + " " + dr.GetDecimal(1).ToString("000.00") + " " + dr.GetString(2));
            }
            
            //Close Connection
            myConn.Close();

        }//End fillTypes()

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Formats Text in cbo
            txtDescription.Text = cboType.Text.Substring(10, 30);
            txtRate.Text = cboType.Text.Substring(3, 6); 
            grpType.Visible = true;
        }


        //Change Type Details Button Clicked
        private void btnSet_Click(object sender, EventArgs e)
        {
         //Validation
            //Description Empty
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Description", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                picDescError.Visible = true;
                return;
            }
            //Hides Description Error pic
            picDescError.Visible = false;
            //Default Descrip Text
            if (txtDescription.Text.Equals("Enter a Description"))
            {
                String strMessage = "Are you sure you wish to add this default description?\n\n" + txtDescription.Text;
                DialogResult diaRes = MessageBox.Show(strMessage, "Is this Description ok?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (diaRes == DialogResult.No)
                {
                    txtDescription.Focus();
                    return;
                }
            }

            //Rate must be numeric
            decimal parsedValue;
            if (!decimal.TryParse(txtRate.Text, out parsedValue))
            {
                MessageBox.Show("This is a numeric only field", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                picRateError.Visible = true;
                return;
            }
            //Rate must be >0
            if (parsedValue <= 0)
            {
                MessageBox.Show("The rate must be greater than €0", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                picRateError.Visible = true;
                return;
            }
            //Rate empty
            if (txtRate.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Rate", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                picRateError.Visible = true;
                return;
            }
            picRateError.Visible = false;
           //End Validation



            //Instantiate instance variables with values from form controls
            newKennelType.setType(cboType.Text.Substring(0,2));
            newKennelType.setDescription(txtDescription.Text);
            newKennelType.setRate(Convert.ToDouble(txtRate.Text));

            try
            {
                //Update Kennels Type table
                newKennelType.updateKennelType();

                //Display confirmation message
                MessageBox.Show("Kennel Type Changed", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kennel Type was not changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Reset UI
                cboType.Items.Clear();
                fillTypes();
                picDescError.Visible = false;
                picRateError.Visible = false;
                cboType.SelectedIndex = 0;
                txtDescription.Text = "Enter a description";
                txtRate.Text = "Enter a rate";
            }
        }

        //Home Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }
    }
}
