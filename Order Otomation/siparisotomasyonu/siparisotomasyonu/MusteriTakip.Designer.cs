namespace siparisotomasyonu
{
    partial class MusteriTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriTakip));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_menuye_don = new System.Windows.Forms.Button();
            this.btn_panele_don = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_musid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_menuye_don
            // 
            this.btn_menuye_don.BackColor = System.Drawing.Color.IndianRed;
            this.btn_menuye_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_menuye_don.Location = new System.Drawing.Point(703, 435);
            this.btn_menuye_don.Name = "btn_menuye_don";
            this.btn_menuye_don.Size = new System.Drawing.Size(179, 45);
            this.btn_menuye_don.TabIndex = 1;
            this.btn_menuye_don.Text = "ANA MENÜYE DÖN";
            this.btn_menuye_don.UseVisualStyleBackColor = false;
            this.btn_menuye_don.Click += new System.EventHandler(this.btn_menuye_don_Click);
            // 
            // btn_panele_don
            // 
            this.btn_panele_don.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_panele_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_panele_don.Location = new System.Drawing.Point(12, 436);
            this.btn_panele_don.Name = "btn_panele_don";
            this.btn_panele_don.Size = new System.Drawing.Size(163, 45);
            this.btn_panele_don.TabIndex = 2;
            this.btn_panele_don.Text = "PANELE DÖN";
            this.btn_panele_don.UseVisualStyleBackColor = false;
            this.btn_panele_don.Click += new System.EventHandler(this.btn_panele_don_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(12, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "MÜŞTERİ SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(434, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(448, 337);
            this.dataGridView2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(486, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID\' li müşterinin sipariş geçmişi";
            // 
            // txt_musid
            // 
            this.txt_musid.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_musid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_musid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_musid.Location = new System.Drawing.Point(462, 35);
            this.txt_musid.Multiline = true;
            this.txt_musid.Name = "txt_musid";
            this.txt_musid.Size = new System.Drawing.Size(18, 25);
            this.txt_musid.TabIndex = 6;
            // 
            // MusteriTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 492);
            this.Controls.Add(this.txt_musid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_panele_don);
            this.Controls.Add(this.btn_menuye_don);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MusteriTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriTakip";
            this.Load += new System.EventHandler(this.MusteriTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_menuye_don;
        private System.Windows.Forms.Button btn_panele_don;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_musid;
    }
}