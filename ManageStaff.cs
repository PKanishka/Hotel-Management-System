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

namespace xyz_Hotel_Manager
{
    public partial class ManageStaff : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public string u;
        public ManageStaff()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadStaff();
        }

        public void LoadStaff()
        {
            dgvstaff.Rows.Clear();
            cm = new SqlCommand("SELECT id, name, email, address, gender, contact, department FROM tbStaff WHERE name LIKE '%" + textsearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvstaff.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
            m.lblUsername.Text = u;
            m.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffEntry se = new StaffEntry();
            this.Hide();
            se.u = u;
            se.Show();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void dgvstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvstaff.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                StaffEntry se = new StaffEntry();
                se.textid.Text = dgvstaff.Rows[e.RowIndex].Cells[0].Value.ToString();
                se.textad.Text = dgvstaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                se.textmail.Text = dgvstaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                se.textname.Text = dgvstaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                se.cbogender.Text = dgvstaff.Rows[e.RowIndex].Cells[4].Value.ToString();
                se.textcontact.Text = dgvstaff.Rows[e.RowIndex].Cells[5].Value.ToString();
                se.cbodep.Text = dgvstaff.Rows[e.RowIndex].Cells[6].Value.ToString();

                se.textid.Enabled = false;
                se.btnSave.Enabled = false;
                se.btnUpdate.Enabled = true;
                this.Hide();
                se.u = u;
                se.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStaff WHERE id LIKE '" + dgvstaff[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Member has been successfully removed.", "XYZ Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadStaff();
        }
    }
}
