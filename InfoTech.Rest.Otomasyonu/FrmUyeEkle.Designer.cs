namespace InfoTech.Rest.Otomasyonu
{
    partial class FrmUyeEkle
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgKisiBilgileriEkle = new System.Windows.Forms.TabPage();
            this.GbxKisiUyelikFormu = new System.Windows.Forms.GroupBox();
            this.BtnKisiKaydi = new System.Windows.Forms.Button();
            this.CbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtDateTime = new System.Windows.Forms.DateTimePicker();
            this.TxtTcNo = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TpgUyeBilgileri = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnUyeEkle = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StrKisiId = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.TpgKisiBilgileriEkle.SuspendLayout();
            this.GbxKisiUyelikFormu.SuspendLayout();
            this.TpgUyeBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpgKisiBilgileriEkle);
            this.tabControl1.Controls.Add(this.TpgUyeBilgileri);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 623);
            this.tabControl1.TabIndex = 1;
            // 
            // TpgKisiBilgileriEkle
            // 
            this.TpgKisiBilgileriEkle.BackColor = System.Drawing.Color.Silver;
            this.TpgKisiBilgileriEkle.Controls.Add(this.GbxKisiUyelikFormu);
            this.TpgKisiBilgileriEkle.Location = new System.Drawing.Point(4, 25);
            this.TpgKisiBilgileriEkle.Name = "TpgKisiBilgileriEkle";
            this.TpgKisiBilgileriEkle.Padding = new System.Windows.Forms.Padding(3);
            this.TpgKisiBilgileriEkle.Size = new System.Drawing.Size(888, 594);
            this.TpgKisiBilgileriEkle.TabIndex = 0;
            this.TpgKisiBilgileriEkle.Text = "Kişi Bilgileri";
            // 
            // GbxKisiUyelikFormu
            // 
            this.GbxKisiUyelikFormu.Controls.Add(this.BtnKisiKaydi);
            this.GbxKisiUyelikFormu.Controls.Add(this.CbxCinsiyet);
            this.GbxKisiUyelikFormu.Controls.Add(this.TxtDateTime);
            this.GbxKisiUyelikFormu.Controls.Add(this.TxtTcNo);
            this.GbxKisiUyelikFormu.Controls.Add(this.TxtSoyad);
            this.GbxKisiUyelikFormu.Controls.Add(this.TxtAd);
            this.GbxKisiUyelikFormu.Controls.Add(this.label5);
            this.GbxKisiUyelikFormu.Controls.Add(this.label4);
            this.GbxKisiUyelikFormu.Controls.Add(this.label3);
            this.GbxKisiUyelikFormu.Controls.Add(this.label2);
            this.GbxKisiUyelikFormu.Controls.Add(this.label1);
            this.GbxKisiUyelikFormu.Location = new System.Drawing.Point(102, 60);
            this.GbxKisiUyelikFormu.Name = "GbxKisiUyelikFormu";
            this.GbxKisiUyelikFormu.Size = new System.Drawing.Size(685, 475);
            this.GbxKisiUyelikFormu.TabIndex = 1;
            this.GbxKisiUyelikFormu.TabStop = false;
            // 
            // BtnKisiKaydi
            // 
            this.BtnKisiKaydi.Location = new System.Drawing.Point(139, 246);
            this.BtnKisiKaydi.Name = "BtnKisiKaydi";
            this.BtnKisiKaydi.Size = new System.Drawing.Size(200, 24);
            this.BtnKisiKaydi.TabIndex = 9;
            this.BtnKisiKaydi.Text = "Kaydet ve Diğer Sayfaya Geç";
            this.BtnKisiKaydi.UseVisualStyleBackColor = true;
            this.BtnKisiKaydi.Click += new System.EventHandler(this.BtnKisiKaydi_Click);
            // 
            // CbxCinsiyet
            // 
            this.CbxCinsiyet.FormattingEnabled = true;
            this.CbxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CbxCinsiyet.Location = new System.Drawing.Point(139, 204);
            this.CbxCinsiyet.Name = "CbxCinsiyet";
            this.CbxCinsiyet.Size = new System.Drawing.Size(200, 24);
            this.CbxCinsiyet.TabIndex = 8;
            // 
            // TxtDateTime
            // 
            this.TxtDateTime.Location = new System.Drawing.Point(139, 160);
            this.TxtDateTime.Name = "TxtDateTime";
            this.TxtDateTime.Size = new System.Drawing.Size(200, 22);
            this.TxtDateTime.TabIndex = 3;
            // 
            // TxtTcNo
            // 
            this.TxtTcNo.Location = new System.Drawing.Point(139, 120);
            this.TxtTcNo.Name = "TxtTcNo";
            this.TxtTcNo.Size = new System.Drawing.Size(200, 22);
            this.TxtTcNo.TabIndex = 2;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(139, 81);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(200, 22);
            this.TxtSoyad.TabIndex = 1;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(139, 41);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(200, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TcNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dogum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // TpgUyeBilgileri
            // 
            this.TpgUyeBilgileri.BackColor = System.Drawing.Color.Silver;
            this.TpgUyeBilgileri.Controls.Add(this.groupBox1);
            this.TpgUyeBilgileri.Location = new System.Drawing.Point(4, 25);
            this.TpgUyeBilgileri.Name = "TpgUyeBilgileri";
            this.TpgUyeBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.TpgUyeBilgileri.Size = new System.Drawing.Size(888, 594);
            this.TpgUyeBilgileri.TabIndex = 1;
            this.TpgUyeBilgileri.Text = "Üye Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnUyeEkle);
            this.groupBox1.Controls.Add(this.TxtSifre);
            this.groupBox1.Controls.Add(this.TxtKullaniciAdi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(102, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 475);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BtnUyeEkle
            // 
            this.BtnUyeEkle.Location = new System.Drawing.Point(275, 193);
            this.BtnUyeEkle.Name = "BtnUyeEkle";
            this.BtnUyeEkle.Size = new System.Drawing.Size(84, 37);
            this.BtnUyeEkle.TabIndex = 7;
            this.BtnUyeEkle.Text = "Üye Ekle";
            this.BtnUyeEkle.UseVisualStyleBackColor = true;
            this.BtnUyeEkle.Click += new System.EventHandler(this.BtnUyeEkle_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(159, 150);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(200, 22);
            this.TxtSifre.TabIndex = 6;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(159, 98);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(200, 22);
            this.TxtKullaniciAdi.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şifre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StrKisiId});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StrKisiId
            // 
            this.StrKisiId.Name = "StrKisiId";
            this.StrKisiId.Size = new System.Drawing.Size(45, 20);
            this.StrKisiId.Text = "KisiId";
            this.StrKisiId.Visible = false;
            // 
            // FrmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUyeEkle";
            this.tabControl1.ResumeLayout(false);
            this.TpgKisiBilgileriEkle.ResumeLayout(false);
            this.GbxKisiUyelikFormu.ResumeLayout(false);
            this.GbxKisiUyelikFormu.PerformLayout();
            this.TpgUyeBilgileri.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgKisiBilgileriEkle;
        private System.Windows.Forms.GroupBox GbxKisiUyelikFormu;
        private System.Windows.Forms.ComboBox CbxCinsiyet;
        private System.Windows.Forms.DateTimePicker TxtDateTime;
        private System.Windows.Forms.TextBox TxtTcNo;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TpgUyeBilgileri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnKisiKaydi;
        private System.Windows.Forms.Button BtnUyeEkle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StrKisiId;
    }
}