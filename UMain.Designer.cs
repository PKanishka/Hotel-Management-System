namespace xyz_Hotel_Manager
{
    partial class UMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UMain));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnlo = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelvp = new System.Windows.Forms.Panel();
            this.btnvp = new System.Windows.Forms.Button();
            this.pictureBoxmp = new System.Windows.Forms.PictureBox();
            this.panelr = new System.Windows.Forms.Panel();
            this.btnr = new System.Windows.Forms.Button();
            this.pictureBoxms = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelvp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmp)).BeginInit();
            this.panelr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxms)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Crimson;
            this.panelTitle.Controls.Add(this.btnlo);
            this.panelTitle.Controls.Add(this.lblUsername);
            this.panelTitle.Controls.Add(this.lblRole);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(800, 76);
            this.panelTitle.TabIndex = 3;
            // 
            // btnlo
            // 
            this.btnlo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnlo.FlatAppearance.BorderSize = 0;
            this.btnlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlo.ForeColor = System.Drawing.Color.Black;
            this.btnlo.Location = new System.Drawing.Point(638, 20);
            this.btnlo.Name = "btnlo";
            this.btnlo.Size = new System.Drawing.Size(99, 34);
            this.btnlo.TabIndex = 13;
            this.btnlo.Text = "Log Out";
            this.btnlo.UseVisualStyleBackColor = false;
            this.btnlo.Click += new System.EventHandler(this.btnlo_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(546, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "UserName";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(498, 29);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 16);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "User :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(32, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(454, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "XYZ Hotel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelvp
            // 
            this.panelvp.BackColor = System.Drawing.Color.Transparent;
            this.panelvp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelvp.Controls.Add(this.btnvp);
            this.panelvp.Controls.Add(this.pictureBoxmp);
            this.panelvp.Location = new System.Drawing.Point(396, 139);
            this.panelvp.Name = "panelvp";
            this.panelvp.Size = new System.Drawing.Size(206, 235);
            this.panelvp.TabIndex = 13;
            // 
            // btnvp
            // 
            this.btnvp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnvp.BackColor = System.Drawing.Color.Crimson;
            this.btnvp.FlatAppearance.BorderSize = 0;
            this.btnvp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvp.ForeColor = System.Drawing.Color.White;
            this.btnvp.Location = new System.Drawing.Point(12, 170);
            this.btnvp.Name = "btnvp";
            this.btnvp.Size = new System.Drawing.Size(177, 52);
            this.btnvp.TabIndex = 10;
            this.btnvp.Text = "View Package";
            this.btnvp.UseVisualStyleBackColor = false;
            this.btnvp.Click += new System.EventHandler(this.btnvp_Click);
            // 
            // pictureBoxmp
            // 
            this.pictureBoxmp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxmp.Image")));
            this.pictureBoxmp.Location = new System.Drawing.Point(43, 25);
            this.pictureBoxmp.Name = "pictureBoxmp";
            this.pictureBoxmp.Size = new System.Drawing.Size(117, 126);
            this.pictureBoxmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxmp.TabIndex = 0;
            this.pictureBoxmp.TabStop = false;
            // 
            // panelr
            // 
            this.panelr.BackColor = System.Drawing.Color.Transparent;
            this.panelr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelr.Controls.Add(this.btnr);
            this.panelr.Controls.Add(this.pictureBoxms);
            this.panelr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelr.Location = new System.Drawing.Point(156, 139);
            this.panelr.Name = "panelr";
            this.panelr.Size = new System.Drawing.Size(206, 235);
            this.panelr.TabIndex = 12;
            // 
            // btnr
            // 
            this.btnr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnr.BackColor = System.Drawing.Color.Crimson;
            this.btnr.FlatAppearance.BorderSize = 0;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr.ForeColor = System.Drawing.Color.White;
            this.btnr.Location = new System.Drawing.Point(15, 170);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(177, 52);
            this.btnr.TabIndex = 10;
            this.btnr.Text = "Reservation";
            this.btnr.UseVisualStyleBackColor = false;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // pictureBoxms
            // 
            this.pictureBoxms.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxms.Image")));
            this.pictureBoxms.Location = new System.Drawing.Point(45, 25);
            this.pictureBoxms.Name = "pictureBoxms";
            this.pictureBoxms.Size = new System.Drawing.Size(117, 126);
            this.pictureBoxms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxms.TabIndex = 0;
            this.pictureBoxms.TabStop = false;
            // 
            // UMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelvp);
            this.Controls.Add(this.panelr);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMain";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelvp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmp)).EndInit();
            this.panelr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        public System.Windows.Forms.Button btnlo;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelvp;
        public System.Windows.Forms.Button btnvp;
        private System.Windows.Forms.PictureBox pictureBoxmp;
        private System.Windows.Forms.Panel panelr;
        public System.Windows.Forms.Button btnr;
        private System.Windows.Forms.PictureBox pictureBoxms;
    }
}