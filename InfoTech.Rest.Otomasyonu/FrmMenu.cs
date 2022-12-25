using InfoTech.Rest.BusinessLayer;
using InfoTech.Rest.DataLayer;
using InfoTech.Rest.Otomasyon.AdisyonPanel;
using InfoTech.Rest.UrunPanel;
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
    public partial class FrmMenu : Form
    {
        private UrunIslemleri urunIslemleri;
        public int SepetId;
        public FrmMenu()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false;
            urunIslemleri = new UrunIslemleri();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(2000);
                 MenuKategorileriDiz();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata meydana geldi" + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private async Task MenuKategorileriDiz()
        {

            List<TblKategori> MenuKategoriler = urunIslemleri.Kategoriler();
            if (MenuKategoriler != null)
            {
                foreach (var MenuKategori in MenuKategoriler)
                {
                    TabPage tabPage = new TabPage();
                    tabPage.Name = "Kategori_" + MenuKategori.KategoriId.ToString();
                    tabPage.Tag = MenuKategori;
                    tabPage.Text = MenuKategori.KategoriAdi;
                    tabPage.Parent = this.tabControl1;
                }
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            e.TabPage.Controls.Clear();
            TblKategori kategori = (TblKategori)e.TabPage.Tag;
            var KategorikUrunler = urunIslemleri.UrunGetir(kategori.KategoriId);
            int sayac = 0;
            for (int i = 0; i < KategorikUrunler.Count; i++)
            {
                TUrunPanel urunPanel = new TUrunPanel();
                urunPanel.OnUrunSec += UrunPanel_OnUrunSec;
                urunPanel.Urun = KategorikUrunler[i];
                urunPanel.Width = 300;
                urunPanel.Parent = e.TabPage;

             
                    urunPanel.Top = urunPanel.Height * i;

                //if (i<=2)
                //{
                //    urunPanel.Left = urunPanel.Width * i;
                //    urunPanel.Top = urunPanel.Height * i;
                //}
                //else
                //{
                //    if (i%2==1)
                //    {
                //        urunPanel.Left = urunPanel.Width * 2;
                //        urunPanel.Top = urunPanel.Height * i;
                //    }
                //    else if (i % 2 == 0)
                //    {
                //        urunPanel.Left = urunPanel.Width * 0;
                //        urunPanel.Top = urunPanel.Height * i;
                //    }


                //}




                //if (i <= 4)
                //{
                //   // urunPanel.Left = urunPanel.Width * i;
                //    urunPanel.Top = urunPanel.Height*i;
                //}
                //else
                //{
                //    urunPanel.Top = sayac * 150;
                //    if (i % 4 == 1)
                //    {
                //        urunPanel.Left = 0;
                //        urunPanel.Top = urunPanel.Height * sayac;
                //        sayac = 0;
                //    }
                //    else
                //    {
                //        urunPanel.Left = urunPanel.Width * sayac;
                //        sayac++;
                //    }
                //}

                urunPanel.Parent = e.TabPage;
            }
            

        }

        private void UrunPanel_OnUrunSec(VwKategorikUrunler SeciliUrun)
        {
            LblAdisyonTutar.Text = "0";
           TblSepetDetay sepetDetay = new TblSepetDetay()
            {
                UrunId = SeciliUrun.UrunId,
                Adet = 1,
                BirimFiyat = SeciliUrun.Fiyat,
                GuncelBirimFiyat = SeciliUrun.Fiyat,
                DovizId = SeciliUrun.DovizId,
                GuncelKdvOrani = SeciliUrun.KdvOrani,
                SepetId = Convert.ToInt32(LblAdisyonNo.Text),
                IndirimOrani = 0,
                KdvOrani = SeciliUrun.KdvOrani,
                KuponId = 0,
                KuponKodu = ""
                
            };
            bool Eklendi;
            TSepetIslemleri.SepeteEkle(sepetDetay, out Eklendi);
            if (Eklendi)
            {
                TAdisyonDetay adisyonDetay = new TAdisyonDetay();
                adisyonDetay.Dock = DockStyle.Top;
                adisyonDetay.UrunAdi = SeciliUrun.UrunAdi;
                adisyonDetay.Adet = 1;
                adisyonDetay.AraToplam = SeciliUrun.Fiyat;
                adisyonDetay.Parent = PnlAdisyonUrunler;
            }            
            int UrunSayisi /*= TSepetIslemleri.SepetListesi.Count*/ ;
            double SepetToplami = TSepetIslemleri.SepetToplami(out UrunSayisi);
            LblAdisyonTutar.Text = SepetToplami.ToString("f");
            //MessageBox.Show(SeciliUrun.UrunAdi);
        }
    }
}
 //private void AdisyonDiz(List<VwSepetDetay> SepetDetayListesi)
 //       {
 //           PnlAdisyonUrunler.Controls.Clear();
 //           if (SepetDetayListesi != null)
 //           {
 //               foreach (var SepetDetay in SepetDetayListesi)
 //               {
 //                   TAdisyonDetay AdisyonDetay = new TAdisyonDetay();
 //                   AdisyonDetay.Dock = DockStyle.Top;
 //                   AdisyonDetay.Name = "AdisyonDetay_" + SepetDetay.SepetDetayId.ToString();
 //                   AdisyonDetay.AraToplam = SepetDetay.AraToplam.Value;
 //                   AdisyonDetay.UrunAdi = SepetDetay.UrunAdi;
 //                   AdisyonDetay.Doviz = SepetDetay.Doviz;
 //                   AdisyonDetay.Parent = PnlAdisyonUrunler;
 //               }
 //           }
 //       }