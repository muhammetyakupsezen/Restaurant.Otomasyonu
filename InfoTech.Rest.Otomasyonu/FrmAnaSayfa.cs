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
using InfoTech.Rest.Otomasyon.AdisyonPanel;

namespace InfoTech.Rest.Otomasyonu
{
    public partial class FrmAnaSayfa : Form
    {
        private TMasaIslemleri MasaIslemleri;
        private List<TblMasalar> Masalar;
        private TblMasalar SeciliMasa = null;
        public FrmAnaSayfa()
        {
            InitializeComponent();
            MasaIslemleri = new TMasaIslemleri();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            LblSaat.Text = DateTime.Now.ToString("HH:mm");
        }

        private void FrmAnaSayfa_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

            List<TblMasaKategorileri> MasaKategorileri = MasaIslemleri.MasaKategorileri();
            Masalar = MasaIslemleri.Masalar();
            foreach (var MasaKategori in MasaKategorileri)
            {
                int sayac = 1;
                TabPage tabPage = new TabPage();
                tabPage.Name = "Kategori_" + MasaKategori.MasaKategoriId.ToString();
                tabPage.Text = MasaKategori.MasaKategoriAdi;
                tabPage.Tag = MasaKategori;
                tabPage.Parent = TabMasaKategorileri;
                List<TblMasalar> KategorikMasalar = Masalar.Where(t => t.MasaKategoriId == MasaKategori.MasaKategoriId).ToList();
                for (int i = 0; i < KategorikMasalar.Count; i++)
                {
                    Button BtnMasa = new Button();
                    BtnMasa.Click += BtnMasa_Click;
                    BtnMasa.Name = "BtnMasa_" + KategorikMasalar[i].MasaId.ToString();
                    BtnMasa.Width = 150;
                    BtnMasa.Height = 150;
                    BtnMasa.Tag = KategorikMasalar[i];
                    BtnMasa.Text = KategorikMasalar[i].MasaAdi.ToString();
                    if (i <= 7)
                    {
                        BtnMasa.Left = BtnMasa.Width * i;
                        BtnMasa.Top = 0;
                    }
                    else
                    {
                        BtnMasa.Top = sayac * 150;
                        if (i % 7 == 1)
                        {
                            BtnMasa.Left = 0;
                            sayac = 0;
                        }
                        else
                        {
                            BtnMasa.Left = BtnMasa.Width * sayac;
                            sayac++;
                        }
                    }
                    if (KategorikMasalar[i].MasaDurumu == 1)
                        BtnMasa.BackColor = Color.Green;
                    else if (KategorikMasalar[i].MasaDurumu == 2)
                        BtnMasa.BackColor = Color.OrangeRed;
                    else if (KategorikMasalar[i].MasaDurumu == 3)
                        BtnMasa.BackColor = Color.BlueViolet;
                    else if (KategorikMasalar[i].MasaDurumu == 4)
                        BtnMasa.BackColor = Color.Yellow;

                    BtnMasa.Parent = tabPage;
                }

            }

            

        }

        private void BtnMasa_Click(object sender, EventArgs e)
        {
            LblAdisyonTutar.Text = "0";
            LblMasa.Text = "";
            LblAdisyonNo.Text = "";

            if (sender is Button)
            {
                BtnMasaAc.Enabled = true;
                var ButonTag = ((Button)sender).Tag;
                TblMasalar masaDetay = (TblMasalar)ButonTag;
                SeciliMasa = masaDetay;
                LblSeciliMasa.Text = SeciliMasa.MasaKodu + " " + SeciliMasa.MasaAdi;
                string KimGonderdi = ((Button)sender).Name;
                List<VwSepetDetay> SepetDetay;
                TblSepet Sepet = MasaIslemleri.SepetGetir(masaDetay.MasaId, out SepetDetay);
                if (Sepet != null)
                {
                    LblMasa.Text = masaDetay.MasaKodu + " " + masaDetay.MasaAdi;
                    LblAdisyonNo.Text = Sepet.SepetId.ToString();
                    LblAdisyonTutar.Text = SepetDetay.Sum(d => d.AraToplam).Value.ToString("f");
                    BtnMasaAc.Enabled = false;
                }
                AdisyonDiz(SepetDetay);
            }
        }
        private void AdisyonDiz(List<VwSepetDetay> SepetDetayListesi)
        {
            PnlAdisyonUrunler.Controls.Clear();
            if (SepetDetayListesi != null)
            {
                foreach (var SepetDetay in SepetDetayListesi)
                {
                    TAdisyonDetay AdisyonDetay = new TAdisyonDetay();
                    AdisyonDetay.Dock = DockStyle.Top;
                    AdisyonDetay.Name = "AdisyonDetay_" + SepetDetay.SepetDetayId.ToString();
                    AdisyonDetay.AraToplam = SepetDetay.AraToplam.Value;
                    AdisyonDetay.UrunAdi = SepetDetay.UrunAdi;
                    AdisyonDetay.Doviz = SepetDetay.Doviz;
                    AdisyonDetay.Parent = PnlAdisyonUrunler;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.LblAdisyonNo.Text = LblAdisyonNo.Text;
            menu.LblMasa.Text = SeciliMasa.MasaAdi;            
            menu.ShowDialog();
        }

        private void BtnMasaAc_Click(object sender, EventArgs e)
        {
            if (SeciliMasa == null)
            {
                MessageBox.Show("Masa seçin");
            }
            else
            {
                DialogResult dr = MessageBox.Show(SeciliMasa.MasaAdi + " masa açılacaktır. Onaylıyor musunuz?", "Masa açma onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    PnlAdisyonUrunler.Controls.Clear();
                    LblAdisyonTutar.Text = "0";
                    LblMasa.Text = SeciliMasa.MasaKodu + " " + SeciliMasa.MasaAdi;
                    TblSepet sepet = new TblSepet();
                    sepet.OlusturmaTarihi = DateTime.Now;
                    sepet.MasaId = SeciliMasa.MasaId;
                    int AdisyonId;
                    bool Acildi = MasaIslemleri.MasaAc(sepet, out AdisyonId);
                    if (Acildi)
                    {
                        MessageBox.Show("Masa açıldı");
                        LblAdisyonNo.Text = AdisyonId.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Masa açılamadı");
                    }

                    
                }
            }
        }
    }
}
