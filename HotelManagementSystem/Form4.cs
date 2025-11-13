using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class kathizmet : Form
    {
        public kathizmet()
        {
            InitializeComponent();
        }

        private void kathizmet_Load(object sender, EventArgs e)
        {
            pnlodatem.Visible = false;
            pnlsipariş.Visible = false;

            // Sipariş ListView ayarları
            lstsiparis.View = View.Details;
            lstsiparis.FullRowSelect = true;
            lstsiparis.GridLines = true;
            lstsiparis.Columns.Clear();
            lstsiparis.Columns.Add("Sipariş ID", 80);
            lstsiparis.Columns.Add("Oda No", 80);
            lstsiparis.Columns.Add("Ürün", 150);
            lstsiparis.Columns.Add("Durum", 120);

            // Temizlik ListView ayarları
            lsttemizlik.View = View.Details;
            lsttemizlik.FullRowSelect = true;
            lsttemizlik.GridLines = true;
            lsttemizlik.Columns.Clear();
            lsttemizlik.Columns.Add("ID", 50);
            lsttemizlik.Columns.Add("Oda ID", 80);
            lsttemizlik.Columns.Add("Tarih", 150);
            lsttemizlik.Columns.Add("Durum", 100);

            siparisListele();
            temizlikyukle();

            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        //fonksiyonlar başlangıç
        private void temizlikyukle()
        {
            lsttemizlik.Items.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(formGiris.connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT IDTemizlik, IDoda, temizlikTarihi, durum FROM temizlik WHERE durum = 0", con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"ID: {dr["IDTemizlik"]}, Durum: {dr["durum"]}");//debug:Debug: veri tabanından çekilen kayıtları kontrol etmek için
                            ListViewItem item = new ListViewItem(dr["IDTemizlik"].ToString());
                            item.SubItems.Add(dr["IDoda"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(dr["temizlikTarihi"]).ToString("dd.MM.yyyy HH:mm"));
                            item.SubItems.Add(dr["durum"].ToString());
                            lsttemizlik.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Temizlik isteği yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void siparisListele()
        {
            lstsiparis.Items.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(formGiris.connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT IDsiparis, IDoda, urun, durum FROM siparisler WHERE durum = 0", con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
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
            catch (Exception ex)
            {
                MessageBox.Show("Siparişler yüklenirken hata oluştu: " + ex.Message);
            }
        }
        //fonksiyonlar bitiş
        private void timer1_Tick(object sender, EventArgs e)
        {
            siparisListele();
            temizlikyukle();
        }
        //siparişler kısmı buton ve diğer işlemler
        private void btnonay_Click(object sender, EventArgs e)
        {
            if (lstsiparis.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen teslim edilecek bir siparişi seçin.");
                return;
            }

            int siparisID = int.Parse(lstsiparis.SelectedItems[0].Text);

            try
            {
                using (SqlConnection con = new SqlConnection(formGiris.connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE siparisler SET durum = 1 WHERE IDsiparis = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", siparisID);
                        cmd.ExecuteNonQuery();
                    }
                }

                siparisListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş güncellenirken hata oluştu: " + ex.Message);
            }
        }
        //temizlik kısmı buton ve diğer işlemler
        private void Temizbitbtn_Click(object sender, EventArgs e)
        {
            if (lsttemizlik.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen tamamlanan temizlik isteğini seçin.");
                return;
            }

            int istekID = int.Parse(lsttemizlik.SelectedItems[0].Text);

            try
            {
                using (SqlConnection con = new SqlConnection(formGiris.connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE temizlik SET durum = 1, temizlikTarihi = @tarih WHERE IDTemizlik = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", istekID);
                        cmd.Parameters.AddWithValue("@tarih", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

                temizlikyukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Temizlik durumu güncellenirken hata oluştu: " + ex.Message);
            }
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

        private void btngeri2_Click(object sender, EventArgs e)
        {
            pnlodatem.Visible = false;
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGiris giris = Application.OpenForms["formGiris"] as formGiris;
            if (giris != null)
            {
                giris.Show();
            }
            this.Close();
        }
    }
}
