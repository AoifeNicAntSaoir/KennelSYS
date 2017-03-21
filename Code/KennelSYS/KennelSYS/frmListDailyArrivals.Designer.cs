namespace KennelSYS
{
    partial class frmListDailyArrivals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDailyArrivals));
            this.printDialog4 = new System.Windows.Forms.PrintDialog();
            this.printDialog3 = new System.Windows.Forms.PrintDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDialog6 = new System.Windows.Forms.PrintDialog();
            this.grpArrivals = new System.Windows.Forms.GroupBox();
            this.grdArrivals = new System.Windows.Forms.DataGridView();
            this.lblDateOfArrival = new System.Windows.Forms.Label();
            this.dtpArrDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchArrivals = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpArrivals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArrivals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog4
            // 
            this.printDialog4.UseEXDialog = true;
            // 
            // printDialog3
            // 
            this.printDialog3.UseEXDialog = true;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // printDialog6
            // 
            this.printDialog6.UseEXDialog = true;
            // 
            // grpArrivals
            // 
            this.grpArrivals.Controls.Add(this.grdArrivals);
            this.grpArrivals.Location = new System.Drawing.Point(29, 231);
            this.grpArrivals.Margin = new System.Windows.Forms.Padding(5);
            this.grpArrivals.Name = "grpArrivals";
            this.grpArrivals.Padding = new System.Windows.Forms.Padding(5);
            this.grpArrivals.Size = new System.Drawing.Size(636, 304);
            this.grpArrivals.TabIndex = 51;
            this.grpArrivals.TabStop = false;
            this.grpArrivals.Text = "Arrival Details:";
            this.grpArrivals.Visible = false;
            // 
            // grdArrivals
            // 
            this.grdArrivals.AllowUserToAddRows = false;
            this.grdArrivals.AllowUserToDeleteRows = false;
            this.grdArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArrivals.Location = new System.Drawing.Point(54, 38);
            this.grdArrivals.Name = "grdArrivals";
            this.grdArrivals.RowTemplate.Height = 24;
            this.grdArrivals.Size = new System.Drawing.Size(541, 205);
            this.grdArrivals.TabIndex = 55;
            // 
            // lblDateOfArrival
            // 
            this.lblDateOfArrival.AutoSize = true;
            this.lblDateOfArrival.BackColor = System.Drawing.SystemColors.Control;
            this.lblDateOfArrival.Location = new System.Drawing.Point(37, 123);
            this.lblDateOfArrival.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateOfArrival.Name = "lblDateOfArrival";
            this.lblDateOfArrival.Size = new System.Drawing.Size(105, 17);
            this.lblDateOfArrival.TabIndex = 49;
            this.lblDateOfArrival.Text = "Date Of Arrival:";
            // 
            // dtpArrDate
            // 
            this.dtpArrDate.Location = new System.Drawing.Point(274, 123);
            this.dtpArrDate.Name = "dtpArrDate";
            this.dtpArrDate.Size = new System.Drawing.Size(200, 23);
            this.dtpArrDate.TabIndex = 54;
            // 
            // btnSearchArrivals
            // 
            this.btnSearchArrivals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchArrivals.Location = new System.Drawing.Point(265, 182);
            this.btnSearchArrivals.Name = "btnSearchArrivals";
            this.btnSearchArrivals.Size = new System.Drawing.Size(209, 41);
            this.btnSearchArrivals.TabIndex = 55;
            this.btnSearchArrivals.Text = "Search Arrivals";
            this.btnSearchArrivals.UseVisualStyleBackColor = false;
            this.btnSearchArrivals.Click += new System.EventHandler(this.btnSearchArrivals_Click);
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
            this.label2.Size = new System.Drawing.Size(748, 87);
            this.label2.TabIndex = 57;
            this.label2.Text = "List Daily Arrivals";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(628, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 69);
            this.btnHome.TabIndex = 53;
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
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // frmListDailyArrivals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 589);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchArrivals);
            this.Controls.Add(this.dtpArrDate);
            this.Controls.Add(this.grpArrivals);
            this.Controls.Add(this.lblDateOfArrival);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListDailyArrivals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - List Daily Arrivals";
            this.Load += new System.EventHandler(this.frmListDailyArrivals_Load);
            this.grpArrivals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdArrivals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog4;
        private System.Windows.Forms.PrintDialog printDialog3;
        private System.Windows.Forms.PrintDialog printDialog2;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintDialog printDialog6;
        private System.Windows.Forms.GroupBox grpArrivals;
        private System.Windows.Forms.Label lblDateOfArrival;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DateTimePicker dtpArrDate;
        private System.Windows.Forms.DataGridView grdArrivals;
        private System.Windows.Forms.Button btnSearchArrivals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}