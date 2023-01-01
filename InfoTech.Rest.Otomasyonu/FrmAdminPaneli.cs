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
    public partial class FrmAdminPaneli : Form
    {
        TYoneticiIslemleri yoneticiIslemleri;
        TblMasaKategorileri tblMasaKategorileri;
        TMasaIslemleri masaIslemleri;
        UrunIslemleri urunIslemleri;
        TUyelikIslemleri uyelikIslemleri;
        public FrmAdminPaneli()
        {
            InitializeComponent();
            yoneticiIslemleri = new TYoneticiIslemleri();
            masaIslemleri = new TMasaIslemleri();
            urunIslemleri = new UrunIslemleri();
            uyelikIslemleri = new TUyelikIslemleri();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LstMasaKategorileri.Items.Clear();
            FrmAdminPaneli_Load(sender, e);
        }



        private void FrmAdminPaneli_Load(object sender, EventArgs e)
        {
            // tblMasaKategorileri = new TblMasaKategorileri();
            List<TblMasaKategorileri> MasaKategorileriListesi = yoneticiIslemleri.MasaKategorileriGoster();
            foreach (var MasaKategori in MasaKategorileriListesi)
            {
                int KategoriId = CmbMasaKategorileri.Items.Add(MasaKategori.MasaKategoriId);
            }

            var MasaKategoriListesi = masaIslemleri.MasaKategorileri();
            foreach (var MasaKategori in MasaKategoriListesi)
                LstMasaKategorileri.Items.Add(MasaKategori.MasaKategoriId + " " + MasaKategori.MasaKategoriAdi);

            ////////////////////////////////////////

            //  TblMasalar tblMasalar = new TblMasalar();
            List<TblMasalar> MasaListesi = yoneticiIslemleri.MasalariGoster();
            foreach (var Masa in MasaListesi)
            {
                var SeciliMasa = CmbMasaAdi.Items.Add(Masa.MasaId);
            }

            var Masalar = masaIslemleri.Masalar();
            foreach (var Masa in Masalar)
            {
                LstMasaAdi.Items.Add(Masa.MasaId + " " + Masa.MasaAdi);
            }
            ///////////////////////////////////////////////////////

            List<TblKategori> UrunKategorileri = urunIslemleri.Kategoriler();
            foreach (var Kategori in UrunKategorileri)
            {
                var UrunKategoriCmb = CmbSilinecekUrunKategoriId.Items.Add(Kategori.KategoriId);
            }

            List<TblKategori> UrunKategoriListesi = urunIslemleri.Kategoriler();
            foreach (var UrunKategori in UrunKategoriListesi)
            {
                LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
            }

            ////////////////////////////////////////////////////////////////////////////

            List<TblUrun> UrunListesi = urunIslemleri.UrunListesi();
            foreach (var Urun in UrunListesi)
            {
                int UrunId = CmbUrunId.Items.Add(Urun.UrunId);

            }

            List<TblUrun> UrunlerListesi = urunIslemleri.UrunListesi();
            foreach (var Urun in UrunlerListesi)
            {
                LstUrunListesi.Items.Add(Urun.UrunId + "" + Urun.UrunAdi);
            }

            //  List<TblUrunKategorileri> UrunKategorileriListesi=   urunIslemleri.UrunKategorileriListesi();
            List<TblUrunKategorileri> UrununKategorileri = urunIslemleri.UrunKategorileriListesi();
            foreach (var UrunKategorisi in UrununKategorileri)
            {
                int SeciliId = CmbSecilecekUrunKategorisi.Items.Add(UrunKategorisi.KategoriId);
            }

            List<TblKategori> UrununTurleri = urunIslemleri.Kategoriler();
            foreach (var Kategori in UrunKategorileri)
            {
                var UrunKategoriCmb = CmbUrunTuru.Items.Add(Kategori.KategoriId);
            }
            //foreach (var Kategori in UrunKategorileri)
            //{
            //    var UrunKategoriCmb = CmbSilinecekUrunKategoriId.Items.Add(Kategori.KategoriId);
            //}

            ////////////////////////////////////////////////////////////////


            List<TblUye> UyeListesi = uyelikIslemleri.UyeListele();
            foreach (var Uye in UyeListesi)
            {
                LstUye.Items.Add(Uye.UyeId + " " + Uye.KullaniciAdi);
            }

            ////////////////////////////////////////////////////////////////
            ///

            List<TblUye> UyeListesiAdmin = uyelikIslemleri.UyeListele();
            foreach (var Uye in UyeListesiAdmin)
            {
                LstKisiUyeBilgileri.Items.Add("kullanıcı Adı :  " + Uye.KullaniciAdi + "  Uye Id :   " + Uye.UyeId + "   KisiId  :   " + Uye.KisiId);
            }

            //////////////////////////////////////////////////////

         List<TblKullaniciRolleri> tblKullaniciRolleriListesi =   uyelikIslemleri.KullaniciRolleriListesi();
            foreach (var Rol in tblKullaniciRolleriListesi)
            {
                CmbKullaniciRolleri.Items.Add(Rol.RolId);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblSaat.Text = DateTime.Now.ToString("HH:mm");
            LblTarih.Text = DateTime.Now.ToString("yyyy:MM:dd");

        }

        private void BtnMasaKategoriEkle2_Click(object sender, EventArgs e)
        {
            LstMasaKategorileri.Items.Clear();

            tblMasaKategorileri = new TblMasaKategorileri();
            tblMasaKategorileri.MasaKategoriAdi = TxtMasaKategoriAdi.Text.Trim();
            string HataMesaji = "";
            bool basarili = yoneticiIslemleri.MasaKategoriEkle(tblMasaKategorileri, out HataMesaji);
            if (!basarili)
            {
                MessageBox.Show("Masa Kategorisi eklenemedi ");
            }
            else
            {
                MessageBox.Show("Masa Kategorisi ekleme Başarılı ");
            }

            var MasaKategoriListesi = masaIslemleri.MasaKategorileri();
            foreach (var MasaKategori in MasaKategoriListesi)
                LstMasaKategorileri.Items.Add(MasaKategori.MasaKategoriAdi);

        }

        private void TpgMasaKategoriEkle_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMasaKategoriSil_Click(object sender, EventArgs e)
        {
            LstMasaKategorileri.Items.Clear();

            string HataMesaji = "";

            var MasaKategoriListesi = masaIslemleri.MasaKategorileri();
            foreach (var MasaKategori in MasaKategoriListesi)
                LstMasaKategorileri.Items.Add(MasaKategori.MasaKategoriId + " " + MasaKategori.MasaKategoriAdi);


            int SelectedItem = Convert.ToInt32(CmbMasaKategorileri.SelectedItem);

            TblMasaKategorileri tblMasaKategorileri = new TblMasaKategorileri();
            tblMasaKategorileri.MasaKategoriId = SelectedItem;


            CmbMasaKategorileri.Items.Remove(CmbMasaKategorileri.SelectedItem);





            bool basarili = yoneticiIslemleri.MasaKategoriSil(tblMasaKategorileri.MasaKategoriId, out HataMesaji);

            if (!basarili)
            {
                MessageBox.Show("Islem Başarısız");
            }
            else
            {
                MessageBox.Show("Islem Başarılı");
                LstMasaKategorileri.Items.Clear();
                MasaKategoriListesi = masaIslemleri.MasaKategorileri();
                foreach (var MasaKategori in MasaKategoriListesi)
                    LstMasaKategorileri.Items.Add(MasaKategori.MasaKategoriId + " " + MasaKategori.MasaKategoriAdi);
            }




        }

        //private void CmbMasaKategorileri_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   var x = CmbMasaKategorileri.SelectedItem.ToString();
        //}

        private void button5_Click(object sender, EventArgs e) //( masa ekle butonu)
        {
            LstMasaAdi.Items.Clear();

            TblMasalar masa = new TblMasalar();
            masa.MasaAdi = TxtMasaAdi.Text.Trim();
            masa.MasaKategoriId = Convert.ToInt32(TxtMasaKategoriID2.Text.Trim());
            masa.MasaDurumu = 1;
            masa.MasaKodu = masa.MasaAdi;

            string HataMesaji = "";
            bool result = yoneticiIslemleri.MasaEkle(masa, out HataMesaji);
            if (!result)
            {
                MessageBox.Show(HataMesaji);
            }
            else
            {
                MessageBox.Show("Masa Eklendi");

                var Masalar = masaIslemleri.Masalar();
                foreach (var Masa in Masalar)
                {
                    LstMasaAdi.Items.Add(Masa.MasaId + " " + Masa.MasaAdi);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e) //(masa sil butonu)
        {
            LstMasaAdi.Items.Clear();

            List<TblMasalar> Masalar = masaIslemleri.Masalar();
            foreach (var Masa in Masalar)
            {
                LstMasaAdi.Items.Add(Masa.MasaId + " " + Masa.MasaAdi);
            }




            int SelectedTable = Convert.ToInt32(CmbMasaAdi.SelectedItem);

            TblMasalar tblMasa = new TblMasalar();
            tblMasa.MasaId = SelectedTable;




            string hataMesaji = "";
            bool basarili = yoneticiIslemleri.MasaSil(tblMasa.MasaId, out hataMesaji);

            if (!basarili)
            {
                MessageBox.Show("işlem başarısız masa eklenemedi");
            }
            else
            {
                MessageBox.Show("Masa başarıyla silindi");
                LstMasaAdi.Items.Clear();
                Masalar = masaIslemleri.Masalar();
                foreach (var Masa in Masalar)
                {
                    LstMasaAdi.Items.Add(Masa.MasaId + " " + Masa.MasaAdi);
                }

            }
        }

        /////////////////////////////////////////////////
        private void BtnUrunKategoriEkle_Click(object sender, EventArgs e)
        {
            LstUrunKategorileri.Items.Clear();

            List<TblKategori> UrunKategoriListesi = urunIslemleri.Kategoriler();
            foreach (var UrunKategori in UrunKategoriListesi)
            {
                LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
            }

            TblKategori tblKategori = new TblKategori();
            tblKategori.KategoriAdi = TxtUrunKategoriAdi.Text.Trim();


            bool basarili = yoneticiIslemleri.UrunKategoriEkle(tblKategori, out string Mesaj);

            if (!basarili)
            {
                MessageBox.Show(Mesaj);
            }
            else
            {
                MessageBox.Show("Ürün kategorisi başarıyla eklendi");
                LstUrunKategorileri.Items.Clear();


                UrunKategoriListesi = urunIslemleri.Kategoriler();
                foreach (var UrunKategori in UrunKategoriListesi)
                {
                    LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
                }

            }
        }

        private void BtnUrunKategoriSil_Click(object sender, EventArgs e)
        {
            //LstUrunKategorileri.Items.Clear();
            //var UrunKategoriListesi = urunIslemleri.Kategoriler();
            //foreach (var UrunKategori in UrunKategoriListesi)
            //{
            //    LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
            //}


            //TblKategori tblKategori = new TblKategori();
            //tblKategori.KategoriId = Convert.ToInt32(TxtSilinecekUrunKategoriId.Text.ToString());

            ////   int KategoriId = Convert.ToInt32(CmbSilinecekUrunKategoriId.SelectedIndex.ToString());

            //string message;
            //bool basarili = yoneticiIslemleri.UrunKategoriSil(tblKategori.KategoriId, out message);


            //if (!basarili)
            //{
            //    MessageBox.Show("Ürün Kategorisi silinemedi");
            //}
            //else
            //{
            //    MessageBox.Show("Ürün Kategorisi silindi");
            //    LstUrunKategorileri.Items.Clear();


            //    UrunKategoriListesi = urunIslemleri.Kategoriler();
            //    foreach (var UrunKategori in UrunKategoriListesi)
            //    {
            //        LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
            //    }

            //}
            int selecteditem = Convert.ToInt32(CmbSilinecekUrunKategoriId.SelectedItem);

            LstUrunKategorileri.Items.Clear();
            var UrunKategoriListesi = urunIslemleri.Kategoriler();
            foreach (var UrunKategori in UrunKategoriListesi)
            {
                LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
            }


            TblKategori tblKategori = new TblKategori();


            CmbSilinecekUrunKategoriId.Items.Remove(CmbSilinecekUrunKategoriId.SelectedItem);



            tblKategori.KategoriId = selecteditem;




            string message;
            bool basarili = yoneticiIslemleri.UrunKategoriSil(tblKategori.KategoriId, out message);


            if (!basarili)
            {
                MessageBox.Show("Ürün Kategorisi silinemedi");
            }
            else
            {
                MessageBox.Show("Ürün Kategorisi silindi");
                LstUrunKategorileri.Items.Clear();


                UrunKategoriListesi = urunIslemleri.Kategoriler();
                foreach (var UrunKategori in UrunKategoriListesi)
                {
                    LstUrunKategorileri.Items.Add(UrunKategori.KategoriId + " " + UrunKategori.KategoriAdi);
                }

            }

        }

        //////////////////////////////////////////////////////////////

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            LstUrunListesi.Items.Clear();


            List<TblUrun> UrunListesi = urunIslemleri.UrunListesi();
            foreach (var Urun in UrunListesi)
            {
                LstUrunListesi.Items.Add(Urun.UrunId + " " + Urun.UrunAdi);
            }


            int SeciliUrunKategori = Convert.ToInt32(CmbSecilecekUrunKategorisi.SelectedItem);
            int UrunTuru = Convert.ToInt32(CmbUrunTuru.SelectedItem);

            string Message;
            TblUrun tblUrun = new TblUrun();
          
            //tblUrun.TblUrunStok = null;
            //tblUrun.TblUrunFiyat = null;
            //tblUrun.TblUrunHareketleri = null;
            //tblUrun.TblUrunKategorileri = null;
           
            tblUrun.UrunAdi = TxtUrunAdi.Text.Trim();
            tblUrun.Barkod = TxtBarkod.Text.Trim();

            //TblKategori tblKategori = new TblKategori();
            //tblKategori.KategoriId = UrunTuru;
            //tblKategori.KategoriAdi = "yemek";
          //  tblKategori.TblUrunKategorileri = null;

            //TblUrunKategorileri tblUrunKategorileri = new TblUrunKategorileri();
            //tblUrunKategorileri.UrunId = tblUrun.UrunId;
            //tblUrunKategorileri.KategoriId = UrunTuru ;
            //tblUrunKategorileri.TblUrun = tblUrun;
            //tblUrunKategorileri.TblKategori = tblKategori;





            bool basarili = yoneticiIslemleri.UrunEkle(tblUrun, /*tblUrunKategorileri,*/ /*tblKategori,*/ out Message);

            if (!basarili)
            {
                MessageBox.Show(Message);
            }
            else
            {
                MessageBox.Show("ürün ekleme başarılı");
                LstUrunListesi.Items.Clear();

                UrunListesi = urunIslemleri.UrunListesi();
                foreach (var Urun in UrunListesi)
                {
                    LstUrunListesi.Items.Add(Urun.UrunId + " " + Urun.UrunAdi);
                }

                string YeniMesaj;


                TblUrunKategorileri tblUrunKategorileri = new TblUrunKategorileri();
                tblUrunKategorileri.UrunId = tblUrun.UrunId;
                tblUrunKategorileri.KategoriId = UrunTuru;

               bool success = yoneticiIslemleri.UrunKategoriTablosuEkle(tblUrunKategorileri, out YeniMesaj);

                if (!success)
                {
                    YeniMesaj = "Ürün kategori ekleme başarısız";
                }
                else
                {
                    MessageBox.Show("ürün Kategori ekleme başarılı");
                }

            }


        }


        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            LstUrunListesi.Items.Clear();

            List<TblUrun> UrunListesi = urunIslemleri.UrunListesi();
            foreach (var Urun in UrunListesi)
            {
                LstUrunListesi.Items.Add(Urun.UrunId + " " + Urun.UrunAdi);
            }


            int SelectedItem = CmbUrunId.SelectedIndex;
            TblUrun tblUrun = new TblUrun();
            tblUrun.UrunId = SelectedItem;

            CmbUrunId.Items.Remove(CmbUrunId.SelectedIndex);

            string message;
            bool basarili = yoneticiIslemleri.UrunSil(tblUrun.UrunId, out message);


            if (!basarili)
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Ürün başarıyla eklendi");

                LstUrunListesi.Items.Clear();

                UrunListesi = urunIslemleri.UrunListesi();
                foreach (var Urun in UrunListesi)
                {
                    LstUrunListesi.Items.Add(Urun.UrunId + " " + Urun.UrunAdi);
                }

            }


        }
















        private void button4_Click_1(object sender, EventArgs e)
        {

        }


        private void BtnMasaKategoriEkle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TpgMasaKategoriEkle);
            //https://stackoverflow.com/questions/21691703/open-tab-pages-on-button-click-in-winform-c-sharp
        }

        private void BtnMasaEkle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TpgMasaEkle);
        }

        private void BtnUrunKategoriEkle2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TpgUrunKategoriEkle);
        }

        private void button1_Click(object sender, EventArgs e) //BtnUrunEkleBuyuk Buton
        {
            tabControl1.SelectTab(TpgUrunEkle);
        }

        private void button2_Click(object sender, EventArgs e) // BtnUüyükButonyeEkle B
        {
            tabControl1.SelectTab(TpgAdmin);
        }

        private void BtnUyeEkle_Click(object sender, EventArgs e)
        {
            FrmUyeEkle frmUyeEkle = new FrmUyeEkle();
            frmUyeEkle.ShowDialog();



        }

        private void BtnUyeSilBuyuk_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(TpgUyeSil);
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            LstUye.Items.Clear();
            TblUye tblUye = new TblUye();
            tblUye.UyeId = Convert.ToInt32(TxtUyeId.Text.Trim());

          bool basarili =  uyelikIslemleri.UyeSil(tblUye.UyeId);

            if (!basarili)
            {
                MessageBox.Show("Üye silme işlemi başarısız");
            }
            else
            {
                MessageBox.Show("Üye silme işlemi başarılı");

                List<TblUye> UyeListesi = uyelikIslemleri.UyeListele();
                foreach (var Uye in UyeListesi)
                {
                    LstUye.Items.Add(Uye.UyeId + " " + Uye.KullaniciAdi );
                }

            }


        }


        private void BtnAdminEkle_Click(object sender, EventArgs e)
        {
            LstKisiUyeBilgileri.Items.Clear();

            int KisiId = Convert.ToInt32(TxtKisiIdAdmin.Text.Trim());
            int UyeId = Convert.ToInt32(TxtUyeIdAdmin.Text.Trim());
            string Message = "";

            TblKullaniciRolleri tblKullaniciRolleri = new TblKullaniciRolleri();
            tblKullaniciRolleri.KullaniciId = UyeId;
            tblKullaniciRolleri.Admin = true;
            tblKullaniciRolleri.Raporlama = false;

         bool Eklendi =   uyelikIslemleri.AdminEkle(KisiId, UyeId, tblKullaniciRolleri, out Message);
            if (!Eklendi)
            {
                MessageBox.Show("Admin eklenemedi" + Message);
                FrmUyeEkle frmUyeEkle = new FrmUyeEkle();
                frmUyeEkle.ShowDialog();

            }
            else
            {
                MessageBox.Show("Admin kaydı başarıyla oluşturuldu");
                List<TblUye> UyeListesiAdmin = uyelikIslemleri.UyeListele();
                foreach (var Uye in UyeListesiAdmin)
                {
                    LstKisiUyeBilgileri.Items.Add("kullanıcı Adı :  " + Uye.KullaniciAdi + "  Uye Id :   " + Uye.UyeId + "   KisiId  :   " + Uye.KisiId  );
                }
            }

        }

        private void BtnAdminlikSil_Click(object sender, EventArgs e)
        {

            int RollId = Convert.ToInt32(CmbKullaniciRolleri.SelectedItem);  //Convert.ToInt32(TxtRollId.Text.Trim());

           bool Basarili = uyelikIslemleri.AdminlikSil(RollId);

            if (!Basarili)
            {
                MessageBox.Show("Admin yetkisi silme işlemi başarısız");
            }
            else
            {
                MessageBox.Show("Admin yetkisi silme işlemi başarılı");
              
            }

        }



    }
}
