namespace KennelSYS
{
    partial class frmReservationCheckOutClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservationCheckOutClient));
            this.grpCheckIn = new System.Windows.Forms.GroupBox();
            this.grdCheckout = new System.Windows.Forms.DataGridView();
            this.lblSelName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelReservationSubmit = new System.Windows.Forms.Button();
            this.txtEntSurname = new System.Windows.Forms.TextBox();
            this.lblEntSurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCheckIn
            // 
            this.grpCheckIn.Controls.Add(this.grdCheckout);
            this.grpCheckIn.Controls.Add(this.lblSelName);
            this.grpCheckIn.Location = new System.Drawing.Point(40, 238);
            this.grpCheckIn.Margin = new System.Windows.Forms.Padding(5);
            this.grpCheckIn.Name = "grpCheckIn";
            this.grpCheckIn.Padding = new System.Windows.Forms.Padding(5);
            this.grpCheckIn.Size = new System.Drawing.Size(629, 251);
            this.grpCheckIn.TabIndex = 53;
            this.grpCheckIn.TabStop = false;
            this.grpCheckIn.Text = "Check Out";
            // 
            // grdCheckout
            // 
            this.grdCheckout.AllowUserToAddRows = false;
            this.grdCheckout.AllowUserToDeleteRows = false;
            this.grdCheckout.AllowUserToOrderColumns = true;
            this.grdCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCheckout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCheckout.Location = new System.Drawing.Point(0, 74);
            this.grdCheckout.MultiSelect = false;
            this.grdCheckout.Name = "grdCheckout";
            this.grdCheckout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCheckout.Size = new System.Drawing.Size(629, 150);
            this.grdCheckout.TabIndex = 49;
            // 
            // lblSelName
            // 
            this.lblSelName.AutoSize = true;
            this.lblSelName.Location = new System.Drawing.Point(20, 38);
            this.lblSelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelName.Name = "lblSelName";
            this.lblSelName.Size = new System.Drawing.Size(139, 20);
            this.lblSelName.TabIndex = 14;
            this.lblSelName.Text = "Select your name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(267, 510);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(196, 35);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Check-Out Client";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelReservationSubmit
            // 
            this.btnCancelReservationSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelReservationSubmit.Location = new System.Drawing.Point(267, 183);
            this.btnCancelReservationSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelReservationSubmit.Name = "btnCancelReservationSubmit";
            this.btnCancelReservationSubmit.Size = new System.Drawing.Size(119, 35);
            this.btnCancelReservationSubmit.TabIndex = 52;
            this.btnCancelReservationSubmit.Text = "Find Name";
            this.btnCancelReservationSubmit.UseVisualStyleBackColor = false;
            this.btnCancelReservationSubmit.Click += new System.EventHandler(this.btnCancelReservationSubmit_Click);
            // 
            // txtEntSurname
            // 
            this.txtEntSurname.Location = new System.Drawing.Point(267, 116);
            this.txtEntSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtEntSurname.MaxLength = 20;
            this.txtEntSurname.Name = "txtEntSurname";
            this.txtEntSurname.Size = new System.Drawing.Size(164, 27);
            this.txtEntSurname.TabIndex = 51;
            // 
            // lblEntSurname
            // 
            this.lblEntSurname.AutoSize = true;
            this.lblEntSurname.Location = new System.Drawing.Point(91, 119);
            this.lblEntSurname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEntSurname.Name = "lblEntSurname";
            this.lblEntSurname.Size = new System.Drawing.Size(126, 20);
            this.lblEntSurname.TabIndex = 50;
            this.lblEntSurname.Text = "Enter Surname:";
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
            this.label2.Size = new System.Drawing.Size(775, 90);
            this.label2.TabIndex = 55;
            this.label2.Text = "Check-Out Client";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(636, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(104, 69);
            this.btnHome.TabIndex = 54;
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
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.Location = new System.Drawing.Point(403, 183);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 35);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmReservationCheckOutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 612);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpCheckIn);
            this.Controls.Add(this.btnCancelReservationSubmit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEntSurname);
            this.Controls.Add(this.lblEntSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReservationCheckOutClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - Check-Out Client";
            this.Load += new System.EventHandler(this.frmReservationCheckOutClient_Load);
            this.grpCheckIn.ResumeLayout(false);
            this.grpCheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCheckIn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelName;
        private System.Windows.Forms.Button btnCancelReservationSubmit;
        private System.Windows.Forms.TextBox txtEntSurname;
        private System.Windows.Forms.Label lblEntSurname;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView grdCheckout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}