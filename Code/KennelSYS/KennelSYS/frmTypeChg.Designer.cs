namespace KennelSYS
{
    partial class frmTypeChg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeChg));
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.picRateError = new System.Windows.Forms.PictureBox();
            this.picDescError = new System.Windows.Forms.PictureBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRateError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(301, 303);
            this.cboType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(348, 28);
            this.cboType.TabIndex = 22;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.Control;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblType.Location = new System.Drawing.Point(67, 306);
            this.lblType.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(158, 20);
            this.lblType.TabIndex = 21;
            this.lblType.Text = "Select Kennel Type:";
            // 
            // grpType
            // 
            this.grpType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpType.Controls.Add(this.picRateError);
            this.grpType.Controls.Add(this.picDescError);
            this.grpType.Controls.Add(this.btnSet);
            this.grpType.Controls.Add(this.txtRate);
            this.grpType.Controls.Add(this.lblRate);
            this.grpType.Controls.Add(this.txtDescription);
            this.grpType.Controls.Add(this.lblDescription);
            this.grpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.grpType.Location = new System.Drawing.Point(71, 382);
            this.grpType.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpType.Name = "grpType";
            this.grpType.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.grpType.Size = new System.Drawing.Size(592, 292);
            this.grpType.TabIndex = 23;
            this.grpType.TabStop = false;
            this.grpType.Text = "Change Details";
            this.grpType.Visible = false;
            // 
            // picRateError
            // 
            this.picRateError.Image = global::KennelSYS.Properties.Resources.rror;
            this.picRateError.Location = new System.Drawing.Point(529, 117);
            this.picRateError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRateError.Name = "picRateError";
            this.picRateError.Size = new System.Drawing.Size(51, 48);
            this.picRateError.TabIndex = 25;
            this.picRateError.TabStop = false;
            this.picRateError.Visible = false;
            // 
            // picDescError
            // 
            this.picDescError.Image = ((System.Drawing.Image)(resources.GetObject("picDescError.Image")));
            this.picDescError.Location = new System.Drawing.Point(529, 48);
            this.picDescError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picDescError.Name = "picDescError";
            this.picDescError.Size = new System.Drawing.Size(51, 49);
            this.picDescError.TabIndex = 24;
            this.picDescError.TabStop = false;
            this.picDescError.Visible = false;
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSet.Location = new System.Drawing.Point(195, 215);
            this.btnSet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(207, 43);
            this.btnSet.TabIndex = 21;
            this.btnSet.Text = "Change Type";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(195, 137);
            this.txtRate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtRate.MaxLength = 7;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(73, 27);
            this.txtRate.TabIndex = 20;
            this.txtRate.Text = "000.00";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.SystemColors.Control;
            this.lblRate.Location = new System.Drawing.Point(89, 137);
            this.lblRate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(49, 20);
            this.lblRate.TabIndex = 23;
            this.lblRate.Text = "Rate:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(195, 69);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 27);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.Text = "Enter a Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(60, 74);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description:";
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
            this.label1.Padding = new System.Windows.Forms.Padding(160, 37, 420, 49);
            this.label1.Size = new System.Drawing.Size(763, 106);
            this.label1.TabIndex = 25;
            this.label1.Text = "Change Kennel Type";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(643, 12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(111, 84);
            this.btnHome.TabIndex = 24;
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 69);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblInstructions.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(131, 142);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.lblInstructions.Size = new System.Drawing.Size(465, 100);
            this.lblInstructions.TabIndex = 27;
            this.lblInstructions.Text = "Change Kennel Type Details. Ammend \r\nthe rate or description of a kennel Type";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTypeChg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 753);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTypeChg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - Change Kennel Type Details";
            this.Load += new System.EventHandler(this.frmTypeChg_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRateError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picRateError;
        private System.Windows.Forms.PictureBox picDescError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInstructions;
    }
}