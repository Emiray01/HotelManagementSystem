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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class Envanter : Form
    {
        SqlConnection conn = new SqlConnection(formGiris.connectionString);
        private int seciliurun = -1;
        public Envanter()
        {
            InitializeComponent();
        }

        private void Envanter_Load(object sender, EventArgs e)
        {
            kategoricbx.Items.AddRange(new string[] { "Temizlik", "İçecek", "Banyo", "Tahıl", "Sebze", "Meyve" });
            lstUrun.View = View.Details;
            lstUrun.FullRowSelect = true;
            lstUrun.Columns.Clear();
            lstUrun.Columns.Add("ÜrünID", 70);
            lstUrun.Columns.Add("ÜrünAdı", 100);
            lstUrun.Columns.Add("Kategori", 70);
            lstUrun.Columns.Add("Miktar", 70);
            lstUrun.Columns.Add("Birim", 70);
            lstUrun.Columns.Add("TeminTarihi", 100);
            lstUrun.Columns.Add("Açıklama", 100);
            UrunListele();
            timer1.Interval = 5000;
            timer1.Start();
        }
        private void UrunListele()
        {
            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@" SELECT IDurun,  urunAdi,  kategori, miktar, birim, teminTarihi, aciklama FROM envanter", conn);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    lstUrun.Items.Clear();

                    while (dr.Read())
                    {
                        ListViewItem item = new ListViewItem(dr["IDurun"].ToString());
                        item.SubItems.Add(dr["urunAdi"].ToString());
                        item.SubItems.Add(dr["kategori"].ToString());
                        item.SubItems.Add(dr["miktar"].ToString());
                        item.SubItems.Add(dr["birim"].ToString());
                        item.SubItems.Add(dr["teminTarihi"] == DBNull.Value ? "" : Convert.ToDateTime(dr["teminTarihi"]).ToShortDateString());
                        item.SubItems.Add(dr["aciklama"].ToString());

                        lstUrun.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string birim;
            string kategori = kategoricbx.SelectedItem.ToString();

            if (kategori == "Temizlik" || kategori == "İçecek" || kategori == "Banyo")
                birim = "Adet";
            else if (kategori == "Tahıl" || kategori == "Sebze" || kategori == "Meyve")
                birim = "Kg";
            else
                birim = "";

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO envanter (urunAdi, kategori, miktar, birim, teminTarihi, aciklama)VALUES (@urunAdi, @kategori, @miktar, @birim, @teminTarihi, @aciklama)", conn);

                cmd.Parameters.AddWithValue("@urunAdi", urunadiTXT.Text);
                cmd.Parameters.AddWithValue("@kategori", kategori);
                cmd.Parameters.AddWithValue("@miktar", Convert.ToInt32(miktarTXT.Text));
                cmd.Parameters.AddWithValue("@birim", birim);
                cmd.Parameters.AddWithValue("@teminTarihi", DateTime.Now);
                cmd.Parameters.AddWithValue("@aciklama", aciklamaTXT.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Ürün başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListele();
        }
    }
}
