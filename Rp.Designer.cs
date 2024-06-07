namespace xyz_Hotel_Manager
{
    partial class Rp
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnb = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textpw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnU = new System.Windows.Forms.Button();
            this.labeluser = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Crimson;
            this.panelTitle.Controls.Add(this.btnb);
            this.panelTitle.Controls.Add(this.lblUsername);
            this.panelTitle.Controls.Add(this.lblRole);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(507, 76);
            this.panelTitle.TabIndex = 5;
            // 
            // btnb
            // 
            this.btnb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnb.FlatAppearance.BorderSize = 0;
            this.btnb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnb.ForeColor = System.Drawing.Color.Black;
            this.btnb.Location = new System.Drawing.Point(370, 20);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(99, 34);
            this.btnb.TabIndex = 13;
            this.btnb.Text = "Back";
            this.btnb.UseVisualStyleBackColor = false;
            this.btnb.Click += new System.EventHandler(this.btnb_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(882, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "UserName";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(870, 42);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(85, 16);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Administrator";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "XYZ Hotel";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(143, 119);
            this.textpw.Name = "textpw";
            this.textpw.PasswordChar = '*';
            this.textpw.Size = new System.Drawing.Size(204, 22);
            this.textpw.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 65;
            this.label8.Text = "New Password :";
            // 
            // btnU
            // 
            this.btnU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnU.BackColor = System.Drawing.Color.Crimson;
            this.btnU.FlatAppearance.BorderSize = 0;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnU.ForeColor = System.Drawing.Color.White;
            this.btnU.Location = new System.Drawing.Point(370, 112);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(99, 34);
            this.btnU.TabIndex = 71;
            this.btnU.Text = "Update";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Location = new System.Drawing.Point(24, 91);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(44, 16);
            this.labeluser.TabIndex = 14;
            this.labeluser.Text = "label1";
            // 
            // Rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 183);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.textpw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rp";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        public System.Windows.Forms.Button btnb;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnU;
        public System.Windows.Forms.Label labeluser;
    }
}