using INSales;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace xyz_Hotel_Manager
{
    public partial class Res : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string r;
        public Res()
        {
            this.Controls.Clear();
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadRes();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this reservation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("DELETE FROM R WHERE id LIKE '" + r + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Reservation has been successfully removed.", "XYZ Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRes();
                Clear();
                btnCreate.Enabled = true;
            }
        }

        public void LoadRes()
        {
            dgvres.Rows.Clear();
            cm = new SqlCommand("SELECT id, fname, mobile, date, pax FROM R WHERE uname LIKE '%" + label7.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dgvres.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void Clear()
        {
            textrid.Clear();
            textrfn.Clear();
            textmail.Clear();
            textmobile.Clear();
            dateTimePickerr.Value = DateTime.Today;
            UDPax.Value = 1;

            textrid.Enabled = true;
            textrid.Focus();
            btnEdit.Enabled = true;
        }

        private void UDPax_ValueChanged(object sender, EventArgs e)
        {
            int p = (int)UDPax.Value;
            if (UDPax.Value <= 15)
            {
                texttcost.Text = (3000*p).ToString();
            }
            else if (UDPax.Value <= 25)
            {
                texttcost.Text = (2500 *p).ToString();
            }
            else if (UDPax.Value <= 50)
            {
                texttcost.Text = (1500 *p).ToString();
            }
            else
            {
                texttcost.Text = (1000 *p).ToString();
            }
        }

        private void dgvres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgvres.Rows[e.RowIndex].Cells[0].Value.ToString();

            textrid.Text = dgvres.Rows[e.RowIndex].Cells[0].Value.ToString();
            textrfn.Text = dgvres.Rows[e.RowIndex].Cells[1].Value.ToString();
            textmail.Text = dgvres.Rows[e.RowIndex].Cells[2].Value.ToString();
            textmobile.Text = dgvres.Rows[e.RowIndex].Cells[3].Value.ToString();
            UDPax.Text = dgvres.Rows[e.RowIndex].Cells[4].Value.ToString();

            textrid.Enabled = false;
            btnCreate.Enabled = false;
            btnEdit.Enabled = true;
            LoadRes();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you want to save this?", "Add to Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO R(id, fname, mail, mobile, date, pax, cost, uname)VALUES (@id, @fname, @mail, @mobile, @date, @pax, @cost, @uname)", cn);
                    cm.Parameters.AddWithValue("@id", textrid.Text);
                    cm.Parameters.AddWithValue("@fname", textrfn.Text);
                    cm.Parameters.AddWithValue("@mail", textmail.Text);
                    cm.Parameters.AddWithValue("@mobile", textmobile.Text);
                    cm.Parameters.AddWithValue("@date", dateTimePickerr.Value);
                    cm.Parameters.AddWithValue("@pax", UDPax.Value);
                    cm.Parameters.AddWithValue("@cost", texttcost.Text);
                    cm.Parameters.AddWithValue("@uname", label7.Text);


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Reservation has been successfully saved.");
                    Clear();
                    LoadRes();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this ? ", "Update Reservation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE R SET id = @id, fname = @fname, mail = @mail, mobile = @mobile, date = @date, pax = @pax, cost = @cost, uname = @uname " + " WHERE id Like '" + textrid.Text + "'", cn);
                cm.Parameters.AddWithValue("@id", textrid.Text);
                cm.Parameters.AddWithValue("@fname", textrfn.Text);
                cm.Parameters.AddWithValue("@mail", textmail.Text);
                cm.Parameters.AddWithValue("@mobile", textmobile.Text);
                cm.Parameters.AddWithValue("@date", dateTimePickerr.Value);
                cm.Parameters.AddWithValue("@pax", UDPax.Value);
                cm.Parameters.AddWithValue("@cost", texttcost.Text);
                cm.Parameters.AddWithValue("@uname", label7.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Reservation has been successfully updated", "XYZ-Hotel");
                Clear();
                LoadRes();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
                Clear();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            UMain m = new UMain();
            this.Hide();
            m.lblUsername.Text = label7.Text;
            m.Show();
        }

        private void btnDwn_Click(object sender, EventArgs e)
        {
            if (dgvres.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "My_Reservations_XYZ.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {

                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvres.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dgvres.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvres.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }


                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");

            }
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = label7.Text;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
                    break;

            }
            this.Controls.Clear();
            InitializeComponent();
            label7.Text = n;
            cn = new SqlConnection(dbcon.myConnection());
            LoadRes();
        }
    }
}
