namespace siparisotomasyonu
{
    partial class Ödeme
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
            this.rdb_kapıda = new System.Windows.Forms.RadioButton();
            this.rdb_cek = new System.Windows.Forms.RadioButton();
            this.rdb_kart = new System.Windows.Forms.RadioButton();
            this.cmb_bankaadi = new System.Windows.Forms.ComboBox();
            this.cmb_odeme = new System.Windows.Forms.ComboBox();
            this.txt_cek = new System.Windows.Forms.TextBox();
            this.btn_geri_don = new System.Windows.Forms.Button();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.btn_tamamla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ay = new System.Windows.Forms.ComboBox();
            this.cmb_yıl = new System.Windows.Forms.ComboBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_odenecek_tutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rdb_kapıda
            // 
            this.rdb_kapıda.AutoSize = true;
            this.rdb_kapıda.Location = new System.Drawing.Point(22, 83);
            this.rdb_kapıda.Name = "rdb_kapıda";
            this.rdb_kapıda.Size = new System.Drawing.Size(95, 17);
            this.rdb_kapıda.TabIndex = 0;
            this.rdb_kapıda.TabStop = true;
            this.rdb_kapıda.Text = "Kapıda Ödeme";
            this.rdb_kapıda.UseVisualStyleBackColor = true;
            this.rdb_kapıda.CheckedChanged += new System.EventHandler(this.rdb_kapıda_CheckedChanged);
            // 
            // rdb_cek
            // 
            this.rdb_cek.AutoSize = true;
            this.rdb_cek.Location = new System.Drawing.Point(22, 433);
            this.rdb_cek.Name = "rdb_cek";
            this.rdb_cek.Size = new System.Drawing.Size(89, 17);
            this.rdb_cek.TabIndex = 1;
            this.rdb_cek.TabStop = true;
            this.rdb_cek.Text = "Çekle Ödeme";
            this.rdb_cek.UseVisualStyleBackColor = true;
            this.rdb_cek.CheckedChanged += new System.EventHandler(this.rdb_cek_CheckedChanged);
            // 
            // rdb_kart
            // 
            this.rdb_kart.AutoSize = true;
            this.rdb_kart.Location = new System.Drawing.Point(22, 201);
            this.rdb_kart.Name = "rdb_kart";
            this.rdb_kart.Size = new System.Drawing.Size(109, 17);
            this.rdb_kart.TabIndex = 2;
            this.rdb_kart.TabStop = true;
            this.rdb_kart.Text = "Kredi/Banka Kartı";
            this.rdb_kart.UseVisualStyleBackColor = true;
            this.rdb_kart.CheckedChanged += new System.EventHandler(this.rdb_kart_CheckedChanged);
            // 
            // cmb_bankaadi
            // 
            this.cmb_bankaadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bankaadi.FormattingEnabled = true;
            this.cmb_bankaadi.Items.AddRange(new object[] {
            "Ziraat Bankası",
            "Garanti",
            "Finansbank",
            "ING",
            "TEB"});
            this.cmb_bankaadi.Location = new System.Drawing.Point(236, 402);
            this.cmb_bankaadi.Name = "cmb_bankaadi";
            this.cmb_bankaadi.Size = new System.Drawing.Size(149, 21);
            this.cmb_bankaadi.TabIndex = 3;
            // 
            // cmb_odeme
            // 
            this.cmb_odeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_odeme.FormattingEnabled = true;
            this.cmb_odeme.Items.AddRange(new object[] {
            "MasterCard",
            "VISA"});
            this.cmb_odeme.Location = new System.Drawing.Point(236, 166);
            this.cmb_odeme.Name = "cmb_odeme";
            this.cmb_odeme.Size = new System.Drawing.Size(148, 21);
            this.cmb_odeme.TabIndex = 4;
            // 
            // txt_cek
            // 
            this.txt_cek.Location = new System.Drawing.Point(235, 463);
            this.txt_cek.Name = "txt_cek";
            this.txt_cek.Size = new System.Drawing.Size(149, 20);
            this.txt_cek.TabIndex = 5;
            // 
            // btn_geri_don
            // 
            this.btn_geri_don.BackColor = System.Drawing.Color.IndianRed;
            this.btn_geri_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri_don.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_geri_don.Location = new System.Drawing.Point(431, 12);
            this.btn_geri_don.Name = "btn_geri_don";
            this.btn_geri_don.Size = new System.Drawing.Size(107, 30);
            this.btn_geri_don.TabIndex = 6;
            this.btn_geri_don.Text = "GERİ DÖN";
            this.btn_geri_don.UseVisualStyleBackColor = false;
            this.btn_geri_don.Click += new System.EventHandler(this.btn_geri_don_Click);
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(236, 224);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(148, 20);
            this.txt_kartno.TabIndex = 7;
            // 
            // btn_tamamla
            // 
            this.btn_tamamla.BackColor = System.Drawing.Color.Wheat;
            this.btn_tamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tamamla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_tamamla.Location = new System.Drawing.Point(381, 507);
            this.btn_tamamla.Name = "btn_tamamla";
            this.btn_tamamla.Size = new System.Drawing.Size(157, 59);
            this.btn_tamamla.TabIndex = 9;
            this.btn_tamamla.Text = "TAMAMLA";
            this.btn_tamamla.UseVisualStyleBackColor = false;
            this.btn_tamamla.Click += new System.EventHandler(this.btn_tamamla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(281, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "/";
            // 
            // cmb_ay
            // 
            this.cmb_ay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ay.FormattingEnabled = true;
            this.cmb_ay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmb_ay.Location = new System.Drawing.Point(235, 277);
            this.cmb_ay.Name = "cmb_ay";
            this.cmb_ay.Size = new System.Drawing.Size(40, 21);
            this.cmb_ay.TabIndex = 12;
            // 
            // cmb_yıl
            // 
            this.cmb_yıl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_yıl.FormattingEnabled = true;
            this.cmb_yıl.Items.AddRange(new object[] {
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cmb_yıl.Location = new System.Drawing.Point(305, 277);
            this.cmb_yıl.Name = "cmb_yıl";
            this.cmb_yıl.Size = new System.Drawing.Size(38, 21);
            this.cmb_yıl.TabIndex = 13;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(235, 327);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(57, 20);
            this.txt_cvv.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(157, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "AA/YY:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ödeme Sistemi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kart No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Banka Adı:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(159, 469);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 13);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Çek No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // txt_odenecek_tutar
            // 
            this.txt_odenecek_tutar.BackColor = System.Drawing.Color.Wheat;
            this.txt_odenecek_tutar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_odenecek_tutar.Location = new System.Drawing.Point(263, 83);
            this.txt_odenecek_tutar.Name = "txt_odenecek_tutar";
            this.txt_odenecek_tutar.Size = new System.Drawing.Size(100, 13);
            this.txt_odenecek_tutar.TabIndex = 22;
            // 
            // Ödeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(550, 578);
            this.Controls.Add(this.txt_odenecek_tutar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.cmb_yıl);
            this.Controls.Add(this.cmb_ay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tamamla);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.btn_geri_don);
            this.Controls.Add(this.txt_cek);
            this.Controls.Add(this.cmb_odeme);
            this.Controls.Add(this.cmb_bankaadi);
            this.Controls.Add(this.rdb_kart);
            this.Controls.Add(this.rdb_cek);
            this.Controls.Add(this.rdb_kapıda);
            this.Name = "Ödeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.Ödeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_kapıda;
        private System.Windows.Forms.RadioButton rdb_cek;
        private System.Windows.Forms.RadioButton rdb_kart;
        private System.Windows.Forms.ComboBox cmb_bankaadi;
        private System.Windows.Forms.ComboBox cmb_odeme;
        private System.Windows.Forms.TextBox txt_cek;
        private System.Windows.Forms.Button btn_geri_don;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.Button btn_tamamla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ay;
        private System.Windows.Forms.ComboBox cmb_yıl;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_odenecek_tutar;
    }
}