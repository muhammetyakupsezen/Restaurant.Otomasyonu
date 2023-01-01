namespace InfoTech.Rest.Otomasyonu
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.LnkLblAdminGirisi = new System.Windows.Forms.LinkLabel();
            this.LblKullaniciAdi = new System.Windows.Forms.Label();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(183, 69);
            this.TxtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(132, 29);
            this.TxtKullaniciAdi.TabIndex = 2;
            this.TxtKullaniciAdi.Text = "ahmet";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(183, 117);
            this.TxtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(132, 29);
            this.TxtSifre.TabIndex = 3;
            this.TxtSifre.Text = "222";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(319, 69);
            this.BtnGiris.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(132, 79);
            this.BtnGiris.TabIndex = 4;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(469, 4);
            this.BtnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(45, 43);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "X";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // LnkLblAdminGirisi
            // 
            this.LnkLblAdminGirisi.AutoSize = true;
            this.LnkLblAdminGirisi.Location = new System.Drawing.Point(467, 202);
            this.LnkLblAdminGirisi.Name = "LnkLblAdminGirisi";
            this.LnkLblAdminGirisi.Size = new System.Drawing.Size(75, 16);
            this.LnkLblAdminGirisi.TabIndex = 6;
            this.LnkLblAdminGirisi.TabStop = true;
            this.LnkLblAdminGirisi.Text = "AdminGirisi";
            this.LnkLblAdminGirisi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblAdminGirisi_LinkClicked);
            // 
            // LblKullaniciAdi
            // 
            this.LblKullaniciAdi.AutoSize = true;
            this.LblKullaniciAdi.Location = new System.Drawing.Point(9, 4);
            this.LblKullaniciAdi.Name = "LblKullaniciAdi";
            this.LblKullaniciAdi.Size = new System.Drawing.Size(76, 16);
            this.LblKullaniciAdi.TabIndex = 7;
            this.LblKullaniciAdi.Text = "KullaniciAdi";
            this.LblKullaniciAdi.Visible = false;
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.Location = new System.Drawing.Point(406, 152);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(45, 16);
            this.LnkUyeOl.TabIndex = 8;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "UyeOl";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(547, 227);
            this.ControlBox = false;
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.LblKullaniciAdi);
            this.Controls.Add(this.LnkLblAdminGirisi);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoTech Restoran Otomasyonu V.1";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.LinkLabel LnkLblAdminGirisi;
        private System.Windows.Forms.Label LblKullaniciAdi;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
    }
}

