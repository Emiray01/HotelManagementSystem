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
