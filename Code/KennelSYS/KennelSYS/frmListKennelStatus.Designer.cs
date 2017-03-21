namespace KennelSYS
{
    partial class frmListKennelStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListKennelStatus));
            this.rdoOccupied = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoVacant = new System.Windows.Forms.RadioButton();
            this.lblKennelStatus = new System.Windows.Forms.Label();
            this.grpOccupied = new System.Windows.Forms.GroupBox();
            this.grdOccupied = new System.Windows.Forms.DataGridView();
            this.lblKennelNo = new System.Windows.Forms.Label();
            this.grpVacant = new System.Windows.Forms.GroupBox();
            this.grdVacant = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpOccupied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOccupied)).BeginInit();
            this.grpVacant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoOccupied
            // 
            this.rdoOccupied.AutoSize = true;
            this.rdoOccupied.Location = new System.Drawing.Point(41, 164);
            this.rdoOccupied.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOccupied.Name = "rdoOccupied";
            this.rdoOccupied.Size = new System.Drawing.Size(86, 21);
            this.rdoOccupied.TabIndex = 0;
            this.rdoOccupied.Text = "Occupied";
            this.rdoOccupied.UseVisualStyleBackColor = true;
            this.rdoOccupied.CheckedChanged += new System.EventHandler(this.rdoOccupied_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(322, 164);
            this.rdoAll.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(41, 21);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // rdoVacant
            // 
            this.rdoVacant.AutoSize = true;
            this.rdoVacant.Location = new System.Drawing.Point(195, 164);
            this.rdoVacant.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVacant.Name = "rdoVacant";
            this.rdoVacant.Size = new System.Drawing.Size(70, 21);
            this.rdoVacant.TabIndex = 0;
            this.rdoVacant.Text = "Vacant";
            this.rdoVacant.UseVisualStyleBackColor = true;
            this.rdoVacant.CheckedChanged += new System.EventHandler(this.rdoVacant_CheckedChanged);
            // 
            // lblKennelStatus
            // 
            this.lblKennelStatus.AutoSize = true;
            this.lblKennelStatus.Location = new System.Drawing.Point(37, 130);
            this.lblKennelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKennelStatus.Name = "lblKennelStatus";
            this.lblKennelStatus.Size = new System.Drawing.Size(142, 17);
            this.lblKennelStatus.TabIndex = 1;
            this.lblKennelStatus.Text = "Filter Kennels Status ";
            // 
            // grpOccupied
            // 
            this.grpOccupied.Controls.Add(this.grdOccupied);
            this.grpOccupied.Controls.Add(this.lblKennelNo);
            this.grpOccupied.Location = new System.Drawing.Point(13, 222);
            this.grpOccupied.Margin = new System.Windows.Forms.Padding(4);
            this.grpOccupied.Name = "grpOccupied";
            this.grpOccupied.Padding = new System.Windows.Forms.Padding(4);
            this.grpOccupied.Size = new System.Drawing.Size(468, 278);
            this.grpOccupied.TabIndex = 3;
            this.grpOccupied.TabStop = false;
            this.grpOccupied.Text = "Occupied Kennels";
            this.grpOccupied.Visible = false;
            // 
            // grdOccupied
            // 
            this.grdOccupied.AllowUserToAddRows = false;
            this.grdOccupied.AllowUserToDeleteRows = false;
            this.grdOccupied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOccupied.Location = new System.Drawing.Point(17, 71);
            this.grdOccupied.Name = "grdOccupied";
            this.grdOccupied.RowTemplate.Height = 24;
            this.grdOccupied.Size = new System.Drawing.Size(430, 182);
            this.grdOccupied.TabIndex = 24;
            this.grdOccupied.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOccupied_CellContentClick);
            // 
            // lblKennelNo
            // 
            this.lblKennelNo.AutoSize = true;
            this.lblKennelNo.Location = new System.Drawing.Point(24, 36);
            this.lblKennelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKennelNo.Name = "lblKennelNo";
            this.lblKennelNo.Size = new System.Drawing.Size(78, 17);
            this.lblKennelNo.TabIndex = 0;
            this.lblKennelNo.Text = "Kennel No:";
            // 
            // grpVacant
            // 
            this.grpVacant.Controls.Add(this.grdVacant);
            this.grpVacant.Controls.Add(this.label1);
            this.grpVacant.Location = new System.Drawing.Point(516, 222);
            this.grpVacant.Margin = new System.Windows.Forms.Padding(4);
            this.grpVacant.Name = "grpVacant";
            this.grpVacant.Padding = new System.Windows.Forms.Padding(4);
            this.grpVacant.Size = new System.Drawing.Size(261, 278);
            this.grpVacant.TabIndex = 4;
            this.grpVacant.TabStop = false;
            this.grpVacant.Text = "Vacant Kennels";
            this.grpVacant.Visible = false;
            // 
            // grdVacant
            // 
            this.grdVacant.AllowUserToAddRows = false;
            this.grdVacant.AllowUserToDeleteRows = false;
            this.grdVacant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVacant.Location = new System.Drawing.Point(24, 71);
            this.grdVacant.Name = "grdVacant";
            this.grdVacant.RowTemplate.Height = 24;
            this.grdVacant.Size = new System.Drawing.Size(215, 182);
            this.grdVacant.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kennel No:";
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
            this.label2.Padding = new System.Windows.Forms.Padding(120, 30, 610, 40);
            this.label2.Size = new System.Drawing.Size(867, 87);
            this.label2.TabIndex = 49;
            this.label2.Text = "List Kennel Status";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(744, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(103, 69);
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
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 69);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // frmListKennelStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 612);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpVacant);
            this.Controls.Add(this.grpOccupied);
            this.Controls.Add(this.lblKennelStatus);
            this.Controls.Add(this.rdoVacant);
            this.Controls.Add(this.rdoAll);
            this.Controls.Add(this.rdoOccupied);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListKennelStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - List Kennel Status";
            this.Load += new System.EventHandler(this.frmListKennelStatus_Load);
            this.grpOccupied.ResumeLayout(false);
            this.grpOccupied.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOccupied)).EndInit();
            this.grpVacant.ResumeLayout(false);
            this.grpVacant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVacant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoOccupied;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoVacant;
        private System.Windows.Forms.Label lblKennelStatus;
        private System.Windows.Forms.GroupBox grpOccupied;
        private System.Windows.Forms.GroupBox grpVacant;
        private System.Windows.Forms.Label lblKennelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView grdOccupied;
        private System.Windows.Forms.DataGridView grdVacant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}