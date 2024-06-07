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
    public partial class Main : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public Main()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
        }

        private void btnms_Click(object sender, EventArgs e)
        {
            ManageStaff ms = new ManageStaff();
            this.Hide();
            ms.u = lblUsername.Text;
            ms.Show();
        }

        private void btnmp_Click(object sender, EventArgs e)
        {
            ManagePackage mp = new ManagePackage();
            this.Hide();
            mp.u = lblUsername.Text;
            mp.Show();
        }

        private void btnlo_Click(object sender, EventArgs e)
        {
            MSLogin l = new MSLogin();
            this.Hide();
            l.Show();
        }
    }
}
