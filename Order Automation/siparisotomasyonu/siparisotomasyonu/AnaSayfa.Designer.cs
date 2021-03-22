namespace siparisotomasyonu
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.btn_kayitgrs = new System.Windows.Forms.Button();
            this.btn_musgrs = new System.Windows.Forms.Button();
            this.btn_yoneticigrs = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kayitgrs
            // 
            this.btn_kayitgrs.BackColor = System.Drawing.Color.Wheat;
            this.btn_kayitgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayitgrs.Location = new System.Drawing.Point(636, 12);
            this.btn_kayitgrs.Name = "btn_kayitgrs";
            this.btn_kayitgrs.Size = new System.Drawing.Size(99, 62);
            this.btn_kayitgrs.TabIndex = 0;
            this.btn_kayitgrs.Text = "MÜŞTERİ KAYIT";
            this.btn_kayitgrs.UseVisualStyleBackColor = false;
            this.btn_kayitgrs.Click += new System.EventHandler(this.btn_kayitgrs_Click);
            // 
            // btn_musgrs
            // 
            this.btn_musgrs.BackColor = System.Drawing.Color.Wheat;
            this.btn_musgrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musgrs.Location = new System.Drawing.Point(636, 103);
            this.btn_musgrs.Name = "btn_musgrs";
            this.btn_musgrs.Size = new System.Drawing.Size(99, 64);
            this.btn_musgrs.TabIndex = 1;
            this.btn_musgrs.Text = "MÜŞTERİ GİRİŞ";
            this.btn_musgrs.UseVisualStyleBackColor = false;
            this.btn_musgrs.Click += new System.EventHandler(this.btn_musgrs_Click);
            // 
            // btn_yoneticigrs
            // 
            this.btn_yoneticigrs.BackColor = System.Drawing.Color.Wheat;
            this.btn_yoneticigrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yoneticigrs.Location = new System.Drawing.Point(636, 191);
            this.btn_yoneticigrs.Name = "btn_yoneticigrs";
            this.btn_yoneticigrs.Size = new System.Drawing.Size(99, 68);
            this.btn_yoneticigrs.TabIndex = 2;
            this.btn_yoneticigrs.Text = "YÖNETİCİ GİRİŞ";
            this.btn_yoneticigrs.UseVisualStyleBackColor = false;
            this.btn_yoneticigrs.Click += new System.EventHandler(this.btn_yoneticigrs_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(636, 320);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(99, 61);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 393);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_yoneticigrs);
            this.Controls.Add(this.btn_musgrs);
            this.Controls.Add(this.btn_kayitgrs);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kayitgrs;
        private System.Windows.Forms.Button btn_musgrs;
        private System.Windows.Forms.Button btn_yoneticigrs;
        private System.Windows.Forms.Button btn_cikis;
    }
}

