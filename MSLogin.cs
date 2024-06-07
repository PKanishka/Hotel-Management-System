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
using System.Xml.Linq;

namespace xyz_Hotel_Manager
{
    public partial class MSLogin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public string _pass = "";
        public MSLogin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            txtName.Focus();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            this.Hide();
            r.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string _username = "";
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * From Login Where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtName.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _pass = dr["password"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if (found)
                {
                    if (_username == "admin")
                    {
                        MessageBox.Show("Welcome " + _username + "'", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        Main a = new Main();
                        a.lblUsername.Text = _username;
                        a.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _username + "'", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        UMain main = new UMain();
                        main.lblUsername.Text = _username;
                        main.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            try
            {
                string _username = "";
                bool found;
                cn.Open();
                cm = new SqlCommand("Select * From Login Where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", txtName.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _pass = dr["password"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();
                cn.Close();

                if (found)
                {
                    Rp r = new Rp();
                    this.Hide();
                    r.Show();
                    r.labeluser.Text = _username;
                }
                else
                {
                    MessageBox.Show("Invalid username and password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
