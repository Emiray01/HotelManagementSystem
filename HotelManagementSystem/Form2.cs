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
        private int seciliOdaID = -1;
        public OnBuroform()
        {
            InitializeComponent();
        }
        //loadda odaları listview üzerinden listeliyor
        private void OnBuroform_Load(object sender, EventArgs e)
        {
            timer1.Interval = 15000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            faturapnl.Visible = false;
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
            faturalst.View = View.Details;
            faturalst.FullRowSelect = true;
            faturalst.Columns.Clear();
            faturalst.Columns.Add("Tutar", 80);
            faturalst.Columns.Add("Vergi", 80);
            faturalst.Columns.Add("Ödeme Durumu", 100);
            faturalst.Columns.Add("Oda ID", 60);
            faturalst.Columns.Add("Tarih", 120);
            FaturaListele();
            OdaListele();

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
            FaturaListele();
        }
        //fonksiyonlar başlangıç
        private void OdaListele()
        {
            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT o.odanumara,  CASE o.turu   WHEN 1 THEN 'Tek Kişilik'  WHEN 2 THEN 'Çift Kişilik' WHEN 3 THEN 'Suit' ELSE 'Diğer'  END AS turu, o.tutar AS odatutari,  o.durumu,  o.IDfatura,  ISNULL(m.isim + ' ' + m.soyisim, '') AS MusteriAdi, ISNULL(m.TCNo, '') AS TCNo, CASE WHEN o.IDfatura IS NOT NULL THEN r.giristarih ELSE NULL END AS giristarih, CASE WHEN o.IDfatura IS NOT NULL THEN r.cikistarih ELSE NULL END AS cikistarih,ISNULL(f.tutar, 0) AS faturatutari, ISNULL(f.odemedurumu, 0) AS odemedurumu FROM odalar o LEFT JOIN musteriler m ON m.odanumara = o.odanumara LEFT JOIN rezervasyon r ON r.IDoda = o.IDoda LEFT JOIN fatura f ON f.IDfatura = o.IDfatura", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                lstOdaliste.Items.Clear();

                while (dr.Read())
                {
                    string durum = Convert.ToBoolean(dr["durumu"]) ? "Dolu" : "Boş";

                    object faturaObj = dr["faturatutari"];
                    decimal faturatutari = faturaObj != DBNull.Value ? Convert.ToDecimal(faturaObj) : 0;

                    object odemeObj = dr["odemedurumu"];
                    string odeme = (odemeObj != DBNull.Value && Convert.ToBoolean(odemeObj)) ? "Ödendi" : "Ödenmedi";

                    ListViewItem item = new ListViewItem(dr["odanumara"].ToString());
                    item.SubItems.Add(dr["turu"].ToString());
                    item.SubItems.Add(dr["odatutari"].ToString());
                    item.SubItems.Add(durum);
                    item.SubItems.Add(dr["MusteriAdi"].ToString());
                    item.SubItems.Add(dr["TCNo"].ToString());
                    item.SubItems.Add(dr["giristarih"] == DBNull.Value ? "" : Convert.ToDateTime(dr["giristarih"]).ToShortDateString());
                    item.SubItems.Add(dr["cikistarih"] == DBNull.Value ? "" : Convert.ToDateTime(dr["cikistarih"]).ToShortDateString());
                    item.SubItems.Add(faturatutari.ToString());
                    item.SubItems.Add(odeme);

                    lstOdaliste.Items.Add(item);
                }

            }
        }
        private void FaturaListele()
        {
            using (SqlConnection conn = new SqlConnection(formGiris.connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT tutar, vergi, odemedurumu, IDoda, tarih FROM fatura WHERE odemedurumu = 0", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                faturalst.Items.Clear();

                while (dr.Read())
                {
                    string odeme = Convert.ToBoolean(dr["odemedurumu"]) ? "Ödendi" : "Ödenmedi";

                    ListViewItem item = new ListViewItem(dr["tutar"].ToString());
                    item.SubItems.Add(dr["vergi"].ToString());
                    item.SubItems.Add(odeme);
                    item.SubItems.Add(dr["IDoda"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(dr["tarih"]).ToString("dd.MM.yyyy HH:mm"));

                    faturalst.Items.Add(item);
                }
            }
        }
        //fonksiyonlar bitiş
        //buton komutları
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
        //buton komutları
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
                //ödeme durumu kontrolü
                SqlCommand cmdCheckPay = new SqlCommand(@"SELECT odemedurumu FROM fatura WHERE IDoda = (SELECT IDoda FROM odalar WHERE odanumara = @odaNo)", conn);

                cmdCheckPay.Parameters.AddWithValue("@odaNo", seciliOdaID);
                
                bool odendi = Convert.ToBoolean(cmdCheckPay.ExecuteScalar() ?? false);

                if (!odendi)
                {
                    MessageBox.Show("Ödeme yapılmamış! Lütfen önce ödeme işlemini gerçekleştirin.");
                    return;
                }
                SqlTransaction trans = conn.BeginTransaction();
                //check out sırasında hata ayıklama
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

            if (faturalst.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir fatura seçiniz");
                return;
            }
            MessageBox.Show("Pos Cihazına Aktarılıyor");

            DialogResult posOnay = MessageBox.Show(
                "Ödeme işlemini onaylıyor musunuz?","POS Ödeme Onayı",MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if (posOnay == DialogResult.Yes)
            {
                conn.Open();
                int odaID = Convert.ToInt32(faturalst.SelectedItems[0].SubItems[3].Text);
                SqlCommand cmd = new SqlCommand("UPDATE fatura SET odemedurumu = 1 WHERE IDoda = @id", conn);
                cmd.Parameters.AddWithValue("@id", odaID);
                int etkilenen = cmd.ExecuteNonQuery();
                FaturaListele();
                if (etkilenen > 0)
                    MessageBox.Show("Ödeme başarıyla alındı!");
                else
                    MessageBox.Show("Fatura kaydı bulunamadı!");
            }
            else
            {
                MessageBox.Show("Ödeme alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void nakitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (faturalst.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir fatura seçiniz");
                return;
            }
            MessageBox.Show("Ödeme Alınıyor");

            DialogResult posOnay = MessageBox.Show(
                "Ödeme işlemini onaylıyor musunuz?", "POS Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (posOnay == DialogResult.Yes)
            {
                conn.Open();
                int odaID = Convert.ToInt32(faturalst.SelectedItems[0].SubItems[3].Text);
                SqlCommand cmd = new SqlCommand("UPDATE fatura SET odemedurumu = 1 WHERE IDoda = @id", conn);
                cmd.Parameters.AddWithValue("@id", odaID);
                int etkilenen = cmd.ExecuteNonQuery();
                FaturaListele();
                if (etkilenen > 0)
                    MessageBox.Show("Ödeme başarıyla alındı!");
                else
                    MessageBox.Show("Fatura kaydı bulunamadı!");
            }
            else
            {
                MessageBox.Show("Ödeme alınamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //buton komutları
        //panel görünüm
        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelcheckin.Visible = true;
        }
        private void fatura_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faturapnl.Visible = true;
        }
        private void Geribtn_Click(object sender, EventArgs e)
        {
            panelcheckin.Visible = false;
        }
        private void geribtn1_Click(object sender, EventArgs e)
        {
            faturapnl.Visible=false;
        }
        //panel görünüm
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