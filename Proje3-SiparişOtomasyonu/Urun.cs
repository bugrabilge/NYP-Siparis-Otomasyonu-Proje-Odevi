using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Urun
    {
        public decimal KargoAgirligi { get; set; }
        public string Tanım { get; set; }
        public decimal Fiyat { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SatinAlanIsim { get; set; }

        public string SatinAlanNick { get; set; }
        public string SatinAlanSoyisim { get; set; }
        public string SatinAlanSehir { get; set; }

        public decimal MiktarIcinFiyatAl(string girilenfiyat)
        {
            this.Fiyat = Convert.ToDecimal(girilenfiyat);
            return Fiyat;
        }

        public decimal AgirlikAl(string girilenagirlik)
        {
            this.KargoAgirligi = Convert.ToDecimal(girilenagirlik);
            return KargoAgirligi;
        }
    }
}
