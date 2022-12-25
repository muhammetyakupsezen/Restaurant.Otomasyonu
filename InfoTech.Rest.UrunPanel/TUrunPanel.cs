using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoTech.Rest.DataLayer;

namespace InfoTech.Rest.UrunPanel
{
    public delegate void RxOnUrunSec(VwKategorikUrunler SeciliUrun);
    public partial class TUrunPanel : UserControl
    {
        public event RxOnUrunSec OnUrunSec;
        private VwKategorikUrunler FUrun;

        public VwKategorikUrunler Urun
        {
            get { return GetUrun(); }
            set { SetUrun(value); }
        }

        private void SetUrun(VwKategorikUrunler value)
        {
            FUrun = value;
            FiyatHesapla(ref FUrun);
            LblUrunAdi.Text = FUrun.UrunAdi;
            LblUrunFiyati.Text = FUrun.Fiyat.ToString("f");
        }

        private VwKategorikUrunler GetUrun()
        {
            return FUrun;
        }

        public TUrunPanel()
        {
            InitializeComponent();
        }

        private void FiyatHesapla(ref VwKategorikUrunler urunBilgisi)
        {
            double BirimFiyat = urunBilgisi.Fiyat;
            double KdvOrani = urunBilgisi.KdvOrani;
            urunBilgisi.Fiyat = (BirimFiyat * KdvOrani / 100) + BirimFiyat;
        }

        private void LblUrunAdi_Click(object sender, EventArgs e)
        {
            if (OnUrunSec!=null)
                OnUrunSec(FUrun);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OnUrunSec != null)
                OnUrunSec(FUrun);
        }

        private void LblUrunFiyati_Click(object sender, EventArgs e)
        {
            if (OnUrunSec != null)
                OnUrunSec(FUrun);
        }
    }
}
