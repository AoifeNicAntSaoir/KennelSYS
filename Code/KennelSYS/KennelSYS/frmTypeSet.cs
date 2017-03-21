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
    public partial class frmTypeSet : Form
    {
        frmMain parent;     //Home Button
        KennelType newKennelType = new KennelType();

       
        public frmTypeSet(frmMain Parent)
        {
            InitializeComponent();
            parent = Parent;

        }
        public frmTypeSet()
        {
            InitializeComponent();

        }

        //SetType Button Click Handler
        private void btnSet_Click(object sender, EventArgs e)
        {
    //Validation

            //TextBox Type Empty - Displays Message, Focuses on Type text box, displays error icon next to text box and returns
            if (txtType.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Type", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                picErrorType.Visible = true;
                return;
            }
            //Hides Error icon once past Type text box
            picErrorType.Visible = false;
           
            //Description empty - Displays Message, Focuses on Type text box, displays error icon next to text box and returns
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Description", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                picDescError.Visible = true;
                return;
            }
           //Hides Error icon once past Description text box
            picDescError.Visible = false;
            
            //Rate empty - - Displays Message, Focuses on Type text box, displays error icon next to text box and returns
            if (txtRate.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a Rate", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                picRateError.Visible = true;
                return;
            }
            //Rate Not numeric value
            Double parsedValue;
            if (!Double.TryParse(txtRate.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                picRateError.Visible = true;
                return;
            }
            //Rate less than 0
            if (parsedValue < 0)
            {
                MessageBox.Show("Number less than €0 is not valid", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                picRateError.Visible = true;
                return;
            }
            //Hides Error Icon once conditions met 
            picRateError.Visible = false;
       //End Validation



            //Instantiate instance variables with values from form controls
            newKennelType.setType(txtType.Text);
            newKennelType.setDescription(txtDescription.Text);
            newKennelType.setRate(Convert.ToDouble(txtRate.Text));
 
            
          //Insert Kennel Type
            try {
               //Method from KennelTypes Class
                newKennelType.insKennelType();
                //Display confiemation message
                MessageBox.Show("Kennel Type Set", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kennel Type not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        //End inserting new Kennel Type

        //Reset UI
            txtType.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "0.00";
            picErrorType.Visible = false;
            picRateError.Visible = false;
            picDescError.Visible = false;
            txtType.Focus();
        } //End SetType Button Click Handler


        //Home Button - Closes this form and opens frmMain- parent
        private void btnHome_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }//End Home Button

    }
}
