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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection x = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_kayitgrs_Click(object sender, EventArgs e)
        {
            MusteriKayit kyt = new MusteriKayit();
            kyt.Show();
            this.Hide();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_musgrs_Click(object sender, EventArgs e)
        {
            MusteriGiris grs = new MusteriGiris();
            grs.Show();
            this.Hide();
        }

        private void btn_yoneticigrs_Click(object sender, EventArgs e)
        {
            YoneticiGiris yon = new YoneticiGiris();
            yon.Show();
            this.Hide();
        }
    }
}
