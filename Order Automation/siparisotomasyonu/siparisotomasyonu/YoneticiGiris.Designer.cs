namespace siparisotomasyonu
{
    partial class YoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre_yonetici = new System.Windows.Forms.TextBox();
            this.btn_giris_yonetici = new System.Windows.Forms.Button();
            this.btn_anamenu_yonetici = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(331, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre:";
            // 
            // txt_sifre_yonetici
            // 
            this.txt_sifre_yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre_yonetici.Location = new System.Drawing.Point(425, 161);
            this.txt_sifre_yonetici.Multiline = true;
            this.txt_sifre_yonetici.Name = "txt_sifre_yonetici";
            this.txt_sifre_yonetici.Size = new System.Drawing.Size(141, 26);
            this.txt_sifre_yonetici.TabIndex = 1;
            this.txt_sifre_yonetici.TextChanged += new System.EventHandler(this.txt_sifre_yonetici_TextChanged_1);
            // 
            // btn_giris_yonetici
            // 
            this.btn_giris_yonetici.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_giris_yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_yonetici.Location = new System.Drawing.Point(474, 258);
            this.btn_giris_yonetici.Name = "btn_giris_yonetici";
            this.btn_giris_yonetici.Size = new System.Drawing.Size(92, 40);
            this.btn_giris_yonetici.TabIndex = 2;
            this.btn_giris_yonetici.Text = "GİRİŞ";
            this.btn_giris_yonetici.UseVisualStyleBackColor = false;
            this.btn_giris_yonetici.Click += new System.EventHandler(this.btn_giris_yonetici_Click);
            // 
            // btn_anamenu_yonetici
            // 
            this.btn_anamenu_yonetici.BackColor = System.Drawing.Color.IndianRed;
            this.btn_anamenu_yonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenu_yonetici.Location = new System.Drawing.Point(643, 378);
            this.btn_anamenu_yonetici.Name = "btn_anamenu_yonetici";
            this.btn_anamenu_yonetici.Size = new System.Drawing.Size(145, 60);
            this.btn_anamenu_yonetici.TabIndex = 3;
            this.btn_anamenu_yonetici.Text = "ANA MENÜYE DÖN";
            this.btn_anamenu_yonetici.UseVisualStyleBackColor = false;
            this.btn_anamenu_yonetici.Click += new System.EventHandler(this.btn_anamenu_yonetici_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.checkBox1.Location = new System.Drawing.Point(480, 212);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_anamenu_yonetici);
            this.Controls.Add(this.btn_giris_yonetici);
            this.Controls.Add(this.txt_sifre_yonetici);
            this.Controls.Add(this.label1);
            this.Name = "YoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre_yonetici;
        private System.Windows.Forms.Button btn_giris_yonetici;
        private System.Windows.Forms.Button btn_anamenu_yonetici;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}