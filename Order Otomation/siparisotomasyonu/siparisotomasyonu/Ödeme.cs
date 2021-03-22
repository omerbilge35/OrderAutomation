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
    public partial class Ödeme : Form
    {
        public Ödeme()
        {
            InitializeComponent();
        }

        SqlConnection d = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");
        DataSet daset = new DataSet();

        int aktifID = int.Parse(MusteriGiris.musteriIDsi);
        string odemeyontem;
        string adresbilgi;
        string urnAd;
        int urnAdet;
        float urnFiyat;
        float urnTFiyat;
        
        private void AdresBul()
        {
            d.Open();
            SqlCommand komut = new SqlCommand("Select adres from musteri where musteriID='" + aktifID + "'", d);
            adresbilgi = (komut.ExecuteScalar()).ToString();
            d.Close();

        }




        private void Ödeme_Load(object sender, EventArgs e)
        {
            
            cmb_odeme.Enabled = false;
            txt_kartno.Enabled = false;
            cmb_ay.Enabled = false;
            cmb_yıl.Enabled = false;
            txt_cvv.Enabled = false;
            cmb_bankaadi.Enabled = false;
            txt_cek.Enabled = false;
            txt_odenecek_tutar.Text = Alisveris.sepet_toplam;

        }

        
        private void rdb_kapıda_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_kapıda.Checked==true)
            {
                odemeyontem = "Kapıda Ödeme";
            }
        }

        private void rdb_kart_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_kart.Checked==true)
            {
                cmb_odeme.Enabled = true;
                txt_kartno.Enabled = true;
                cmb_ay.Enabled = true;
                cmb_yıl.Enabled = true;
                txt_cvv.Enabled = true;
                odemeyontem = "Kredi/Banka Kartı";

            }
            else
            {
                cmb_odeme.Enabled = false;
                txt_kartno.Enabled = false;
                cmb_ay.Enabled = false;
                cmb_yıl.Enabled = false;
                txt_cvv.Enabled = false;
            }
        }

        private void rdb_cek_CheckedChanged(object sender, EventArgs e)
        {
            if(rdb_cek.Checked==true)
            {
                cmb_bankaadi.Enabled = true;
                txt_cek.Enabled = true;
                odemeyontem = "Çekle Ödeme";
            }
            else
            {
                cmb_bankaadi.Enabled = false;
                txt_cek.Enabled = false;
            }
        }

        private void btn_geri_don_Click(object sender, EventArgs e)
        {
            Alisveris don = new Alisveris();
            don.Show();
            this.Close();
        }

        private void btn_tamamla_Click(object sender, EventArgs e)
        {
            DateTime urnTarih = DateTime.Now;
            int i = 1;
            AdresBul();
            d.Open();
            SqlCommand komut = new SqlCommand("select *from sepet  where musteriID='" + aktifID + "'", d);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (Convert.ToInt32(read["musteriID"]) == aktifID)
                {
                    i++;
                }

            }
            d.Close();


            for (int j = 1; j < i; j++)
            {
                
                d.Open();
                SqlCommand komut3 = new SqlCommand("select *from sepet  where musteriID='" + aktifID + "'", d);
                SqlDataReader read2 = komut3.ExecuteReader();
                int h = 1;

                while (read2.Read())
                {


                    if (j == h)
                    {
                        urnAd = read2["Ad"].ToString();
                        urnAdet = Convert.ToInt32(read2["Adet"]);
                        urnFiyat = Convert.ToSingle(read2["Fiyat"]);
                        urnTFiyat = Convert.ToSingle(read2["toplamfiyat"]);

                        break;
                    }
                    h++;


                }

                d.Close();
                d.Open();
                SqlCommand komut2 = new SqlCommand("insert into satisveri(musteriID,urunAD,urunADET,urunFIYAT,urunTFIYAT,urunTARIH,urunODEME,urunADRES) values(@musteriID,@urunAD,@urunADET,@urunFIYAT,@urunTFIYAT,@urunTARIH,@urunODEME,@urunADRES)", d);
                komut2.Parameters.AddWithValue("@musteriID", aktifID);
                komut2.Parameters.AddWithValue("@urunAD", urnAd);
                komut2.Parameters.AddWithValue("@urunADET", urnAdet);
                komut2.Parameters.AddWithValue("@urunFIYAT", urnFiyat);
                komut2.Parameters.AddWithValue("@urunTFIYAT", urnTFiyat);
                komut2.Parameters.AddWithValue("@urunTARIH", urnTarih);
                komut2.Parameters.AddWithValue("@urunODEME", odemeyontem);
                komut2.Parameters.AddWithValue("@urunADRES", adresbilgi);
                komut2.ExecuteNonQuery();
                d.Close();
                

            }

            SepetTemizle();

            if (rdb_kapıda.Checked == true)
            {
                MessageBox.Show("Siparişiniz alındı.\nBizi tercih ettiğiniz için teşekkür ederiz.");
            }
            else
            {
                MessageBox.Show("Ödeme başarılı.\nBizi tercih ettiğiniz için teşekkür ederiz.");
            }
            Alisveris don = new Alisveris();
            don.Show();
            this.Close();
        }

        private void SepetTemizle()
        {
            d.Open();
            SqlCommand komut4 = new SqlCommand("delete from sepet where musteriID='" + aktifID + "'",d);
            komut4.ExecuteNonQuery();
            d.Close();
        }
    }
}
