using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3_SiparişOtomasyonu
{
    public class Magaza
    {
        internal List<Müsteriler> MusteriListesi;
 
        internal void MusteriEkle(Müsteriler a)
        {
            MusteriListesi.Add(a);
        }
        internal List<Müsteriler> MusterileriKontrol()
        {
            return MusteriListesi;
        }



        internal Magaza()
        {
            MusteriListesi = new List<Müsteriler>();
        }




    }
}
