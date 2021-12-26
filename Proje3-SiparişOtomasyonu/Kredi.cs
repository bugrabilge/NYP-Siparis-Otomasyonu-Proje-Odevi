using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Kredi : Odeme
    {
        public ulong KartNumarasi { get; set; }
        public string Tip { get; set; }
        public int CVC { get; set; }
        public int SonKullanmaTarih { get; set; }

        bool Onay=false;
        public override void Yetkili()
        {
            Onay = true;
        }
    }
}
