using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Sipariş
    {
        public const decimal KDV = 0.18M;

        decimal VergiliFiyat;

        decimal ToplamFiyat;
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }


        public Sipariş()
        {
            SiparisDetayi siparisdetayi = new SiparisDetayi();
            
        }
        public decimal VergiHesaplama(int fiyat)
        {
            VergiliFiyat = fiyat * KDV;
            return VergiliFiyat;
        }

        public decimal HamHesap(int VergisizFiyat)
        {
            return VergisizFiyat;
        }

        public decimal ToplamHesap(int adet)
        {
            ToplamFiyat = VergiliFiyat * adet;
            return ToplamFiyat;
        }
    }
}
