using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Müsteriler
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Sehir { get; set; }

        public Kredi Kredi { get; set; }
        public Cek Cek { get; set; }

        public Nakit Nakit { get; set; }

        public List<Urun> UrunListem { get; set; }
        public Sipariş Siparis { get; set; }

        public void ListemeUrunEkle(Urun a)
        {
            UrunListem.Add(a);
        }

        public void UrunlerimeAtamaYap(List<string> satılanurunler, string satinalankisi, string satinalansehir , string satinalanisim, string satinalansoyisim)
        {
            foreach (string satilan in satılanurunler)
            {
                foreach (Urun urun in UrunListem)
                {
                    if (urun.Tanım == satilan)
                    {
                        urun.SatinAlanNick = satinalankisi;
                        urun.SatinAlanIsim = satinalanisim;
                        urun.SatinAlanSoyisim = satinalansoyisim;
                        urun.SatinAlanSehir = satinalansehir;
                    }
                }

            }
        }

        public void UrunlerimdenCikar(string urununAdi, string urununModeli)
        {
            foreach (Urun urun in UrunListem)
            {
                if (urununAdi == urun.Tanım && urun.Model == urununModeli)
                {
                    UrunListem.Remove(urun);
                }
            }
        }
        public Müsteriler()
        {
            this.UrunListem = new List<Urun>();
            this.Kredi = new Kredi();
            this.Cek = new Cek();
            this.Nakit = new Nakit();
            this.Siparis = new Sipariş();
        }

    }
}
