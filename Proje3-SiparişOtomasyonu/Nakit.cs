using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    class Nakit : Odeme
    {
        public decimal NakitMiktari { get; set; }


        bool Onay=false;
        public override void Yetkili()
        {
            Onay = true;
        }
    }
}
