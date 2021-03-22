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
    public partial class Alisveris : Form
    {
        public Alisveris()
        {
            InitializeComponent();
        }
        SqlConnection n = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");
        DataSet daset = new DataSet();
        static public string sepet_toplam;

        private void SepetTablosu()
        {
            n.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet where musteriID='"+txt_aktifID.Text+"'", n);
            adtr.Fill(daset, "sepet");
            dataGridView2.DataSource = daset.Tables["sepet"];
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            
            
            n.Close();
        }

        private void UrunlerTablosu()
        {
            n.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", n);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            dataGridView1.Columns[0].Visible = false;
            n.Close();
        }


       

        private void Alisveris_Load(object sender, EventArgs e)
        {
            txt_aktifID.Text = MusteriGiris.musteriIDsi;
            UrunlerTablosu();
            SepetTablosu();

            SepetToplam();

        }

        private void SepetToplam()
        {
            n.Open();
            SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from sepet where musteriID='" + txt_aktifID.Text + "'", n);
            txt_sepet_tutari.Text = komut.ExecuteScalar() + "TL";
            n.Close();
            sepet_toplam = txt_sepet_tutari.Text;
        }
        bool test;
        private void IDkontrol()
        {
            test = true;
            n.Open();
            SqlCommand komut = new SqlCommand("select *from sepet  where musteriID='" + txt_aktifID.Text + "'", n);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txt_ID.Text == read["musteriID"].ToString())
                {
                    test = false;
                }
            }
            n.Close();
        }


        private void btn_sepet_Click(object sender, EventArgs e)
        {
            IDkontrol();
            if (txt_ADET.Text == "0")
            {
                txt_ADET.Text = "1";
            }
            else if (txt_ADET.Text == "")
            {
                txt_ADET.Text = "1";

            }


            
            if(test==true)
            {
                n.Open();
                SqlCommand komut4 = new SqlCommand("insert into sepet(musteriID,Ad,Fiyat,Adet,ID,ToplamFiyat) values(@musteriID,@Ad,@Fiyat,@Adet,@ID,@ToplamFiyat)", n);
                komut4.Parameters.AddWithValue("@musteriID", txt_aktifID.Text);
                komut4.Parameters.AddWithValue("@Ad", txt_AD.Text);
                komut4.Parameters.AddWithValue("@Fiyat", float.Parse(txt_FIYAT.Text));
                komut4.Parameters.AddWithValue("@Adet", txt_ADET.Text);
                komut4.Parameters.AddWithValue("@ID", txt_ID.Text);
                komut4.Parameters.AddWithValue("@ToplamFiyat", float.Parse(txt_toplam_fiyat.Text));
                komut4.ExecuteNonQuery();


                n.Close();
            }
            else
            {
                n.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set Adet=Adet+'" + int.Parse(txt_ADET.Text) + "'where ID='" + txt_ID.Text + "'", n);
                komut2.ExecuteNonQuery();

                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyat=Adet*Fiyat where ID='" + txt_ID.Text + "'", n);
                komut3.ExecuteNonQuery();


                n.Close();
            }
          
            daset.Tables["sepet"].Clear();
            SepetTablosu();
            MessageBox.Show("Ürün sepete eklendi.");
            SepetToplam();
        }

        private void txt_ADET_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaSayfa don = new AnaSayfa();
            don.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.CurrentRow.Cells["urunID"].Value.ToString();
            txt_AD.Text = dataGridView1.CurrentRow.Cells["urun_ad"].Value.ToString();
            txt_FIYAT.Text = dataGridView1.CurrentRow.Cells["urun_fiyat"].Value.ToString();
        }

        private void btn_sepet_cikar_Click(object sender, EventArgs e)
        {
            n.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where sepetID='" + dataGridView2.CurrentRow.Cells["sepetID"].Value.ToString() + "'", n);
            komut.ExecuteNonQuery();
            n.Close();
            daset.Tables["sepet"].Clear();

            SepetTablosu();
            MessageBox.Show("Ürün sepetten silindi.");
            SepetToplam();
        }

        private void txt_ADET_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_toplam_fiyat.Text = (float.Parse(txt_ADET.Text) * float.Parse(txt_FIYAT.Text)).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void txt_FIYAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_toplam_fiyat.Text = (float.Parse(txt_ADET.Text) * float.Parse(txt_FIYAT.Text)).ToString();
            }
            catch (Exception)
            {

                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ödeme git = new Ödeme();
            git.Show();
            this.Close();
            
           
        }
    }
}
