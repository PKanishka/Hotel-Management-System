namespace xyz_Hotel_Manager
{
    partial class StaffEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffEntry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textpr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textgn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textphoto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbodep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textcontact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textsal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnphoto = new System.Windows.Forms.Button();
            this.btngn = new System.Windows.Forms.Button();
            this.btnpr = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 45);
            this.panel1.TabIndex = 8;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(484, 6);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 33);
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Entry";
            // 
            // textpr
            // 
            this.textpr.Location = new System.Drawing.Point(169, 333);
            this.textpr.Name = "textpr";
            this.textpr.ReadOnly = true;
            this.textpr.Size = new System.Drawing.Size(218, 22);
            this.textpr.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Police Report :";
            // 
            // textgn
            // 
            this.textgn.Location = new System.Drawing.Point(169, 305);
            this.textgn.Name = "textgn";
            this.textgn.ReadOnly = true;
            this.textgn.Size = new System.Drawing.Size(218, 22);
            this.textgn.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Grama Niladhari :";
            // 
            // textphoto
            // 
            this.textphoto.Location = new System.Drawing.Point(169, 277);
            this.textphoto.Name = "textphoto";
            this.textphoto.ReadOnly = true;
            this.textphoto.Size = new System.Drawing.Size(218, 22);
            this.textphoto.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Photo :";
            // 
            // textmail
            // 
            this.textmail.Location = new System.Drawing.Point(169, 163);
            this.textmail.Name = "textmail";
            this.textmail.Size = new System.Drawing.Size(309, 22);
            this.textmail.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Email Address :";
            // 
            // cbodep
            // 
            this.cbodep.FormattingEnabled = true;
            this.cbodep.Items.AddRange(new object[] {
            "Maintainence",
            "Kitchen",
            "Housekeeping",
            "Banquests"});
            this.cbodep.Location = new System.Drawing.Point(169, 246);
            this.cbodep.Name = "cbodep";
            this.cbodep.Size = new System.Drawing.Size(309, 24);
            this.cbodep.TabIndex = 56;
            this.cbodep.SelectedIndexChanged += new System.EventHandler(this.cbodep_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Department :";
            // 
            // textcontact
            // 
            this.textcontact.Location = new System.Drawing.Point(169, 219);
            this.textcontact.Name = "textcontact";
            this.textcontact.Size = new System.Drawing.Size(309, 22);
            this.textcontact.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Contact Number :";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(169, 136);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(309, 22);
            this.textad.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Address :";
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(169, 108);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(309, 22);
            this.textname.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Name :";
            // 
            // cbogender
            // 
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbogender.Location = new System.Drawing.Point(169, 190);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(309, 24);
            this.cbogender.TabIndex = 48;
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(169, 82);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(309, 22);
            this.textid.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "ID :";
            // 
            // textsal
            // 
            this.textsal.Location = new System.Drawing.Point(169, 361);
            this.textsal.Name = "textsal";
            this.textsal.ReadOnly = true;
            this.textsal.Size = new System.Drawing.Size(309, 22);
            this.textsal.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Salary :";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(379, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 34);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Firebrick;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(169, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnphoto
            // 
            this.btnphoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnphoto.BackColor = System.Drawing.Color.Crimson;
            this.btnphoto.FlatAppearance.BorderSize = 0;
            this.btnphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphoto.ForeColor = System.Drawing.Color.White;
            this.btnphoto.Location = new System.Drawing.Point(393, 276);
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.Size = new System.Drawing.Size(85, 23);
            this.btnphoto.TabIndex = 70;
            this.btnphoto.Text = "Select";
            this.btnphoto.UseVisualStyleBackColor = false;
            this.btnphoto.Click += new System.EventHandler(this.btnphoto_Click);
            // 
            // btngn
            // 
            this.btngn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btngn.BackColor = System.Drawing.Color.Crimson;
            this.btngn.FlatAppearance.BorderSize = 0;
            this.btngn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngn.ForeColor = System.Drawing.Color.White;
            this.btngn.Location = new System.Drawing.Point(393, 304);
            this.btngn.Name = "btngn";
            this.btngn.Size = new System.Drawing.Size(85, 23);
            this.btngn.TabIndex = 71;
            this.btngn.Text = "Select";
            this.btngn.UseVisualStyleBackColor = false;
            this.btngn.Click += new System.EventHandler(this.btngn_Click);
            // 
            // btnpr
            // 
            this.btnpr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpr.BackColor = System.Drawing.Color.Crimson;
            this.btnpr.FlatAppearance.BorderSize = 0;
            this.btnpr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpr.ForeColor = System.Drawing.Color.White;
            this.btnpr.Location = new System.Drawing.Point(393, 332);
            this.btnpr.Name = "btnpr";
            this.btnpr.Size = new System.Drawing.Size(85, 23);
            this.btnpr.TabIndex = 72;
            this.btnpr.Text = "Select";
            this.btnpr.UseVisualStyleBackColor = false;
            this.btnpr.Click += new System.EventHandler(this.btnpr_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(274, 395);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 34);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // StaffEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.btnpr);
            this.Controls.Add(this.btngn);
            this.Controls.Add(this.btnphoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textsal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textpr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textgn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textphoto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbodep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textcontact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffEntry";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textpr;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textgn;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textphoto;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox textmail;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbodep;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textcontact;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbogender;
        public System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textsal;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnphoto;
        public System.Windows.Forms.Button btngn;
        public System.Windows.Forms.Button btnpr;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.Button btnUpdate;
    }
}