using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagementSystem
{
    public partial class MusteriForm : Form
    {
        private int MusteriID;
        public MusteriForm(int musteriID)
        {
            InitializeComponent();
            MusteriID = musteriID;
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT isim, soyisim FROM musteriler WHERE IDmusteri = @id",conn);

                cmd.Parameters.AddWithValue("@id", MusteriID);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    glabel.Text = "Hoş Geldiniz " + dr["isim"].ToString() + " " + dr["soyisim"].ToString();
                }
                dr.Close();
            }
            istpnl.Visible = false;
            siparispnl.Visible = false;
            sepetlst.Items.Clear();
            sepetlst.Columns.Clear();
            sepetlst.View = View.Details;
            sepetlst.FullRowSelect = true;
            sepetlst.Columns.Add("Ürün Adı", 150);
            sepetlst.Columns.Add("Fiyat", 70);
        }
        private void cmbistek_SelectedIndexChanged(object sender, EventArgs e)
        {
            hizmetlst.Items.Clear();
            hizmetlst.Items.Clear();
            hizmetlst.Columns.Clear();
            hizmetlst.View = View.Details;
            hizmetlst.FullRowSelect = true;
            hizmetlst.Columns.Add("Hizmetadi", 400);

            string secilenKategori = cmbistek.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT Hizmetadi FROM hizmet WHERE Hizmetkategori = @kategori",
                    conn
                );

                cmd.Parameters.AddWithValue("@kategori", secilenKategori);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    hizmetlst.Items.Add(dr["Hizmetadi"].ToString());
                }
                dr.Close();
            }
        }
        //siparişler için seçilen combobox değerine göre ürünleri listeler
        private void cmbsiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urunlst.Items.Clear();
            Urunlst.Columns.Clear();
            Urunlst.View = View.Details;
            Urunlst.FullRowSelect = true;

            // sütunları ekle
            Urunlst.Columns.Add("Ürün Adı", 120);
            Urunlst.Columns.Add("İçerik", 180);
            Urunlst.Columns.Add("Fiyat", 70);

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd;

                if (cmbsiparis.SelectedItem.ToString() == "Yemekler")
                {
                    cmd = new SqlCommand("SELECT UrunAdi, Fiyat FROM Urunler WHERE Kategori = 'Yemek'", conn);
                }
                else if (cmbsiparis.SelectedItem.ToString() == "İçecekler")
                {
                    cmd = new SqlCommand("SELECT UrunAdi, Fiyat FROM Urunler WHERE Kategori = 'İçecek'", conn);
                }
                else // Menüler
                {
                    cmd = new SqlCommand("SELECT MenuAdi AS UrunAdi, Menuicerik, Fiyat FROM Menuler", conn);
                }

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string urunAdi = dr["UrunAdi"].ToString();
                        string icerik = "-"; // default
                        if (cmbsiparis.SelectedItem.ToString() == "Menüler")
                        {
                            icerik = dr["Menuicerik"] != DBNull.Value ? dr["Menuicerik"].ToString() : "-";
                        }
                        string fiyat = dr["Fiyat"].ToString();

                        ListViewItem item = new ListViewItem(urunAdi);
                        item.SubItems.Add(icerik);
                        item.SubItems.Add(fiyat);

                        Urunlst.Items.Add(item);
                    }
                }
            }

        }
        //seçilen ürünü sepete ekler
        private void gondersipbtn_Click(object sender, EventArgs e)
        {
            if (Urunlst.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen eklemek istediğiniz ürünü seçin.");
                return;
            }

            foreach (ListViewItem item in Urunlst.SelectedItems)
            {
                string urunAdi = item.SubItems[0].Text;
                string fiyat = item.SubItems.Count > 2 ? item.SubItems[2].Text : item.SubItems[1].Text;

                ListViewItem newItem = new ListViewItem(urunAdi);
                newItem.SubItems.Add(fiyat);
                sepetlst.Items.Add(newItem);
            }

            // Toplam fiyat = artık 2 sütun olduğu için SubItems[1]
            decimal toplam = 0;
            foreach (ListViewItem item in sepetlst.Items)
            {
                toplam += Convert.ToDecimal(item.SubItems[1].Text);
            }
            fiyatlbl.Text = toplam.ToString("C2");
        }
        //sepetteki ürünleri faturaya ve siparişe ekler
        private void siparisgbtn_Click(object sender, EventArgs e)
        {
            if (sepetlst.Items.Count == 0)
            {
                MessageBox.Show("Sepette ürün bulunmuyor!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    //IDoda yı musteriID den alıyor
                    SqlCommand cmdOda = new SqlCommand(
                        "SELECT IDoda FROM rezervasyon WHERE IDmusteri = @musteriID",
                        conn, trans);
                    cmdOda.Parameters.AddWithValue("@musteriID", MusteriID);

                    object result = cmdOda.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Müşterinin aktif bir odası bulunamadı!");
                        trans.Rollback();
                        return;
                    }

                    int IDoda = Convert.ToInt32(result);

                    decimal toplamFiyat = 0;

                    // sepetteki ürünler sipariş kısmına gönderilir
                    foreach (ListViewItem item in sepetlst.Items)
                    {
                        string urunAdi = item.SubItems[0].Text;
                        decimal urunFiyat = Convert.ToDecimal(item.SubItems[1].Text);

                        SqlCommand cmdSiparis = new SqlCommand(
                            "INSERT INTO Siparisler (IDoda, Urun) VALUES (@IDoda, @Urun)",
                            conn, trans);
                        cmdSiparis.Parameters.AddWithValue("@IDoda", IDoda);
                        cmdSiparis.Parameters.AddWithValue("@Urun", urunAdi);
                        cmdSiparis.Parameters.AddWithValue("@Fiyat", urunFiyat);
                        cmdSiparis.ExecuteNonQuery();

                        toplamFiyat += urunFiyat;
                    }

                    // fatura tablosundan tutar güncelleme
                    SqlCommand cmdFatura = new SqlCommand(
                        "UPDATE Fatura SET Tutar = ISNULL(Tutar, 0) + @toplam WHERE IDoda = @IDoda",
                        conn, trans);
                    cmdFatura.Parameters.AddWithValue("@toplam", toplamFiyat);
                    cmdFatura.Parameters.AddWithValue("@IDoda", IDoda);
                    cmdFatura.ExecuteNonQuery();

                    trans.Commit();

                    MessageBox.Show("Sipariş başarıyla eklendi ve faturaya yansıtıldı!");
                    sepetlst.Items.Clear();
                    fiyatlbl.Text = "0,00 ₺";
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Sipariş eklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        //hizmet isteklerini gönderen buton
        private void istgbtn_Click(object sender, EventArgs e)
        {
            if (hizmetlst.SelectedItems == null)
            {
                MessageBox.Show("Lütfen bir hizmet seçiniz!");
                return;
            }

            string secilenHizmet = hizmetlst.SelectedItems.ToString();
            int odaID = 0;
            int personelID = 0;

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();

                // MÜŞTERİDEN ODA BUL
                SqlCommand cmdOda = new SqlCommand("SELECT odanumara FROM musteriler WHERE IDmusteri = @mid", conn);
                cmdOda.Parameters.AddWithValue("@mid", MusteriID);

                object odaResult = cmdOda.ExecuteScalar();

                if (odaResult == null || odaResult == DBNull.Value)
                {
                    MessageBox.Show("Bu müşteriye ait oda bulunamadı!");
                    return;
                }
                odaID = Convert.ToInt32(odaResult);

                //KAT HİZMETLERİ PERSONELİNİ AL
                SqlCommand cmdPersonel = new SqlCommand(
                    "SELECT TOP 1 IDpersonel FROM personel WHERE Pozisyon = 'Kat Hizmetleri'", conn);

                object personelResult = cmdPersonel.ExecuteScalar();
                if (personelResult == null)
                {
                    MessageBox.Show("Kat Hizmetleri personeli bulunamadı!");
                    return;
                }
                personelID = Convert.ToInt32(personelResult);

                //TEMİZLİK TABLOSUNA EKLE
                SqlCommand cmdInsert = new SqlCommand(
                    "INSERT INTO temizlik (IDoda, IDpersonel,durum) VALUES (@oda, @pid,0)",
                    conn);

                cmdInsert.Parameters.AddWithValue("@oda", odaID);
                cmdInsert.Parameters.AddWithValue("@pid", personelID);

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Temizlik isteği başarıyla oluşturuldu ✅");
            }
        }
        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glabel.Visible = false;
            siparispnl.Visible = true;
        }
        private void temizlikDeğişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glabel.Visible = false;
            istpnl.Visible = true;
        }
        private void geri1btn_Click(object sender, EventArgs e)
        {
            siparispnl.Visible = false;
        }
        private void geri2btn_Click(object sender, EventArgs e)
        {
            istpnl.Visible = false;
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


    }
}
