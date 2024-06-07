using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyz_Hotel_Manager
{
    public partial class UMain : Form
    {
        public UMain()
        {
            InitializeComponent();
        }

        private void btnvp_Click(object sender, EventArgs e)
        {
            Vpack v = new Vpack();
            this.Hide();
            v.u = lblUsername.Text;
            v.Show();
        }

        private void btnlo_Click(object sender, EventArgs e)
        {
            MSLogin l = new MSLogin();
            this.Hide();
            l.Show();
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            Res r = new Res();
            this.Hide();
            r.Show();
            r.label7.Text = lblUsername.Text;
        }
    }
}
