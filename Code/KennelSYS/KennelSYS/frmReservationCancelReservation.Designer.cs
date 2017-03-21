namespace KennelSYS
{
    partial class frmReservationCancelReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationCancelReservation));
            this.lblEntSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.grpCancel = new System.Windows.Forms.GroupBox();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lblSelName = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.txtBookingNo = new System.Windows.Forms.TextBox();
            this.btnSearchBookingNo = new System.Windows.Forms.Button();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoBookingNo = new System.Windows.Forms.RadioButton();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.grpBookingNo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCancel.SuspendLayout();
            this.grpName.SuspendLayout();
            this.grpBookingNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntSurname
            // 
            this.lblEntSurname.AutoSize = true;
            this.lblEntSurname.Location = new System.Drawing.Point(8, 30);
            this.lblEntSurname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEntSurname.Name = "lblEntSurname";
            this.lblEntSurname.Size = new System.Drawing.Size(107, 17);
            this.lblEntSurname.TabIndex = 0;
            this.lblEntSurname.Text = "Enter Surname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(144, 27);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(164, 23);
            this.txtSurname.TabIndex = 1;
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchName.Location = new System.Drawing.Point(88, 113);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(168, 31);
            this.btnSearchName.TabIndex = 12;
            this.btnSearchName.Text = "Search by Name";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click_1);
            // 
            // grpCancel
            // 
            this.grpCancel.Controls.Add(this.btnCancelBooking);
            this.grpCancel.Controls.Add(this.cboName);
            this.grpCancel.Controls.Add(this.lblSelName);
            this.grpCancel.Location = new System.Drawing.Point(37, 353);
            this.grpCancel.Margin = new System.Windows.Forms.Padding(5);
            this.grpCancel.Name = "grpCancel";
            this.grpCancel.Padding = new System.Windows.Forms.Padding(5);
            this.grpCancel.Size = new System.Drawing.Size(546, 202);
            this.grpCancel.TabIndex = 45;
            this.grpCancel.TabStop = false;
            this.grpCancel.Text = "Name to cancel booking";
            this.grpCancel.Visible = false;
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelBooking.Location = new System.Drawing.Point(213, 124);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(205, 41);
            this.btnCancelBooking.TabIndex = 45;
            this.btnCancelBooking.Text = "Cancel Booking Now";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(186, 51);
            this.cboName.Margin = new System.Windows.Forms.Padding(5);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(205, 25);
            this.cboName.TabIndex = 44;
            // 
            // lblSelName
            // 
            this.lblSelName.AutoSize = true;
            this.lblSelName.Location = new System.Drawing.Point(10, 51);
            this.lblSelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelName.Name = "lblSelName";
            this.lblSelName.Size = new System.Drawing.Size(122, 17);
            this.lblSelName.TabIndex = 14;
            this.lblSelName.Text = "Select your name:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(144, 68);
            this.txtForename.Margin = new System.Windows.Forms.Padding(5);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(164, 23);
            this.txtForename.TabIndex = 1;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(8, 74);
            this.lblForename.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(110, 17);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Enter Forename";
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Location = new System.Drawing.Point(22, 23);
            this.lblBookingNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(123, 17);
            this.lblBookingNo.TabIndex = 0;
            this.lblBookingNo.Text = "Enter Booking No:";
            // 
            // txtBookingNo
            // 
            this.txtBookingNo.Location = new System.Drawing.Point(25, 55);
            this.txtBookingNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtBookingNo.MaxLength = 4;
            this.txtBookingNo.Name = "txtBookingNo";
            this.txtBookingNo.Size = new System.Drawing.Size(105, 23);
            this.txtBookingNo.TabIndex = 1;
            // 
            // btnSearchBookingNo
            // 
            this.btnSearchBookingNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchBookingNo.Location = new System.Drawing.Point(25, 113);
            this.btnSearchBookingNo.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchBookingNo.Name = "btnSearchBookingNo";
            this.btnSearchBookingNo.Size = new System.Drawing.Size(192, 35);
            this.btnSearchBookingNo.TabIndex = 12;
            this.btnSearchBookingNo.Text = "Search Booking No";
            this.btnSearchBookingNo.UseVisualStyleBackColor = false;
            this.btnSearchBookingNo.Click += new System.EventHandler(this.btnSearchBookingNo_Click);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.BackColor = System.Drawing.Color.Transparent;
            this.rdoName.Checked = true;
            this.rdoName.Location = new System.Drawing.Point(37, 130);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(63, 21);
            this.rdoName.TabIndex = 47;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = false;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // rdoBookingNo
            // 
            this.rdoBookingNo.AutoSize = true;
            this.rdoBookingNo.Location = new System.Drawing.Point(422, 130);
            this.rdoBookingNo.Name = "rdoBookingNo";
            this.rdoBookingNo.Size = new System.Drawing.Size(99, 21);
            this.rdoBookingNo.TabIndex = 48;
            this.rdoBookingNo.TabStop = true;
            this.rdoBookingNo.Text = "Booking No";
            this.rdoBookingNo.UseVisualStyleBackColor = false;
            this.rdoBookingNo.CheckedChanged += new System.EventHandler(this.rdoBookingNo_CheckedChanged);
            // 
            // grpName
            // 
            this.grpName.BackColor = System.Drawing.Color.Transparent;
            this.grpName.Controls.Add(this.lblEntSurname);
            this.grpName.Controls.Add(this.lblForename);
            this.grpName.Controls.Add(this.txtSurname);
            this.grpName.Controls.Add(this.txtForename);
            this.grpName.Controls.Add(this.btnSearchName);
            this.grpName.Location = new System.Drawing.Point(37, 157);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(348, 164);
            this.grpName.TabIndex = 49;
            this.grpName.TabStop = false;
            // 
            // grpBookingNo
            // 
            this.grpBookingNo.Controls.Add(this.lblBookingNo);
            this.grpBookingNo.Controls.Add(this.txtBookingNo);
            this.grpBookingNo.Controls.Add(this.btnSearchBookingNo);
            this.grpBookingNo.Location = new System.Drawing.Point(422, 157);
            this.grpBookingNo.Name = "grpBookingNo";
            this.grpBookingNo.Size = new System.Drawing.Size(254, 164);
            this.grpBookingNo.TabIndex = 50;
            this.grpBookingNo.TabStop = false;
            this.grpBookingNo.Enter += new System.EventHandler(this.grpBookingNo_Enter);
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
            this.label2.Padding = new System.Windows.Forms.Padding(120, 30, 500, 40);
            this.label2.Size = new System.Drawing.Size(735, 87);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cancel Booking";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(637, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(84, 69);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KennelSYS.Properties.Resources.doghead;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservationCancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 650);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBookingNo);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.rdoBookingNo);
            this.Controls.Add(this.rdoName);
            this.Controls.Add(this.grpCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmReservationCancelReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - Cancel Booking";
            this.Load += new System.EventHandler(this.frmReservationCancelReservation_Load);
            this.grpCancel.ResumeLayout(false);
            this.grpCancel.PerformLayout();
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpBookingNo.ResumeLayout(false);
            this.grpBookingNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.GroupBox grpCancel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.TextBox txtBookingNo;
        private System.Windows.Forms.Button btnSearchBookingNo;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoBookingNo;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.GroupBox grpBookingNo;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lblSelName;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}