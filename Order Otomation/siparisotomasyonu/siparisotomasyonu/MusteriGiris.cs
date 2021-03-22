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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }

        SqlConnection x = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }

        private void txt_tcno_giris_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_anamenu_giris_Click(object sender, EventArgs e)
        {
            AnaSayfa don = new AnaSayfa();
            don.Show();
            this.Close();
            
            
            
            
        }
        static public string musteriIDsi;
        private void btn_musteri_giris_Click(object sender, EventArgs e)
        {
            x.Open();
            string giris = "SELECT * from musteri where tcno=@tcno AND sifre=@sifre";
            SqlCommand komut = new SqlCommand(giris, x);
            komut.Parameters.AddWithValue("@tcno", txt_tcno_giris.Text);
            komut.Parameters.AddWithValue("@sifre", txt_sifre_giris.Text);

            SqlDataAdapter d = new SqlDataAdapter(komut);
            SqlDataReader r = komut.ExecuteReader();

            if (r.Read())
            { 
                
                txt_tcno_giris.Text = r["tcno"].ToString();
                txt_sifre_giris.Text = r["sifre"].ToString();
                musteriIDsi = r["musteriID"].ToString();

                Alisveris av = new Alisveris();
                av.Show();
                this.Close();
            }
            else
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");

            x.Close();

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                txt_sifre_giris.PasswordChar = '\0';
            }

            else
            {
                txt_sifre_giris.PasswordChar = '*';
            }
        }

        private void txt_sifre_giris_TextChanged(object sender, EventArgs e)
        {
            txt_sifre_giris.PasswordChar = '*';
        }
    }
}
