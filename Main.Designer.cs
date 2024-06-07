namespace xyz_Hotel_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnlo = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelms = new System.Windows.Forms.Panel();
            this.btnms = new System.Windows.Forms.Button();
            this.pictureBoxms = new System.Windows.Forms.PictureBox();
            this.panelmp = new System.Windows.Forms.Panel();
            this.btnmp = new System.Windows.Forms.Button();
            this.pictureBoxmp = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxms)).BeginInit();
            this.panelmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmp)).BeginInit();
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
            this.panelTitle.TabIndex = 2;
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
            // panelms
            // 
            this.panelms.BackColor = System.Drawing.Color.Transparent;
            this.panelms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelms.Controls.Add(this.btnms);
            this.panelms.Controls.Add(this.pictureBoxms);
            this.panelms.Location = new System.Drawing.Point(156, 139);
            this.panelms.Name = "panelms";
            this.panelms.Size = new System.Drawing.Size(206, 235);
            this.panelms.TabIndex = 3;
            // 
            // btnms
            // 
            this.btnms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnms.BackColor = System.Drawing.Color.Crimson;
            this.btnms.FlatAppearance.BorderSize = 0;
            this.btnms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnms.ForeColor = System.Drawing.Color.White;
            this.btnms.Location = new System.Drawing.Point(13, 168);
            this.btnms.Name = "btnms";
            this.btnms.Size = new System.Drawing.Size(177, 52);
            this.btnms.TabIndex = 10;
            this.btnms.Text = "Manage Staff";
            this.btnms.UseVisualStyleBackColor = false;
            this.btnms.Click += new System.EventHandler(this.btnms_Click);
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
            // panelmp
            // 
            this.panelmp.BackColor = System.Drawing.Color.Transparent;
            this.panelmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelmp.Controls.Add(this.btnmp);
            this.panelmp.Controls.Add(this.pictureBoxmp);
            this.panelmp.Location = new System.Drawing.Point(396, 139);
            this.panelmp.Name = "panelmp";
            this.panelmp.Size = new System.Drawing.Size(206, 235);
            this.panelmp.TabIndex = 11;
            // 
            // btnmp
            // 
            this.btnmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmp.BackColor = System.Drawing.Color.Crimson;
            this.btnmp.FlatAppearance.BorderSize = 0;
            this.btnmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmp.ForeColor = System.Drawing.Color.White;
            this.btnmp.Location = new System.Drawing.Point(10, 168);
            this.btnmp.Name = "btnmp";
            this.btnmp.Size = new System.Drawing.Size(177, 52);
            this.btnmp.TabIndex = 10;
            this.btnmp.Text = "Manage Package";
            this.btnmp.UseVisualStyleBackColor = false;
            this.btnmp.Click += new System.EventHandler(this.btnmp_Click);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelmp);
            this.Controls.Add(this.panelms);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxms)).EndInit();
            this.panelmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelms;
        private System.Windows.Forms.PictureBox pictureBoxms;
        public System.Windows.Forms.Button btnms;
        private System.Windows.Forms.Panel panelmp;
        public System.Windows.Forms.Button btnmp;
        private System.Windows.Forms.PictureBox pictureBoxmp;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        public System.Windows.Forms.Button btnlo;
    }
}