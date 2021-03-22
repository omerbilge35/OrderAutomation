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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        SqlConnection x = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");

        private void btn_anamenu_yonetici_Click(object sender, EventArgs e)
        {
            AnaSayfa don = new AnaSayfa();
            don.Show();
            this.Close();
        }

        private void btn_giris_yonetici_Click(object sender, EventArgs e)
        {
            x.Open();
            string giris = "SELECT * from yonetici where yon_sifre=@yon_sifre";
            SqlCommand komut = new SqlCommand(giris, x);
            komut.Parameters.AddWithValue("@yon_sifre", txt_sifre_yonetici.Text);

            SqlDataAdapter d = new SqlDataAdapter(komut);
            SqlDataReader r = komut.ExecuteReader();
            
            if(r.Read())
            {
                txt_sifre_yonetici.Text = r["yon_sifre"].ToString();

                YoneticiPanel y = new YoneticiPanel();
                y.Show();
                this.Close();
            }
            else
               MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
         
            x.Close();

        }
       
        private void txt_sifre_yonetici_TextChanged_1(object sender, EventArgs e)
        {
            txt_sifre_yonetici.PasswordChar ='*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                
                txt_sifre_yonetici.PasswordChar = '\0';
            }
            
            else
            {
                txt_sifre_yonetici.PasswordChar = '*';
            }
        }
    }
}
