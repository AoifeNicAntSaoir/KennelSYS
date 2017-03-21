namespace KennelSYS
{
    partial class frmReservationCheckInClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationCheckInClient));
            this.grpCheckIn = new System.Windows.Forms.GroupBox();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.btnCheckInClient = new System.Windows.Forms.Button();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.txtEntSurname = new System.Windows.Forms.TextBox();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCheckIn
            // 
            this.grpCheckIn.Controls.Add(this.grdBookings);
            this.grpCheckIn.Controls.Add(this.btnCheckInClient);
            this.grpCheckIn.Location = new System.Drawing.Point(34, 260);
            this.grpCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.grpCheckIn.Name = "grpCheckIn";
            this.grpCheckIn.Padding = new System.Windows.Forms.Padding(5);
            this.grpCheckIn.Size = new System.Drawing.Size(618, 292);
            this.grpCheckIn.TabIndex = 49;
            this.grpCheckIn.TabStop = false;
            this.grpCheckIn.Text = "Check In";
            // 
            // grdBookings
            // 
            this.grdBookings.AllowDrop = true;
            this.grdBookings.AllowUserToAddRows = false;
            this.grdBookings.AllowUserToDeleteRows = false;
            this.grdBookings.AllowUserToOrderColumns = true;
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdBookings.Location = new System.Drawing.Point(8, 38);
            this.grdBookings.MultiSelect = false;
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBookings.Size = new System.Drawing.Size(599, 150);
            this.grdBookings.TabIndex = 47;
            // 
            // btnCheckInClient
            // 
            this.btnCheckInClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCheckInClient.Location = new System.Drawing.Point(206, 234);
            this.btnCheckInClient.Margin = new System.Windows.Forms.Padding(5);
            this.btnCheckInClient.Name = "btnCheckInClient";
            this.btnCheckInClient.Size = new System.Drawing.Size(196, 35);
            this.btnCheckInClient.TabIndex = 46;
            this.btnCheckInClient.Text = "Check-In Client";
            this.btnCheckInClient.UseVisualStyleBackColor = false;
            this.btnCheckInClient.Click += new System.EventHandler(this.btnCheckInClient_Click);
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(59, 154);
            this.lblCheckIn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(126, 20);
            this.lblCheckIn.TabIndex = 46;
            this.lblCheckIn.Text = "Enter Surname:";
            // 
            // txtEntSurname
            // 
            this.txtEntSurname.Location = new System.Drawing.Point(239, 147);
            this.txtEntSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtEntSurname.MaxLength = 20;
            this.txtEntSurname.Name = "txtEntSurname";
            this.txtEntSurname.Size = new System.Drawing.Size(164, 27);
            this.txtEntSurname.TabIndex = 47;
            // 
            // btnFindName
            // 
            this.btnFindName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFindName.Location = new System.Drawing.Point(239, 199);
            this.btnFindName.Margin = new System.Windows.Forms.Padding(5);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(119, 35);
            this.btnFindName.TabIndex = 48;
            this.btnFindName.Text = "Find Name";
            this.btnFindName.UseVisualStyleBackColor = false;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(386, 199);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 35);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.label2.Size = new System.Drawing.Size(763, 90);
            this.label2.TabIndex = 53;
            this.label2.Text = "Check-In Client";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(584, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(98, 65);
            this.btnHome.TabIndex = 50;
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
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservationCheckInClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 612);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpCheckIn);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.txtEntSurname);
            this.Controls.Add(this.lblCheckIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservationCheckInClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - Check-In Client";
            this.Load += new System.EventHandler(this.frmReservationCheckInClient_Load);
            this.grpCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCheckIn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCheckInClient;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.TextBox txtEntSurname;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}