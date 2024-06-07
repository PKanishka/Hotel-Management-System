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
    public partial class ManagePackage : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public string u;
        public ManagePackage()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadPackage();
        }

        public void LoadPackage()
        {
            dgvpackage.Rows.Clear();
            cm = new SqlCommand("SELECT Id, Name, [Cost per person], Description, Complementary FROM Packages ", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvpackage.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
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
            PackageEntry pe = new PackageEntry();
            this.Close();
            pe.u = u;
            pe.Show();
        }

        private void dgvpackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvpackage.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                PackageEntry p = new PackageEntry();
                p.textpid.Text = dgvpackage.Rows[e.RowIndex].Cells[0].Value.ToString();
                p.textpname.Text = dgvpackage.Rows[e.RowIndex].Cells[1].Value.ToString();
                p.textcpp.Text = dgvpackage.Rows[e.RowIndex].Cells[2].Value.ToString();
                p.textpdesc.Text = dgvpackage.Rows[e.RowIndex].Cells[3].Value.ToString();
                p.textcom.Text = dgvpackage.Rows[e.RowIndex].Cells[4].Value.ToString();

                p.textpid.Enabled = false;
                p.btnSave.Enabled = false;
                p.btnUpdate.Enabled = true;
                this.Hide();
                p.u = u;
                p.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this Package?", "Delete Package", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM Packages WHERE Id LIKE '" + dgvpackage[0, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Package has been successfully removed.", "XYZ Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadPackage();
        }
    }
}
