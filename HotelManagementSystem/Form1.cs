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

namespace HotelManagementSystem
{
    public partial class formGiris : Form
    {
        //05452545454
        //05454545455
        //05341256324
        //05345254572 //İK
        //05479981523 //Şef
        //05347852488 //Müdür
        public static string connectionString = @"Server=EMIRAY;Database=Hoteldb;Trusted_Connection=True;";
        string sqlIDMusteri = "SELECT IDmusteri FROM musteriler WHERE IDmusteri=@id";
        //string sqlPozisyon = "SELECT pozisyon FROM personel WHERE IDpersonel=@id"; // artık telefon üzerinden alınacak

        public formGiris()
        {
            InitializeComponent();
        }
        public static string GirisPozisyon;
        String sifre = "12345";
        private void formGiris_Load(object sender, EventArgs e)
        {
            panelpersonel.Visible = false;
            panelmusteri.Visible = false;
        }
        //telefon numarasına göre veri tabanından kontrol ile gerekli formu açar
        private void girisPbtn_Click(object sender, EventArgs e)
        {
            string pozisyon = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT pozisyon FROM personel WHERE telefon=@telefon";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@telefon", Pid_txt.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pozisyon = reader["pozisyon"].ToString();
                            GirisPozisyon = pozisyon;
                        }
                    }
                }
            }

            if (Psifre_txt.Text == sifre && !string.IsNullOrEmpty(pozisyon))
            {
                if (pozisyon == "Ön Büro")
                {
                    OnBuroform onBuroform = new OnBuroform();
                    onBuroform.Show();
                    this.Hide();
                }
                else if (pozisyon == "İnsan Kaynakları" || pozisyon == "Müdür" || pozisyon == "Şef")
                {
                    IKform ikForm = new IKform();
                    ikForm.Show();
                    this.Hide();
                }
                else if (pozisyon == "Kat Hizmetleri")
                {
                    kathizmet kathizmetForm = new kathizmet();
                    kathizmetForm.Show();
                    this.Hide();
                }
                else if (pozisyon == "Depo")
                {
                    Envanter envanterform = new Envanter();
                    envanterform.Show();
                    this.Hide();
                }
                Psifre_txt.Clear();
                Pid_txt.Text = "05";
            }
            else
            {
                Psifre_txt.Clear();
                Pid_txt.Text = "05";
                MessageBox.Show("Hatalı Şifre veya Telefon Numarası Girdiniz!");
            }
        }

        private void girisMbtn_Click(object sender, EventArgs e)
        {
            string girilenID = Mid_txt.Text.Trim();
            string girilenSifre = Msifre_txt.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IDmusteri FROM musteriler WHERE IDmusteri = @id", conn);
                cmd.Parameters.AddWithValue("@id", girilenID);

                object result = cmd.ExecuteScalar();

                if (result != null && girilenSifre == sifre)
                {
                    int seciliMusteriID = Convert.ToInt32(result);
                    MusteriForm musteriForm = new MusteriForm(seciliMusteriID);
                    musteriForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Şifre veya ID Girdiniz!");
                }
            }

            // Temizleme işlemi
            Msifre_txt.Clear();
            Mid_txt.Clear();
        }
        //şifreyi görünür görünmez yapma
        private void sifgoster_Click(object sender, EventArgs e)
        {
            Psifre_txt.PasswordChar = '\0';
            sifgoster.Visible = false;
            sifgizle.Visible = true;
        }
        private void sifgizle_Click(object sender, EventArgs e)
        {
            Psifre_txt.PasswordChar = '*';
            sifgizle.Visible = false;
            sifgoster.Visible = true;
        }
        private void sifgoster1_Click(object sender, EventArgs e)
        {
            Msifre_txt.PasswordChar = '\0';
            sifgoster1.Visible = false;
            sifgizle1.Visible = true;
        }

        private void sifgizle1_Click(object sender, EventArgs e)
        {
            Msifre_txt.PasswordChar = '*';
            sifgizle1.Visible = false;
            sifgoster1.Visible = true;
        }
        //panellerin visible kısmı
        private void btngeri2_Click(object sender, EventArgs e)
        {
            panelpersonel.Visible = false;
        }

        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelmusteri.Visible = true;
        }

        private void btngeri1_Click(object sender, EventArgs e)
        {
            panelmusteri.Visible = false;
        }

        private void personelGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelpersonel.Visible = true;
        }


    }
}
