namespace KennelSYS
{
    partial class frmListDailyDepartures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDailyDepartures));
            this.lblDateOfDeparture = new System.Windows.Forms.Label();
            this.grpDeparture = new System.Windows.Forms.GroupBox();
            this.grdDepartures = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDialog3 = new System.Windows.Forms.PrintDialog();
            this.printDialog4 = new System.Windows.Forms.PrintDialog();
            this.printDialog5 = new System.Windows.Forms.PrintDialog();
            this.printDialog6 = new System.Windows.Forms.PrintDialog();
            this.dtpDepartDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDepart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDeparture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateOfDeparture
            // 
            this.lblDateOfDeparture.AutoSize = true;
            this.lblDateOfDeparture.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateOfDeparture.Location = new System.Drawing.Point(62, 116);
            this.lblDateOfDeparture.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateOfDeparture.Name = "lblDateOfDeparture";
            this.lblDateOfDeparture.Size = new System.Drawing.Size(129, 17);
            this.lblDateOfDeparture.TabIndex = 25;
            this.lblDateOfDeparture.Text = "Date Of Departure:";
            // 
            // grpDeparture
            // 
            this.grpDeparture.Controls.Add(this.grdDepartures);
            this.grpDeparture.Location = new System.Drawing.Point(65, 228);
            this.grpDeparture.Margin = new System.Windows.Forms.Padding(5);
            this.grpDeparture.Name = "grpDeparture";
            this.grpDeparture.Padding = new System.Windows.Forms.Padding(5);
            this.grpDeparture.Size = new System.Drawing.Size(653, 261);
            this.grpDeparture.TabIndex = 46;
            this.grpDeparture.TabStop = false;
            this.grpDeparture.Text = "Departure Details";
            this.grpDeparture.Visible = false;
            // 
            // grdDepartures
            // 
            this.grdDepartures.AllowUserToAddRows = false;
            this.grdDepartures.AllowUserToDeleteRows = false;
            this.grdDepartures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartures.Location = new System.Drawing.Point(123, 38);
            this.grdDepartures.Name = "grdDepartures";
            this.grdDepartures.RowTemplate.Height = 24;
            this.grdDepartures.Size = new System.Drawing.Size(430, 189);
            this.grdDepartures.TabIndex = 0;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // printDialog3
            // 
            this.printDialog3.UseEXDialog = true;
            // 
            // printDialog4
            // 
            this.printDialog4.UseEXDialog = true;
            // 
            // printDialog5
            // 
            this.printDialog5.UseEXDialog = true;
            // 
            // printDialog6
            // 
            this.printDialog6.UseEXDialog = true;
            // 
            // dtpDepartDate
            // 
            this.dtpDepartDate.Location = new System.Drawing.Point(288, 116);
            this.dtpDepartDate.Name = "dtpDepartDate";
            this.dtpDepartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDepartDate.TabIndex = 49;
            // 
            // btnSearchDepart
            // 
            this.btnSearchDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchDepart.Location = new System.Drawing.Point(288, 167);
            this.btnSearchDepart.Name = "btnSearchDepart";
            this.btnSearchDepart.Size = new System.Drawing.Size(200, 35);
            this.btnSearchDepart.TabIndex = 50;
            this.btnSearchDepart.Text = "Search Departures";
            this.btnSearchDepart.UseVisualStyleBackColor = false;
            this.btnSearchDepart.Click += new System.EventHandler(this.btnSearchDepart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(120, 30, 500, 40);
            this.label2.Size = new System.Drawing.Size(775, 87);
            this.label2.TabIndex = 59;
            this.label2.Text = "List Daily Departures";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(644, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 69);
            this.btnHome.TabIndex = 48;
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
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // frmListDailyDepartures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 612);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchDepart);
            this.Controls.Add(this.dtpDepartDate);
            this.Controls.Add(this.grpDeparture);
            this.Controls.Add(this.lblDateOfDeparture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListDailyDepartures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - List Daily Departures";
            this.grpDeparture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateOfDeparture;
        private System.Windows.Forms.GroupBox grpDeparture;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.PrintDialog printDialog3;
        private System.Windows.Forms.PrintDialog printDialog4;
        private System.Windows.Forms.PrintDialog printDialog5;
        private System.Windows.Forms.PrintDialog printDialog6;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView grdDepartures;
        private System.Windows.Forms.DateTimePicker dtpDepartDate;
        private System.Windows.Forms.Button btnSearchDepart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}