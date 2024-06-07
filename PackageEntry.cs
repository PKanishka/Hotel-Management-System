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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace xyz_Hotel_Manager
{
    public partial class PackageEntry : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public string u;
        public PackageEntry()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this Package?", "Add to Packages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO Packages(Id, Name, [Cost per person], Description, Complementary)VALUES (@Id, @Name, @Costperperson, @Description, @Complementary)", cn);
                    cm.Parameters.AddWithValue("@Id", textpid.Text);
                    cm.Parameters.AddWithValue("@Name", textpname.Text);
                    cm.Parameters.AddWithValue("@Costperperson", int.Parse(textcpp.Text));
                    cm.Parameters.AddWithValue("@Description", textpdesc.Text);
                    cm.Parameters.AddWithValue("@Complementary", textcom.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Package has been successfully saved.");
                    Clear();
                    ManagePackage mp = new ManagePackage();
                    this.Hide();
                    mp.u = u;
                    mp.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            ManagePackage mp = new ManagePackage();
            this.Close();
            mp.u = u;
            mp.Show();
        }

        public void Clear()
        {
            textpid.Clear();
            textpname.Clear();
            textcpp.Clear();
            textpdesc.Clear();
            textcom.Clear();

            textpid.Enabled = true;
            textpid.Focus();
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this package", "Update Package!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Packages SET Name = @Name, [Cost per person] = @Costperperson, Description = @Description, Complementary = @Complementary" + " WHERE Id Like '" + textpid.Text + "'", cn);
                cm.Parameters.AddWithValue("@Id", textpid.Text);
                cm.Parameters.AddWithValue("@Name", textpname.Text);
                cm.Parameters.AddWithValue("@Costperperson", textcpp.Text);
                cm.Parameters.AddWithValue("@Description", textpdesc.Text);
                cm.Parameters.AddWithValue("@Complementary", textcom.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Package has been successfully updated", "XYZ Hotel");
                Clear();
                ManagePackage mp = new ManagePackage();
                this.Hide();
                mp.u = u;
                mp.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
