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
    public partial class Reg : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public Reg()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public void Clear()
        {
            textun.Clear();
            textem.Clear();
            textpw.Clear();
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            MSLogin m = new MSLogin();
            this.Hide();
            m.Show();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("INSERT INTO Login(username, email, password)VALUES(@username, @email, @password)", cn);
            cm.Parameters.AddWithValue("@username", textun.Text);
            cm.Parameters.AddWithValue("@email", textem.Text);
            cm.Parameters.AddWithValue("@password", textpw.Text);
            cm.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Regestration successfull.Please login to the system!");
            MSLogin m = new MSLogin();
            this.Hide();
            m.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
