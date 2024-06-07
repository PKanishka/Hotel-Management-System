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
    public partial class Vpack : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public string u;
        public Vpack()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadPackage();
        }

        public void LoadPackage()
        {
            dgvvp.Rows.Clear();
            cm = new SqlCommand("SELECT Id, Name, [Cost per person], Description, Complementary FROM Packages WHERE Name LIKE '%" + textsearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvvp.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            LoadPackage();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            UMain m = new UMain();
            m.lblUsername.Text = u;
            this.Hide();
            m.Show();
        }
    }
}
