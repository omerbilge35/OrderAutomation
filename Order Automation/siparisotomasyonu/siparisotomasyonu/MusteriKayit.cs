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

namespace siparisotomasyonu
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }

        SqlConnection x = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            x.Open();

            SqlCommand komut = new SqlCommand("insert into musteri(ad,soyad,adres,tcno,sifre) values(@ad,@soyad,@adres,@tcno,@sifre)", x);
            komut.Parameters.AddWithValue("@ad", txt_ad_kayit.Text);
            komut.Parameters.AddWithValue("@soyad", txt_soyad_kayit.Text);
            komut.Parameters.AddWithValue("@adres", txt_adres_kayit.Text);
            komut.Parameters.AddWithValue("@tcno", txt_tc_kayit.Text);
            komut.Parameters.AddWithValue("@sifre", txt_sifre_kayit.Text);
            komut.ExecuteNonQuery();

            x.Close();
            MessageBox.Show("Müşteri kaydı eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_menuyedon_kayit_Click(object sender, EventArgs e)
        {
            AnaSayfa don = new AnaSayfa();
            don.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
