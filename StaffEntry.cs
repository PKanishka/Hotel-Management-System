using INSales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace xyz_Hotel_Manager
{
    public partial class StaffEntry : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public string u;
        public StaffEntry()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            ManageStaff ms = new ManageStaff();
            this.Close();
            ms.u = u;
            ms.Show();

        }

        public void Clear()
        {
            textid.Clear();
            textad.Clear();
            textmail.Clear();
            textname.Clear();
            textcontact.Clear();
            textphoto.Clear();
            textgn.Clear();
            textpr.Clear();
            textsal.Clear();
            cbogender.SelectedIndex = 0;
            cbodep.SelectedIndex = 0;

            textid.Enabled = true;
            textid.Focus();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] imageData = File.ReadAllBytes(textphoto.Text);
            byte[] pdfData1 = File.ReadAllBytes(textgn.Text);
            byte[] pdfData2 = File.ReadAllBytes(textpr.Text);
            try
            {
                if(MessageBox.Show("Are you want to save this member?","Add to Staff",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbStaff(id, address, email, name, gender, contact, department, photo, gn, pr, sal)VALUES (@id, @address, @email, @name, @gender, @contact, @department, @photo, @gn, @pr, @sal)", cn);
                    cm.Parameters.AddWithValue("@id", textid.Text);
                    cm.Parameters.AddWithValue("@address", textad.Text);
                    cm.Parameters.AddWithValue("@email", textmail.Text);
                    cm.Parameters.AddWithValue("@name", textname.Text);
                    cm.Parameters.AddWithValue("@gender", cbogender.Text);
                    cm.Parameters.AddWithValue("@contact", textcontact.Text);
                    cm.Parameters.AddWithValue("@department", cbodep.Text);
                    cm.Parameters.AddWithValue("@photo", imageData);
                    cm.Parameters.AddWithValue("@gn", pdfData1);
                    cm.Parameters.AddWithValue("@pr", pdfData2);
                    cm.Parameters.AddWithValue("@sal", double.Parse(textsal.Text));
                 
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Member has been successfully saved.");
                    Clear();
                    ManageStaff ms = new ManageStaff();
                    this.Hide();
                    ms.u = u;
                    ms.Show();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textphoto.Text = openFileDialog.FileName;
            }

        }

        private void btngn_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textgn.Text = openFileDialog.FileName;
            }
        }

        private void btnpr_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textpr.Text = openFileDialog.FileName;
            }

        }

        private void cbodep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbodep.SelectedIndex == 0)
            {
                textsal.Text = "45000";
            }
            else if (cbodep.SelectedIndex == 1)
            {
                textsal.Text = "50000";
            }
            else if (cbodep.SelectedIndex == 2)
            {
                textsal.Text = "30000";
            }
            else if (cbodep.SelectedIndex == 3)
            {
                textsal.Text = "60000";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this Member", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbStaff SET address = @address, email = @email, name = @name, gender = @gender, contact = @contact, department = @department, sal = @sal " + " WHERE id Like '" + textid.Text + "'", cn);
                cm.Parameters.AddWithValue("@id", textid.Text);
                cm.Parameters.AddWithValue("@address", textad.Text);
                cm.Parameters.AddWithValue("@email", textmail.Text);
                cm.Parameters.AddWithValue("@name", textname.Text);
                cm.Parameters.AddWithValue("@gender", textname.Text);
                cm.Parameters.AddWithValue("@contact", textcontact.Text);
                cm.Parameters.AddWithValue("@department", cbodep.Text);
                cm.Parameters.AddWithValue("@sal", textsal.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Staff has been successfully updated", "AGT-Sim");
                Clear();
                ManageStaff ms = new ManageStaff();
                this.Hide();
                ms.u = u;
                ms.Show();
            }
        }
    }
}
