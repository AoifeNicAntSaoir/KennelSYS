namespace KennelSYS
{
    partial class frmListRevenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListRevenueAnalysis));
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.grpYearSel = new System.Windows.Forms.GroupBox();
            this.lblSelectedYear = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.grdRevAnalysis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpYearSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevAnalysis)).BeginInit();
            this.SuspendLayout();
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
            this.label2.Padding = new System.Windows.Forms.Padding(120, 30, 310, 40);
            this.label2.Size = new System.Drawing.Size(626, 90);
            this.label2.TabIndex = 59;
            this.label2.Text = "List Revenue Analysis";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(105)))), ((int)(((byte)(14)))));
            this.btnHome.BackgroundImage = global::KennelSYS.Properties.Resources.simple_orange_house_md;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(450, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(89, 69);
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
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016"});
            this.cboYear.Location = new System.Drawing.Point(163, 125);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(126, 28);
            this.cboYear.TabIndex = 64;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // grpYearSel
            // 
            this.grpYearSel.Controls.Add(this.lblSelectedYear);
            this.grpYearSel.Controls.Add(this.lblHead);
            this.grpYearSel.Controls.Add(this.grdRevAnalysis);
            this.grpYearSel.Location = new System.Drawing.Point(22, 203);
            this.grpYearSel.Name = "grpYearSel";
            this.grpYearSel.Size = new System.Drawing.Size(517, 405);
            this.grpYearSel.TabIndex = 67;
            this.grpYearSel.TabStop = false;
            this.grpYearSel.Text = "Year Selected:";
            this.grpYearSel.Visible = false;
            // 
            // lblSelectedYear
            // 
            this.lblSelectedYear.AutoSize = true;
            this.lblSelectedYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedYear.Location = new System.Drawing.Point(165, 36);
            this.lblSelectedYear.Name = "lblSelectedYear";
            this.lblSelectedYear.Size = new System.Drawing.Size(0, 24);
            this.lblSelectedYear.TabIndex = 69;
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.Location = new System.Drawing.Point(22, 36);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(147, 24);
            this.lblHead.TabIndex = 68;
            this.lblHead.Text = "Selected Year:";
            // 
            // grdRevAnalysis
            // 
            this.grdRevAnalysis.AllowUserToAddRows = false;
            this.grdRevAnalysis.AllowUserToDeleteRows = false;
            this.grdRevAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRevAnalysis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdRevAnalysis.Location = new System.Drawing.Point(141, 79);
            this.grdRevAnalysis.MultiSelect = false;
            this.grdRevAnalysis.Name = "grdRevAnalysis";
            this.grdRevAnalysis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRevAnalysis.Size = new System.Drawing.Size(242, 294);
            this.grdRevAnalysis.TabIndex = 67;
            // 
            // frmListRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 612);
            this.Controls.Add(this.grpYearSel);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListRevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KennelSYS - List Revenue Analysis";
            this.Load += new System.EventHandler(this.frmListRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpYearSel.ResumeLayout(false);
            this.grpYearSel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.GroupBox grpYearSel;
        private System.Windows.Forms.Label lblSelectedYear;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.DataGridView grdRevAnalysis;
    }
}