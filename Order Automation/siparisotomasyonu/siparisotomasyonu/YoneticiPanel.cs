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
    public partial class YoneticiPanel : Form
    {
        public YoneticiPanel()
        {
            InitializeComponent();
        }
        SqlConnection z = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");
        DataSet daset = new DataSet();


        private void YoneticiPanel_Load(object sender, EventArgs e)
        {
            Urun_Guncelle();

        }

        private void Urun_Guncelle()
        {
            z.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", z);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            z.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_urun_id.Text = dataGridView1.CurrentRow.Cells["urunID"].Value.ToString();
            txt_urun_ad.Text = dataGridView1.CurrentRow.Cells["urun_ad"].Value.ToString();
            txt_urun_fiyat.Text = dataGridView1.CurrentRow.Cells["urun_fiyat"].Value.ToString();
            txt_urun_aciklama.Text = dataGridView1.CurrentRow.Cells["urun_aciklama"].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            z.Open();
            SqlCommand komut = new SqlCommand("update urun set urun_ad=@urun_ad,urun_fiyat=@urun_fiyat,urun_aciklama=@urun_aciklama where urunID=@urunID", z);
            komut.Parameters.AddWithValue("@urunID", txt_urun_id.Text);
            komut.Parameters.AddWithValue("@urun_ad", txt_urun_ad.Text);
            komut.Parameters.AddWithValue("@urun_fiyat", txt_urun_fiyat.Text);
            komut.Parameters.AddWithValue("@urun_aciklama", txt_urun_aciklama.Text);
            komut.ExecuteNonQuery();

            z.Close();
            daset.Tables["urun"].Clear();
            Urun_Guncelle();
            MessageBox.Show("Ürün bilgileri güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            z.Open();
            SqlCommand komut = new SqlCommand("delete from urun where urunID='"+dataGridView1.CurrentRow.Cells["urunID"].Value.ToString()+"'",z);
            komut.ExecuteNonQuery();
            z.Close();
            MessageBox.Show("Kayıt silindi.");
            daset.Tables["urun"].Clear();
            Urun_Guncelle();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            z.Open();

            SqlCommand komut = new SqlCommand("insert into urun(urun_ad,urun_fiyat,urun_aciklama) values(@urun_ad,@urun_fiyat,@urun_aciklama)", z);

            komut.Parameters.AddWithValue("@urun_ad", txt_urun_ad.Text);
            komut.Parameters.AddWithValue("@urun_fiyat", txt_urun_fiyat.Text);
            komut.Parameters.AddWithValue("@urun_aciklama", txt_urun_aciklama.Text);
            komut.ExecuteNonQuery();


            z.Close();
            daset.Tables["urun"].Clear();
            Urun_Guncelle();
            MessageBox.Show("Ürün kaydı eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_panel_anamenu_Click(object sender, EventArgs e)
        {
            AnaSayfa don = new AnaSayfa();
            don.Show();
            this.Close();
        }

        private void btn_mus_takip_Click(object sender, EventArgs e)
        {
            MusteriTakip takip = new MusteriTakip();
            takip.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
