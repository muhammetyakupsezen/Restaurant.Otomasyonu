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
        public FrmAdminPaneli()
        {
            InitializeComponent();
            yoneticiIslemleri = new TYoneticiIslemleri();
            masaIslemleri = new TMasaIslemleri();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnMasaKategoriEkle_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminPaneli_Load(object sender, EventArgs e)
        {
            tblMasaKategorileri = new TblMasaKategorileri();
            List<TblMasaKategorileri> MasaKategorileriListesi = yoneticiIslemleri.MasaKategorileriGoster();
            foreach (var MasaKategori in MasaKategorileriListesi)
            {
                int KategoriId = CmbMasaKategorileri.Items.Add(MasaKategori.MasaKategoriAdi);

            }

            var MasaKategoriListesi = masaIslemleri.MasaKategorileri();
            foreach (var MasaKategori in MasaKategoriListesi)
                LstMasaKategorileri.Items.Add(MasaKategori.MasaKategoriId + " " + MasaKategori.MasaKategoriAdi);

            ////////////////////////////////////////

            TblMasalar tblMasalar = new TblMasalar();
            List<TblMasalar> MasaListesi = yoneticiIslemleri.MasalariGoster();
            foreach (var Masa in MasaListesi)
            {
                var SeciliMasa = CmbMasaAdi.Items.Add(Masa.MasaAdi);
            }

            var Masalar = masaIslemleri.Masalar();
            foreach (var Masa in Masalar)
            {
                LstMasaAdi.Items.Add(Masa.MasaId + " " + Masa.MasaAdi);
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
            //   TMasaIslemleri masaIslemleri = new TMasaIslemleri();
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


            // int MasaKategoriID = Convert.ToInt32(CmbMasaKategorileri.SelectedItem.ToString());
            int MasaKategoriID = Convert.ToInt32(TxtMasaKategoriId.Text.Trim());

            bool basarili = yoneticiIslemleri.MasaKategoriSil(MasaKategoriID, out HataMesaji);

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

        private void button5_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            LstMasaAdi.Items.Clear();

            List<TblMasalar> Masalar = masaIslemleri.Masalar();
            foreach (var Masa in Masalar)
            {
                LstMasaAdi.Items.Add(Masa.MasaId + " " + Masa.MasaAdi);
            }


            // var seciliMasa= CmbMasaAdi.SelectedItem.ToString();

            TblMasalar tblMasa = new TblMasalar();
            tblMasa.MasaId = Convert.ToInt32(TxtMasaId.Text.Trim());

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
    }
}
