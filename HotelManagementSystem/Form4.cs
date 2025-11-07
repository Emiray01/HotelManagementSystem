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

namespace HotelManagementSystem
{
    public partial class kathizmet : Form
    {
        SqlConnection conn = new SqlConnection(formGiris.connectionString);
        public kathizmet()
        {
            InitializeComponent();
        }
        private void kathizmet_Load(object sender, EventArgs e)
        {
            pnlodatem.Visible = false;
            pnlsipariş.Visible = false;
            lstsiparis.View = View.Details;
            lstsiparis.FullRowSelect = true;
            lstsiparis.GridLines = true;
            lstsiparis.Columns.Clear();

            lstsiparis.Columns.Add("Sipariş ID", 80);
            lstsiparis.Columns.Add("Oda No", 80);
            lstsiparis.Columns.Add("Ürün", 150);
            lstsiparis.Columns.Add("Durum", 120);
            siparisListele();
        }

        private void siparisListele()
        {
            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT IDsiparis, IDoda, urun, durum 
                                          FROM siparisler 
                                          WHERE durum = 0", conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    lstsiparis.Items.Clear();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["IDsiparis"].ToString());
                        item.SubItems.Add(dr["IDoda"].ToString());
                        item.SubItems.Add(dr["urun"].ToString());
                        item.SubItems.Add("Hazırlanıyor");
                        lstsiparis.Items.Add(item);
                    }
                }
            }
        }
        private void btnonay_Click(object sender, EventArgs e)
        {
            if (lstsiparis.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen teslim edilecek bir siparişi seçin.");
                return;
            }

            int siparisID = int.Parse(lstsiparis.SelectedItems[0].Text);

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE siparisler SET durum = 1 WHERE IDsiparis = @id", conn);
                cmd.Parameters.AddWithValue("@id", siparisID);
                cmd.ExecuteNonQuery();
            }

            siparisListele();
        }
        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlsipariş.Visible = true;
        }
        private void odaTemizlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlodatem.Visible = true;
        }
        private void btngeri1_Click(object sender, EventArgs e)
        {
            pnlsipariş.Visible = false;
        }

    }
}
