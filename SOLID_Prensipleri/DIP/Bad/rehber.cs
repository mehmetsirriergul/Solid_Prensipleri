using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.DIP.Bad
{
    public class rehber
    {
        Ad _ad = new Ad();
        Soyad _soyad = new Soyad();
        public string adsoyad()
        {
            return _ad.isim() + " " + _soyad.soyisim();
        }
                       
    }
}
