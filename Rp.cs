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
    public partial class Rp : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public Rp()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            MSLogin r = new MSLogin();
            this.Hide();
            r.Show();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset password ? ", "Reset Password!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Login SET password = @password " + " WHERE username Like '" + labeluser.Text + "'", cn);
                cm.Parameters.AddWithValue("@password", textpw.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                textpw.Clear();
                MessageBox.Show("Password Reset successfull.Please login with new one!");
                MSLogin m = new MSLogin();
                this.Hide();
                m.Show();
            }
        }
    }
}
