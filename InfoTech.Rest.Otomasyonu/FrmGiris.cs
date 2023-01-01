using InfoTech.Rest.BusinessLayer;
using InfoTech.Rest.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTech.Rest.Otomasyonu
{
    public partial class FrmGiris : Form
    {
        private TKullaniciIslemleri KullaniciIslemleri;
        private TYoneticiIslemleri YoneticiIslemleri;
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (KullaniciIslemleri == null)
            {
                KullaniciIslemleri = new TKullaniciIslemleri();


            }


            string HataMesaji;
            VwKisiUye kisiUye;
            List<TblKullaniciRolleri> kullaniciRolleri;
            bool Basarili = KullaniciIslemleri.KullaniciGiris(TxtKullaniciAdi.Text.Trim(),
                                              TxtSifre.Text.Trim(),
                                              out HataMesaji,
                                              out kisiUye,
                                              out kullaniciRolleri);

            if (!Basarili)
            {
                MessageBox.Show(HataMesaji);
            }
            else
            {
                if ((bool)kisiUye.SifreDegistirsin)
                {
                    MessageBox.Show("Şifrenizi değiştirmeniz gerekli.");
                    //yeni form aç
                }
                else
                {
                    FrmAnaSayfa anaSayfa = new FrmAnaSayfa();
                    anaSayfa.ShowDialog();                   
                   
                    //Ana formu göster
                }
            }

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LnkLblAdminGirisi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (YoneticiIslemleri == null)
                YoneticiIslemleri = new TYoneticiIslemleri();


            string KullaniciAdi = TxtKullaniciAdi.Text.Trim();
            string Sifre = TxtSifre.Text.Trim();
            string HataMesaji = "";
            VwKisiUye OKisiUye = null;
            List<TblKullaniciRolleri> OKullaniciRolleri = null;
            VwUyeRol OUyeRol = null;

            bool AdminGirisBasarili = YoneticiIslemleri.AdminKullaniciGiris(KullaniciAdi, Sifre, out HataMesaji, out OKisiUye, out OKullaniciRolleri, out OUyeRol);


            if (!AdminGirisBasarili)
            {
                MessageBox.Show(HataMesaji);
            }
            else
            {
                MessageBox.Show("Admin girişi başarılı");

                FrmAdminPaneli frmAdminPaneli = new FrmAdminPaneli();
               
               frmAdminPaneli.Show();
               

                FrmAnaSayfa anaSayfa = new FrmAnaSayfa();
                anaSayfa.Show();


            }


        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUyeEkle frmUyeEkle = new FrmUyeEkle();
            frmUyeEkle.Show();


        }


    }
}
