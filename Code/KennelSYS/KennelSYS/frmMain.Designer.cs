namespace KennelSYS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuKennels = new System.Windows.Forms.ToolStripMenuItem();
            this.setKennelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeKennelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addANewKennelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservations = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.listDailyArrivalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDailyDeparturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listKennelAnalysisReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemCurrentKennelStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.BackColor = System.Drawing.Color.Transparent;
            this.mnu.GripMargin = new System.Windows.Forms.Padding(0);
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKennels,
            this.mnuReservations,
            this.mnuAdministration,
            this.mnuExit});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.MaximumSize = new System.Drawing.Size(781, 130);
            this.mnu.Name = "mnu";
            this.mnu.Padding = new System.Windows.Forms.Padding(0);
            this.mnu.Size = new System.Drawing.Size(781, 130);
            this.mnu.Stretch = false;
            this.mnu.TabIndex = 0;
            // 
            // mnuKennels
            // 
            this.mnuKennels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mnuKennels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuKennels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setKennelTypeToolStripMenuItem,
            this.changeKennelTypeToolStripMenuItem,
            this.addANewKennelToolStripMenuItem});
            this.mnuKennels.Font = new System.Drawing.Font("Verdana", 9F);
            this.mnuKennels.Name = "mnuKennels";
            this.mnuKennels.Padding = new System.Windows.Forms.Padding(100, 107, 0, 0);
            this.mnuKennels.Size = new System.Drawing.Size(168, 130);
            this.mnuKennels.Text = "Kennels";
            // 
            // setKennelTypeToolStripMenuItem
            // 
            this.setKennelTypeToolStripMenuItem.Name = "setKennelTypeToolStripMenuItem";
            this.setKennelTypeToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.setKennelTypeToolStripMenuItem.Text = "Set Kennel Type";
            this.setKennelTypeToolStripMenuItem.Click += new System.EventHandler(this.setKennelTypeToolStripMenuItem_Click);
            // 
            // changeKennelTypeToolStripMenuItem
            // 
            this.changeKennelTypeToolStripMenuItem.Name = "changeKennelTypeToolStripMenuItem";
            this.changeKennelTypeToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.changeKennelTypeToolStripMenuItem.Text = "Change Kennel Type";
            this.changeKennelTypeToolStripMenuItem.Click += new System.EventHandler(this.changeKennelTypeToolStripMenuItem_Click);
            // 
            // addANewKennelToolStripMenuItem
            // 
            this.addANewKennelToolStripMenuItem.Name = "addANewKennelToolStripMenuItem";
            this.addANewKennelToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.addANewKennelToolStripMenuItem.Text = "Add A New Kennel";
            this.addANewKennelToolStripMenuItem.Click += new System.EventHandler(this.addANewKennelToolStripMenuItem_Click);
            // 
            // mnuReservations
            // 
            this.mnuReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.mnuReservations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeReservationToolStripMenuItem,
            this.cancelReservationToolStripMenuItem,
            this.checkinClientToolStripMenuItem,
            this.checkoutClientToolStripMenuItem});
            this.mnuReservations.Font = new System.Drawing.Font("Verdana", 9F);
            this.mnuReservations.ForeColor = System.Drawing.Color.Black;
            this.mnuReservations.Name = "mnuReservations";
            this.mnuReservations.Padding = new System.Windows.Forms.Padding(100, 107, 0, 0);
            this.mnuReservations.Size = new System.Drawing.Size(208, 130);
            this.mnuReservations.Text = "Reservations";
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.makeReservationToolStripMenuItem.Text = "Make Booking";
            this.makeReservationToolStripMenuItem.Click += new System.EventHandler(this.makeReservationToolStripMenuItem_Click);
            // 
            // cancelReservationToolStripMenuItem
            // 
            this.cancelReservationToolStripMenuItem.Name = "cancelReservationToolStripMenuItem";
            this.cancelReservationToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.cancelReservationToolStripMenuItem.Text = "Cancel Booking";
            this.cancelReservationToolStripMenuItem.Click += new System.EventHandler(this.cancelReservationToolStripMenuItem_Click);
            // 
            // checkinClientToolStripMenuItem
            // 
            this.checkinClientToolStripMenuItem.Name = "checkinClientToolStripMenuItem";
            this.checkinClientToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.checkinClientToolStripMenuItem.Text = "Check-in client";
            this.checkinClientToolStripMenuItem.Click += new System.EventHandler(this.checkinClientToolStripMenuItem_Click);
            // 
            // checkoutClientToolStripMenuItem
            // 
            this.checkoutClientToolStripMenuItem.Name = "checkoutClientToolStripMenuItem";
            this.checkoutClientToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.checkoutClientToolStripMenuItem.Text = "Check-out client";
            this.checkoutClientToolStripMenuItem.Click += new System.EventHandler(this.checkoutClientToolStripMenuItem_Click);
            // 
            // mnuAdministration
            // 
            this.mnuAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.mnuAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listDailyArrivalsToolStripMenuItem,
            this.listDailyDeparturesToolStripMenuItem,
            this.listRevenueAnalysisToolStripMenuItem,
            this.listKennelAnalysisReportToolStripMenuItem,
            this.mnuItemCurrentKennelStatus});
            this.mnuAdministration.Name = "mnuAdministration";
            this.mnuAdministration.Padding = new System.Windows.Forms.Padding(100, 107, 0, 0);
            this.mnuAdministration.Size = new System.Drawing.Size(211, 130);
            this.mnuAdministration.Text = "Administration";
            // 
            // listDailyArrivalsToolStripMenuItem
            // 
            this.listDailyArrivalsToolStripMenuItem.Name = "listDailyArrivalsToolStripMenuItem";
            this.listDailyArrivalsToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.listDailyArrivalsToolStripMenuItem.Text = "List Daily Arrivals";
            this.listDailyArrivalsToolStripMenuItem.Click += new System.EventHandler(this.listDailyArrivalsToolStripMenuItem_Click);
            // 
            // listDailyDeparturesToolStripMenuItem
            // 
            this.listDailyDeparturesToolStripMenuItem.Name = "listDailyDeparturesToolStripMenuItem";
            this.listDailyDeparturesToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.listDailyDeparturesToolStripMenuItem.Text = "List Daily Departures";
            this.listDailyDeparturesToolStripMenuItem.Click += new System.EventHandler(this.listDailyDeparturesToolStripMenuItem_Click);
            // 
            // listRevenueAnalysisToolStripMenuItem
            // 
            this.listRevenueAnalysisToolStripMenuItem.Name = "listRevenueAnalysisToolStripMenuItem";
            this.listRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.listRevenueAnalysisToolStripMenuItem.Text = "List Revenue Analysis";
            this.listRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.listRevenueAnalysisToolStripMenuItem_Click);
            // 
            // listKennelAnalysisReportToolStripMenuItem
            // 
            this.listKennelAnalysisReportToolStripMenuItem.Name = "listKennelAnalysisReportToolStripMenuItem";
            this.listKennelAnalysisReportToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.listKennelAnalysisReportToolStripMenuItem.Text = "List Kennel Analysis Report";
            this.listKennelAnalysisReportToolStripMenuItem.Click += new System.EventHandler(this.listKennelAnalysisReportToolStripMenuItem_Click);
            // 
            // mnuItemCurrentKennelStatus
            // 
            this.mnuItemCurrentKennelStatus.Name = "mnuItemCurrentKennelStatus";
            this.mnuItemCurrentKennelStatus.Size = new System.Drawing.Size(261, 26);
            this.mnuItemCurrentKennelStatus.Text = "List Current Kennel Status";
            this.mnuItemCurrentKennelStatus.Click += new System.EventHandler(this.mnuItemCurrentKennelStatus_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.mnuExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.mnuExit.Size = new System.Drawing.Size(50, 130);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(128, 183);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(51, 20, 51, 420);
            this.lblHeader.Size = new System.Drawing.Size(487, 476);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Welcome to KennelSYS";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(183, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Professional,  reliable and safe kennel service";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::KennelSYS.Properties.Resources.doghead;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(205, 304);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 300);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(781, 722);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - Main Menu";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuKennels;
        private System.Windows.Forms.ToolStripMenuItem mnuReservations;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministration;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem setKennelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeKennelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addANewKennelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDailyArrivalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDailyDeparturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listKennelAnalysisReportToolStripMenuItem;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCurrentKennelStatus;
    }
}

