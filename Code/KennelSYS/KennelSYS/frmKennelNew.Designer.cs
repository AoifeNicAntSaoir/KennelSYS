namespace KennelSYS
{
    partial class frmKennelNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKennelNew));
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblKennelType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblKennelNumber = new System.Windows.Forms.Label();
            this.txtKennelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(179, 354);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(125, 35);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New ";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblKennelType
            // 
            this.lblKennelType.AutoSize = true;
            this.lblKennelType.BackColor = System.Drawing.SystemColors.Control;
            this.lblKennelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKennelType.Location = new System.Drawing.Point(76, 276);
            this.lblKennelType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKennelType.Name = "lblKennelType";
            this.lblKennelType.Size = new System.Drawing.Size(100, 20);
            this.lblKennelType.TabIndex = 7;
            this.lblKennelType.Text = "Kennel Type:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "S    Small",
            "M  Medium",
            "L   Large"});
            this.cboType.Location = new System.Drawing.Point(263, 275);
            this.cboType.Margin = new System.Windows.Forms.Padding(5);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(194, 25);
            this.cboType.TabIndex = 15;
            // 
            // lblKennelNumber
            // 
            this.lblKennelNumber.AutoSize = true;
            this.lblKennelNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblKennelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKennelNumber.Location = new System.Drawing.Point(54, 215);
            this.lblKennelNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKennelNumber.Name = "lblKennelNumber";
            this.lblKennelNumber.Size = new System.Drawing.Size(122, 20);
            this.lblKennelNumber.TabIndex = 17;
            this.lblKennelNumber.Text = "Kennel Number:";
            // 
            // txtKennelNo
            // 
            this.txtKennelNo.Enabled = false;
            this.txtKennelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKennelNo.Location = new System.Drawing.Point(263, 214);
            this.txtKennelNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtKennelNo.MaxLength = 4;
            this.txtKennelNo.Name = "txtKennelNo";
            this.txtKennelNo.Size = new System.Drawing.Size(41, 23);
            this.txtKennelNo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 30, 340, 40);
            this.label1.Size = new System.Drawing.Size(582, 87);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add New Kennel";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(478, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(78, 69);
            this.btnHome.TabIndex = 23;
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
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblInstructions.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInstructions.Location = new System.Drawing.Point(77, 108);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Padding = new System.Windows.Forms.Padding(20);
            this.lblInstructions.Size = new System.Drawing.Size(388, 58);
            this.lblInstructions.TabIndex = 28;
            this.lblInstructions.Text = "Add a new kennel for booking availability\r\n";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKennelNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 612);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKennelNo);
            this.Controls.Add(this.lblKennelNumber);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.lblKennelType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKennelNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kennel - Add New Kennel";
            this.Load += new System.EventHandler(this.frmKennelNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblKennelType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblKennelNumber;
        private System.Windows.Forms.TextBox txtKennelNo;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInstructions;
    }
}