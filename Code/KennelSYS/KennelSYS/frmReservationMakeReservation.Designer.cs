namespace KennelSYS
{
    partial class frmReservationsMakeReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationsMakeReservation));
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfArrival = new System.Windows.Forms.Label();
            this.lblDateOfDeparture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.picMobNoError = new System.Windows.Forms.PictureBox();
            this.picCountyError = new System.Windows.Forms.PictureBox();
            this.picTownError = new System.Windows.Forms.PictureBox();
            this.picStreetError = new System.Windows.Forms.PictureBox();
            this.picSurnameError = new System.Windows.Forms.PictureBox();
            this.picForenameError = new System.Windows.Forms.PictureBox();
            this.lblKennelNo = new System.Windows.Forms.Label();
            this.txtKennelNo = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.btnSubmitCustDetails = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.grpType.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMobNoError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCountyError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTownError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStreetError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSurnameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForenameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblBookingNo.Location = new System.Drawing.Point(196, 106);
            this.lblBookingNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(85, 17);
            this.lblBookingNo.TabIndex = 40;
            this.lblBookingNo.Text = "Booking No:";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.btnConfirm);
            this.grpType.Controls.Add(this.dtpDeparture);
            this.grpType.Controls.Add(this.dtpArrival);
            this.grpType.Controls.Add(this.lblDateOfArrival);
            this.grpType.Controls.Add(this.lblDateOfDeparture);
            this.grpType.Controls.Add(this.label1);
            this.grpType.Controls.Add(this.cboType);
            this.grpType.Location = new System.Drawing.Point(69, 150);
            this.grpType.Margin = new System.Windows.Forms.Padding(5);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(5);
            this.grpType.Size = new System.Drawing.Size(585, 248);
            this.grpType.TabIndex = 44;
            this.grpType.TabStop = false;
            this.grpType.Text = "Enter Requirements";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(246, 184);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(166, 35);
            this.btnConfirm.TabIndex = 48;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(246, 135);
            this.dtpDeparture.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDeparture.MinDate = new System.DateTime(2016, 2, 29, 0, 0, 0, 0);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(205, 23);
            this.dtpDeparture.TabIndex = 47;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Location = new System.Drawing.Point(246, 83);
            this.dtpArrival.Margin = new System.Windows.Forms.Padding(5);
            this.dtpArrival.MinDate = new System.DateTime(2016, 2, 29, 0, 0, 0, 0);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(205, 23);
            this.dtpArrival.TabIndex = 46;
            // 
            // lblDateOfArrival
            // 
            this.lblDateOfArrival.AutoSize = true;
            this.lblDateOfArrival.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateOfArrival.Location = new System.Drawing.Point(49, 88);
            this.lblDateOfArrival.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateOfArrival.Name = "lblDateOfArrival";
            this.lblDateOfArrival.Size = new System.Drawing.Size(105, 17);
            this.lblDateOfArrival.TabIndex = 44;
            this.lblDateOfArrival.Text = "Date Of Arrival:";
            // 
            // lblDateOfDeparture
            // 
            this.lblDateOfDeparture.AutoSize = true;
            this.lblDateOfDeparture.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateOfDeparture.Location = new System.Drawing.Point(22, 140);
            this.lblDateOfDeparture.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateOfDeparture.Name = "lblDateOfDeparture";
            this.lblDateOfDeparture.Size = new System.Drawing.Size(129, 17);
            this.lblDateOfDeparture.TabIndex = 45;
            this.lblDateOfDeparture.Text = "Date Of Departure:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Kennel Type:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(246, 31);
            this.cboType.Margin = new System.Windows.Forms.Padding(5);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(205, 25);
            this.cboType.TabIndex = 43;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblCost);
            this.grpCustomer.Controls.Add(this.txtCost);
            this.grpCustomer.Controls.Add(this.picMobNoError);
            this.grpCustomer.Controls.Add(this.picCountyError);
            this.grpCustomer.Controls.Add(this.picTownError);
            this.grpCustomer.Controls.Add(this.picStreetError);
            this.grpCustomer.Controls.Add(this.picSurnameError);
            this.grpCustomer.Controls.Add(this.picForenameError);
            this.grpCustomer.Controls.Add(this.lblKennelNo);
            this.grpCustomer.Controls.Add(this.txtKennelNo);
            this.grpCustomer.Controls.Add(this.txtMobileNo);
            this.grpCustomer.Controls.Add(this.lblMobileNo);
            this.grpCustomer.Controls.Add(this.txtCounty);
            this.grpCustomer.Controls.Add(this.lblCounty);
            this.grpCustomer.Controls.Add(this.txtTown);
            this.grpCustomer.Controls.Add(this.lblTown);
            this.grpCustomer.Controls.Add(this.txtStreet);
            this.grpCustomer.Controls.Add(this.lblStreet);
            this.grpCustomer.Controls.Add(this.txtSurname);
            this.grpCustomer.Controls.Add(this.txtForename);
            this.grpCustomer.Controls.Add(this.btnSubmitCustDetails);
            this.grpCustomer.Controls.Add(this.lblForename);
            this.grpCustomer.Controls.Add(this.lblSurname);
            this.grpCustomer.Location = new System.Drawing.Point(21, 408);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.grpCustomer.Size = new System.Drawing.Size(747, 316);
            this.grpCustomer.TabIndex = 45;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            this.grpCustomer.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.SystemColors.Control;
            this.lblCost.Location = new System.Drawing.Point(257, 66);
            this.lblCost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(40, 17);
            this.lblCost.TabIndex = 45;
            this.lblCost.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtCost.Enabled = false;
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(356, 63);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(91, 24);
            this.txtCost.TabIndex = 44;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picMobNoError
            // 
            this.picMobNoError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picMobNoError.Location = new System.Drawing.Point(321, 211);
            this.picMobNoError.Name = "picMobNoError";
            this.picMobNoError.Size = new System.Drawing.Size(36, 37);
            this.picMobNoError.TabIndex = 43;
            this.picMobNoError.TabStop = false;
            this.picMobNoError.Visible = false;
            // 
            // picCountyError
            // 
            this.picCountyError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picCountyError.Location = new System.Drawing.Point(677, 216);
            this.picCountyError.Name = "picCountyError";
            this.picCountyError.Size = new System.Drawing.Size(36, 37);
            this.picCountyError.TabIndex = 42;
            this.picCountyError.TabStop = false;
            this.picCountyError.Visible = false;
            // 
            // picTownError
            // 
            this.picTownError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picTownError.Location = new System.Drawing.Point(677, 165);
            this.picTownError.Name = "picTownError";
            this.picTownError.Size = new System.Drawing.Size(36, 37);
            this.picTownError.TabIndex = 41;
            this.picTownError.TabStop = false;
            this.picTownError.Visible = false;
            // 
            // picStreetError
            // 
            this.picStreetError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picStreetError.Location = new System.Drawing.Point(677, 119);
            this.picStreetError.Name = "picStreetError";
            this.picStreetError.Size = new System.Drawing.Size(36, 37);
            this.picStreetError.TabIndex = 40;
            this.picStreetError.TabStop = false;
            this.picStreetError.Visible = false;
            // 
            // picSurnameError
            // 
            this.picSurnameError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picSurnameError.Location = new System.Drawing.Point(321, 165);
            this.picSurnameError.Name = "picSurnameError";
            this.picSurnameError.Size = new System.Drawing.Size(36, 37);
            this.picSurnameError.TabIndex = 39;
            this.picSurnameError.TabStop = false;
            this.picSurnameError.Visible = false;
            // 
            // picForenameError
            // 
            this.picForenameError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picForenameError.Location = new System.Drawing.Point(321, 122);
            this.picForenameError.Name = "picForenameError";
            this.picForenameError.Size = new System.Drawing.Size(36, 37);
            this.picForenameError.TabIndex = 38;
            this.picForenameError.TabStop = false;
            this.picForenameError.Visible = false;
            // 
            // lblKennelNo
            // 
            this.lblKennelNo.AutoSize = true;
            this.lblKennelNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblKennelNo.Location = new System.Drawing.Point(259, 30);
            this.lblKennelNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKennelNo.Name = "lblKennelNo";
            this.lblKennelNo.Size = new System.Drawing.Size(78, 17);
            this.lblKennelNo.TabIndex = 37;
            this.lblKennelNo.Text = "Kennel No:";
            // 
            // txtKennelNo
            // 
            this.txtKennelNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtKennelNo.Enabled = false;
            this.txtKennelNo.Location = new System.Drawing.Point(355, 24);
            this.txtKennelNo.Name = "txtKennelNo";
            this.txtKennelNo.Size = new System.Drawing.Size(44, 23);
            this.txtKennelNo.TabIndex = 36;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(115, 216);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(107, 23);
            this.txtMobileNo.TabIndex = 35;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblMobileNo.Location = new System.Drawing.Point(30, 219);
            this.lblMobileNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(75, 17);
            this.lblMobileNo.TabIndex = 34;
            this.lblMobileNo.Text = "Mobile No:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(473, 214);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(5);
            this.txtCounty.MaxLength = 20;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(186, 23);
            this.txtCounty.TabIndex = 33;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.BackColor = System.Drawing.SystemColors.Control;
            this.lblCounty.Location = new System.Drawing.Point(394, 211);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(56, 17);
            this.lblCounty.TabIndex = 32;
            this.lblCounty.Text = "County:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(473, 173);
            this.txtTown.Margin = new System.Windows.Forms.Padding(5);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(186, 23);
            this.txtTown.TabIndex = 31;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.BackColor = System.Drawing.SystemColors.Control;
            this.lblTown.Location = new System.Drawing.Point(404, 173);
            this.lblTown.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(46, 17);
            this.lblTown.TabIndex = 30;
            this.lblTown.Text = "Town:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(473, 126);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(5);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(186, 23);
            this.txtStreet.TabIndex = 29;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.SystemColors.Control;
            this.lblStreet.Location = new System.Drawing.Point(400, 129);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(50, 17);
            this.lblStreet.TabIndex = 28;
            this.lblStreet.Text = "Street:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(115, 173);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(186, 23);
            this.txtSurname.TabIndex = 27;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(115, 126);
            this.txtForename.Margin = new System.Windows.Forms.Padding(5);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(186, 23);
            this.txtForename.TabIndex = 26;
            // 
            // btnSubmitCustDetails
            // 
            this.btnSubmitCustDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSubmitCustDetails.Location = new System.Drawing.Point(321, 271);
            this.btnSubmitCustDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmitCustDetails.Name = "btnSubmitCustDetails";
            this.btnSubmitCustDetails.Size = new System.Drawing.Size(155, 35);
            this.btnSubmitCustDetails.TabIndex = 21;
            this.btnSubmitCustDetails.Text = "Submit";
            this.btnSubmitCustDetails.UseVisualStyleBackColor = false;
            this.btnSubmitCustDetails.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.BackColor = System.Drawing.SystemColors.Control;
            this.lblForename.Location = new System.Drawing.Point(22, 129);
            this.lblForename.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(76, 17);
            this.lblForename.TabIndex = 24;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.SystemColors.Control;
            this.lblSurname.Location = new System.Drawing.Point(29, 176);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 25;
            this.lblSurname.Text = "Surname:";
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.Enabled = false;
            this.txtBookingNo.Location = new System.Drawing.Point(314, 102);
            this.txtBookingNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.ReadOnly = true;
            this.txtBookingNo.Size = new System.Drawing.Size(44, 23);
            this.txtBookingNo.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(120, 30, 590, 40);
            this.label2.Size = new System.Drawing.Size(815, 87);
            this.label2.TabIndex = 47;
            this.label2.Text = "Make Booking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(673, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(79, 69);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmReservationsMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(828, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblBookingNo);
            this.Controls.Add(this.txtBookingNo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReservationsMakeReservation";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - Make Booking";
            this.Load += new System.EventHandler(this.frmReservationsMakeReservation_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMobNoError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCountyError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTownError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStreetError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSurnameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForenameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingNo;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Button btnSubmitCustDetails;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtBookingNo;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.Label lblDateOfArrival;
        private System.Windows.Forms.Label lblDateOfDeparture;
        private System.Windows.Forms.TextBox txtKennelNo;
        private System.Windows.Forms.Label lblKennelNo;
        private System.Windows.Forms.PictureBox picMobNoError;
        private System.Windows.Forms.PictureBox picCountyError;
        private System.Windows.Forms.PictureBox picTownError;
        private System.Windows.Forms.PictureBox picStreetError;
        private System.Windows.Forms.PictureBox picSurnameError;
        private System.Windows.Forms.PictureBox picForenameError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
    }
}