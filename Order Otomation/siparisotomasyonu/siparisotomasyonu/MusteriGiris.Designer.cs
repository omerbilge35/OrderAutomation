namespace siparisotomasyonu
{
    partial class MusteriGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_musteri_giris = new System.Windows.Forms.Button();
            this.txt_tcno_giris = new System.Windows.Forms.TextBox();
            this.txt_sifre_giris = new System.Windows.Forms.TextBox();
            this.btn_anamenu_giris = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(377, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(400, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // btn_musteri_giris
            // 
            this.btn_musteri_giris.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_musteri_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_musteri_giris.Location = new System.Drawing.Point(524, 296);
            this.btn_musteri_giris.Name = "btn_musteri_giris";
            this.btn_musteri_giris.Size = new System.Drawing.Size(104, 38);
            this.btn_musteri_giris.TabIndex = 3;
            this.btn_musteri_giris.Text = "GİRİŞ";
            this.btn_musteri_giris.UseVisualStyleBackColor = false;
            this.btn_musteri_giris.Click += new System.EventHandler(this.btn_musteri_giris_Click);
            // 
            // txt_tcno_giris
            // 
            this.txt_tcno_giris.BackColor = System.Drawing.SystemColors.Window;
            this.txt_tcno_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcno_giris.Location = new System.Drawing.Point(501, 148);
            this.txt_tcno_giris.Name = "txt_tcno_giris";
            this.txt_tcno_giris.Size = new System.Drawing.Size(127, 23);
            this.txt_tcno_giris.TabIndex = 4;
            this.txt_tcno_giris.TextChanged += new System.EventHandler(this.txt_tcno_giris_TextChanged);
            // 
            // txt_sifre_giris
            // 
            this.txt_sifre_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre_giris.Location = new System.Drawing.Point(501, 219);
            this.txt_sifre_giris.Name = "txt_sifre_giris";
            this.txt_sifre_giris.Size = new System.Drawing.Size(127, 23);
            this.txt_sifre_giris.TabIndex = 5;
            this.txt_sifre_giris.TextChanged += new System.EventHandler(this.txt_sifre_giris_TextChanged);
            // 
            // btn_anamenu_giris
            // 
            this.btn_anamenu_giris.BackColor = System.Drawing.Color.IndianRed;
            this.btn_anamenu_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenu_giris.Location = new System.Drawing.Point(629, 432);
            this.btn_anamenu_giris.Name = "btn_anamenu_giris";
            this.btn_anamenu_giris.Size = new System.Drawing.Size(159, 54);
            this.btn_anamenu_giris.TabIndex = 6;
            this.btn_anamenu_giris.Text = "ANA MENÜYE DÖN";
            this.btn_anamenu_giris.UseVisualStyleBackColor = false;
            this.btn_anamenu_giris.Click += new System.EventHandler(this.btn_anamenu_giris_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.checkBox1.Location = new System.Drawing.Point(547, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 496);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_anamenu_giris);
            this.Controls.Add(this.txt_sifre_giris);
            this.Controls.Add(this.txt_tcno_giris);
            this.Controls.Add(this.btn_musteri_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusteriGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Girişi";
            this.Load += new System.EventHandler(this.MusteriGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_musteri_giris;
        private System.Windows.Forms.TextBox txt_tcno_giris;
        private System.Windows.Forms.TextBox txt_sifre_giris;
        private System.Windows.Forms.Button btn_anamenu_giris;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}