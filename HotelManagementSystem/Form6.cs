using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class IKform : Form
    {
        SqlConnection conn = new SqlConnection(formGiris.connectionString);
        public IKform()
        {
            InitializeComponent();
        }
        private void IKform_Load(object sender, EventArgs e)
        {
            string pozisyon = formGiris.GirisPozisyon;

            if (string.IsNullOrEmpty(pozisyon))
            {
                MessageBox.Show("Yetki bilgisi alınamadı!",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            pozisyon = pozisyon.Trim();

            // Default: her şeyi kapat (güvenli başlangıç)
            vardiyagbx.Visible = false;
            personelekgbp.Visible = false;
            zamgbp.Visible = false;
            iscikar.Visible = false;

            // Müdür ve Şef → Vardiya
            if (pozisyon == "Müdür" || pozisyon == "Şef")
            {
                vardiyagbx.Visible = true;
            }

            // İnsan Kaynakları ve Müdür → Personel ekleme + Zam
            if (pozisyon == "İnsan Kaynakları" || pozisyon == "Müdür")
            {
                personelekgbp.Visible = true;
                zamgbp.Visible = true;
            }

            // Sadece İnsan Kaynakları → İşten çıkar
            if (pozisyon == "İnsan Kaynakları")
            {
                iscikar.Visible = true;
            }
            Personelcbx.Items.AddRange(new string[] { "İnsan Kaynakları", "Ön Büro" , "Kat Hizmetleri" , "Depo" , "Şef" , "Müdür" });
            zamcbx.Items.AddRange(new string[] { "%10", "%20", "%30", "%40", "%50" });
            yonetimpnl.Visible = false;
            timer1.Interval = 15000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            personelLst.View = View.Details;
            personelLst.FullRowSelect = true;
            personelLst.GridLines = true;
            personelLst.Columns.Clear();
            personelLst.Columns.Add("ID", 60);
            personelLst.Columns.Add("İsim", 120);
            personelLst.Columns.Add("Soyad", 120);
            personelLst.Columns.Add("Yaş", 60);
            personelLst.Columns.Add("Pozisyon", 120);
            personelLst.Columns.Add("Vardiya", 100);
            personelLst.Columns.Add("Maaş", 100);
            PersonelListele();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PersonelListele();
        }
        //fonksiyonlar başlangıç
        void PersonelListele()
        {
            personelLst.Items.Clear();

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM personel WHERE durum = 1", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["IDpersonel"].ToString());
                    item.SubItems.Add(dr["isim"].ToString());
                    item.SubItems.Add(dr["soyad"].ToString());
                    item.SubItems.Add(dr["yas"].ToString());
                    item.SubItems.Add(dr["pozisyon"].ToString());
                    item.SubItems.Add(dr["vardiya"].ToString());
                    item.SubItems.Add(dr["maas"].ToString());
                    item.Tag = dr["IDpersonel"];
                    personelLst.Items.Add(item);
                }

                conn.Close();
            }
        }
        //fonksiyonlar bitiş
        //buton komutları başlangıç
        private void vardiyabtn_Click(object sender, EventArgs e)
        {
            if (personelLst.SelectedItems.Count == 0)
            {
                MessageBox.Show("Personel seç!");
                return;
            }

            if (Vardiyacmb.SelectedIndex == -1)
            {
                MessageBox.Show("Vardiya seç!");
                return;
            }
            int IDpersonel = Convert.ToInt32(personelLst.SelectedItems[0].SubItems[0].Text);
            string vardiya = Vardiyacmb.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE personel SET vardiya = @vardiya WHERE IDpersonel = @id", conn);

                cmd.Parameters.AddWithValue("@vardiya", vardiya);
                cmd.Parameters.AddWithValue("@id", IDpersonel);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Vardiya güncellendi.");
        }
        private void iscikar_Click(object sender, EventArgs e)
        {
            if(personelLst.SelectedItems.Count == 0)
    {
                MessageBox.Show("Lütfen çıkış verilecek personeli seçin!");
                return;
            }

            int personelID = Convert.ToInt32(personelLst.SelectedItems[0].SubItems[0].Text);

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE personel SET durum = 0 WHERE IDpersonel = @id", conn);
                cmd.Parameters.AddWithValue("@id", personelID);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Personel çıkışı yapıldı!");
            PersonelListele();
        }
        private void Prsgirbtn_Click(object sender, EventArgs e)
        {
            if (padtxt.Text == "" || psoyadtxt.Text == "" || yastxt.Text == ""
                || teltxt.Text == "" || Personelcbx.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO personel (isim, soyad, yas, pozisyon, telefon)
                  VALUES (@isim, @soyad, @yas, @pozisyon, @telefon)", conn);

                    cmd.Parameters.AddWithValue("@isim", padtxt.Text);
                    cmd.Parameters.AddWithValue("@soyad", psoyadtxt.Text);
                    cmd.Parameters.AddWithValue("@yas", Convert.ToInt32(yastxt.Text));
                    cmd.Parameters.AddWithValue("@pozisyon", Personelcbx.Text);
                    cmd.Parameters.AddWithValue("@telefon", teltxt.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Personel başarıyla eklendi ✅",
                                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // İstersen alanları temizle
                    padtxt.Clear();
                    psoyadtxt.Clear();
                    yastxt.Clear();
                    teltxt.Clear();
                    Personelcbx.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:\n" + ex.Message,
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void zambtn_Click(object sender, EventArgs e)
        {
            if (personelLst.SelectedItems.Count == 0 || zamcbx.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen personel ve zam oranı seçin!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string zamText = zamcbx.Text.Replace("%", "");
            decimal zamOrani = Convert.ToDecimal(zamText) / 100;
            int idPersonel = Convert.ToInt32(personelLst.SelectedItems[0].Tag);

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE personel SET maas = maas + (maas * @zam) WHERE IDpersonel = @id", conn);

                    cmd.Parameters.AddWithValue("@zam", zamOrani);
                    cmd.Parameters.AddWithValue("@id", idPersonel);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Zam başarıyla uygulandı 💰",
                                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Listeyi yenile
                    PersonelListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:\n" + ex.Message,
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void gzambtn_Click(object sender, EventArgs e)
        {
            if (zamcbx.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen zam oranı seçin!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // %10 → 0.10
            string zamText = zamcbx.Text.Replace("%", "");
            decimal zamOrani = Convert.ToDecimal(zamText) / 100;

            DialogResult dr = MessageBox.Show(
                "TÜM personele zam uygulanacak. Emin misiniz?",
                "Genel Zam Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"UPDATE personel SET maas = ROUND(maas + (maas * @zam), 2)", conn);

                    cmd.Parameters.AddWithValue("@zam", zamOrani);

                    int etkilenenKayit = cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        $"{etkilenenKayit} personele zam uygulandı 💰",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    PersonelListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu:\n" + ex.Message,
                                    "Hata",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGiris giris = Application.OpenForms["formGiris"] as formGiris;
            if (giris != null)
            {
                giris.Show();
            }
            this.Close();
        }
        private void geribtn1_Click(object sender, EventArgs e)
        {
            yonetimpnl.Visible = false;
        }
        private void personelYönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetimpnl.Visible = true;
        }
    }
}