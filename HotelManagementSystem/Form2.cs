using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace HotelManagementSystem
{
    public partial class OnBuroform : Form
    {
        SqlConnection conn = new SqlConnection(formGiris.connectionString);
        private int seciliOdaNo = -1;   
        public OnBuroform()
        {
            InitializeComponent();
        }
        //loadda odaları listview üzerinden listeliyor
        private void OnBuroform_Load(object sender, EventArgs e)
        {
            panelcheckin.Visible = false;
            lstOdaliste.View = View.Details;
            lstOdaliste.FullRowSelect = true;
            lstOdaliste.Columns.Clear();
            lstOdaliste.Columns.Add("Oda No", 70);
            lstOdaliste.Columns.Add("Türü", 100);
            lstOdaliste.Columns.Add("Tutar", 70);
            lstOdaliste.Columns.Add("Durum", 70);
            lstOdaliste.Columns.Add("Müşteri",70);
            lstOdaliste.Columns.Add("TC No",100);           
            lstOdaliste.Columns.Add("Giriş Tarihi",70);
            lstOdaliste.Columns.Add("Çıkış Tarihi", 70);
            lstOdaliste.Columns.Add("Fatura Tutarı", 70);
            lstOdaliste.Columns.Add("Ödeme Durumu", 70);
            OdaListele();
            timer1.Interval = 5000; 
            timer1.Start();
        }
        private void lstOdaliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOdaliste.SelectedItems.Count > 0)
            {
                seciliOdaNo = Convert.ToInt32(lstOdaliste.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                seciliOdaNo = -1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            OdaListele();
        }

        private void OdaListele()
        {
            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    o.odanumara,
                    CASE o.turu 
                        WHEN 1 THEN 'Tek Kişilik'
                        WHEN 2 THEN 'Çift Kişilik'
                        WHEN 3 THEN 'Suit'
                        ELSE 'Diğer' 
                    END AS turu,
                    o.tutar AS odatutari,
                    o.durumu,
                    ISNULL(m.isim + ' ' + m.soyisim, '') AS MusteriAdi,
                    ISNULL(m.TCNo, '') AS TCNo,
                    r.giristarih,
                    r.cikistarih,
                    ISNULL(f.tutar, 0) AS faturatutari,
                    ISNULL(f.odemedurumu, 0) AS odemedurumu
                FROM odalar o
                LEFT JOIN musteriler m ON m.odanumara = o.odanumara
                LEFT JOIN rezervasyon r ON r.IDoda = o.IDoda
                LEFT JOIN fatura f ON f.IDoda = o.IDoda
                ", conn);

                SqlDataReader dr = cmd.ExecuteReader();
                lstOdaliste.Items.Clear();

                while (dr.Read())
                {
                    string durum = Convert.ToBoolean(dr["durumu"]) ? "Dolu" : "Boş";
                    string odeme = Convert.ToBoolean(dr["odemedurumu"]) ? "Ödendi" : "Ödenmedi";

                    ListViewItem item = new ListViewItem(dr["odanumara"].ToString());
                    item.SubItems.Add(dr["turu"].ToString());
                    item.SubItems.Add(dr["odatutari"].ToString());
                    item.SubItems.Add(durum);
                    item.SubItems.Add(dr["MusteriAdi"].ToString());
                    item.SubItems.Add(dr["TCNo"].ToString());
                    item.SubItems.Add(dr["giristarih"] == DBNull.Value ? "" : Convert.ToDateTime(dr["giristarih"]).ToShortDateString());
                    item.SubItems.Add(dr["cikistarih"] == DBNull.Value ? "" : Convert.ToDateTime(dr["cikistarih"]).ToShortDateString());
                    item.SubItems.Add(dr["faturatutari"].ToString());
                    item.SubItems.Add(odeme);

                    lstOdaliste.Items.Add(item);
                }
            }
        }
        private void btnChin_Click(object sender, EventArgs e)
        {
            if (lstOdaliste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir oda seçiniz!");
                return;
            }

            // Seçili satırdan oda numarasını alıyoruz
            int seciliOdaID = Convert.ToInt32(lstOdaliste.SelectedItems[0].SubItems[0].Text);

            string ad = txtad.Text.Trim();
            string soyad = txtsoyad.Text.Trim();
            string tc = txttc.Text.Trim();
            DateTime girisTarih = gtarih.Value;
            DateTime cikisTarih = ctarih.Value;

            if (cikisTarih <= girisTarih)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdMusteri = new SqlCommand(@"
                    INSERT INTO musteriler (isim, soyisim, TCNo, odanumara)
                    VALUES (@isim, @soyisim, @tc, @odanumara);
                    SELECT SCOPE_IDENTITY();", conn, trans);
                    cmdMusteri.Parameters.AddWithValue("@isim", ad);
                    cmdMusteri.Parameters.AddWithValue("@soyisim", soyad);
                    cmdMusteri.Parameters.AddWithValue("@tc", tc);
                    cmdMusteri.Parameters.AddWithValue("@odanumara", seciliOdaID);

                    int musteriID = Convert.ToInt32(cmdMusteri.ExecuteScalar());

                    SqlCommand cmdRez = new SqlCommand(@"
                    INSERT INTO rezervasyon (IDmusteri, IDoda, giristarih, cikistarih)
                    SELECT @musteriID, IDoda, @giris, @cikis 
                    FROM odalar WHERE odanumara = @odaNo", conn, trans);
                    cmdRez.Parameters.AddWithValue("@musteriID", musteriID);
                    cmdRez.Parameters.AddWithValue("@giris", girisTarih);
                    cmdRez.Parameters.AddWithValue("@cikis", cikisTarih);
                    cmdRez.Parameters.AddWithValue("@odaNo", seciliOdaID);
                    cmdRez.ExecuteNonQuery();

                    SqlCommand cmdOda = new SqlCommand("UPDATE odalar SET durumu = 1 WHERE odanumara = @odaNo", conn, trans);
                    cmdOda.Parameters.AddWithValue("@odaNo", seciliOdaID);
                    cmdOda.ExecuteNonQuery();

                    trans.Commit();

                    MessageBox.Show("Check-in işlemi başarıyla tamamlandı!");
                    OdaListele();

                    txtad.Clear();
                    txtsoyad.Clear();
                    txttc.Clear();
                    gtarih.Value = DateTime.Now;
                    ctarih.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Check-in sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnChout_Click(object sender, EventArgs e)
        {
            if (lstOdaliste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir oda seçiniz!");
                return;
            }

            int seciliOdaID = Convert.ToInt32(lstOdaliste.SelectedItems[0].SubItems[0].Text);

            DialogResult result = MessageBox.Show("Bu odadan çıkış işlemi yapılsin mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdOda = new SqlCommand("UPDATE odalar SET durumu = 0 WHERE odanumara = @odaNo", conn, trans);
                    cmdOda.Parameters.AddWithValue("@odaNo", seciliOdaID);
                    cmdOda.ExecuteNonQuery();

                    SqlCommand cmdMusteri = new SqlCommand("UPDATE musteriler SET odanumara = 0 WHERE odanumara = @odaNo", conn, trans);
                    cmdMusteri.Parameters.AddWithValue("@odaNo", seciliOdaID);
                    cmdMusteri.ExecuteNonQuery();

                    SqlCommand cmdFatura = new SqlCommand(@"
                    UPDATE fatura
                    SET tutar = 0, IDoda = NULL
                    WHERE IDoda IN (SELECT IDoda FROM odalar WHERE odanumara = @odaNo)", conn, trans);
                    cmdFatura.Parameters.AddWithValue("@odaNo", seciliOdaID);
                    cmdFatura.ExecuteNonQuery();

                    SqlCommand cmdRez = new SqlCommand(@"
                    DELETE FROM rezervasyon
                    WHERE IDoda IN (SELECT IDoda FROM odalar WHERE odanumara = @odaNo)", conn, trans);
                    cmdRez.Parameters.AddWithValue("@odaNo", seciliOdaID);
                    cmdRez.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO TemizlikIstekleri (OdaID, Tarih, Durum) VALUES (@odaID, @tarih, 0)", conn, trans);
                    cmd2.Parameters.AddWithValue("@odaID", seciliOdaID);
                    cmd2.Parameters.AddWithValue("@tarih", DateTime.Now);
                    cmd2.ExecuteNonQuery();
                    trans.Commit();

                    MessageBox.Show("Check-out işlemi başarıyla tamamlandı!");

                    txtad.Clear();
                    txtsoyad.Clear();
                    txttc.Clear();
                    gtarih.Value = DateTime.Now;
                    ctarih.Value = DateTime.Now;
                    OdaListele();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Check-out sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void krediBankaKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pos Cihazına Aktarılıyor");
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelcheckin.Visible = true;
        }

        private void Geribtn_Click(object sender, EventArgs e)
        {
            panelcheckin.Visible = false;
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
