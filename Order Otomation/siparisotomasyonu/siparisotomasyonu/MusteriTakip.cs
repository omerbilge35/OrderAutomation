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
    public partial class MusteriTakip : Form
    {
        public MusteriTakip()
        {
            InitializeComponent();
        }

        SqlConnection b = new SqlConnection("Server=DESKTOP-R5P3ANL\\SQLEXPRESS;Database=siparisotomasyonu;trusted_connection=true;");
        DataSet daset = new DataSet();



        private void MusteriTakip_Load(object sender, EventArgs e)
        {
            MusteriGuncelle();
            

        }

        private void Temizle()
        {
            b.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satisveri where musteriID='" + txt_musid.Text + "'", b);
            adtr.Fill(daset, "satisveri");
            daset.Tables["satisveri"].Clear();
            dataGridView2.DataSource = daset.Tables["satisveri"];
            b.Close();
        }



        private void AlisverisListele()
        {
            b.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satisveri where musteriID='" + txt_musid.Text + "'", b);
            adtr.Fill(daset, "satisveri");
            dataGridView2.DataSource = daset.Tables["satisveri"];
            b.Close();
        }


        private void MusteriGuncelle()
        {
            b.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from musteri", b);
            adtr.Fill(daset, "musteri");
            dataGridView1.DataSource = daset.Tables["musteri"];
            b.Close();
        }

        private void button3_Click(object sender, EventArgs e)//MÜŞTERİ SİL BUTONU
        {
            b.Open();
            SqlCommand komut = new SqlCommand("delete from musteri where musteriID='" + dataGridView1.CurrentRow.Cells["musteriID"].Value.ToString() + "'", b);
            komut.ExecuteNonQuery();
            b.Close();
            MessageBox.Show("Müşteri silindi.");
            daset.Tables["musteri"].Clear();
            MusteriGuncelle();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btn_menuye_don_Click(object sender, EventArgs e)
        {
            AnaSayfa don = new AnaSayfa();
            don.Show();
            this.Close();
        }

        private void btn_panele_don_Click(object sender, EventArgs e)
        {
            YoneticiPanel panel = new YoneticiPanel();
            panel.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Temizle();
            txt_musid.Text = dataGridView1.CurrentRow.Cells["musteriID"].Value.ToString();
            AlisverisListele();
        }
    }
}
