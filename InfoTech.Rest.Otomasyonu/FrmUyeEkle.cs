using InfoTech.Rest.BusinessLayer;
using InfoTech.Rest.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTech.Rest.Otomasyonu
{
    public partial class FrmUyeEkle : Form
    {

        TUyelikIslemleri uyelikIslemleri;

        public FrmUyeEkle()
        {
            InitializeComponent();
            uyelikIslemleri = new TUyelikIslemleri();
        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {

          

        }

        private void BtnUyeOl_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnKisiKaydi_Click(object sender, EventArgs e)
        {

            string HataMesaji = "";

            TblKisi tblKisi = new TblKisi();
            tblKisi.Ad = TxtAd.Text.Trim();
            tblKisi.Soyad = TxtSoyad.Text.Trim();
            tblKisi.TC = Int64.Parse(TxtTcNo.Text.Trim());
            tblKisi.DogumTarihi = TxtDateTime.Value;
            tblKisi.Cinsiyet = CbxCinsiyet.SelectedItem.ToString();
           

           bool basarili = uyelikIslemleri.KisiEkle(tblKisi, out HataMesaji);
            StrKisiId.Text =  tblKisi.KisiId.ToString();
            if (!basarili)
            {
                MessageBox.Show(HataMesaji);
            }
            else
            {
                MessageBox.Show("kişi bilgileri kaydedildi");

                     tabControl1.SelectTab(TpgUyeBilgileri);
            }
        }

           

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnUyeEkle_Click(object sender, EventArgs e)
        {

            string Message = "";

            TblUye tblUye = new TblUye();
            tblUye.KullaniciAdi = TxtKullaniciAdi.Text.Trim();
            tblUye.Sifre = TxtSifre.Text.Trim();
            tblUye.KayitTarihi = DateTime.Now;
            tblUye.SonGirisTarihi = DateTime.Now;
            tblUye.SifreDegistirsin = false;
            tblUye.KisiId = Convert.ToInt32(StrKisiId.Text);





            bool basarili = uyelikIslemleri.UyeEkle( tblUye, out Message);

            if (!basarili)
            {
                MessageBox.Show("üye kaydı işlemi başarısız" + Message);
            }
            else
            {
                MessageBox.Show("üye kaydı işlemi başarılı");
            }


        }
    }
}
