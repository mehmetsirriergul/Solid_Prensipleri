using SOLID_Prensipleri.DIP.Good.Absraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.DIP.Good.Concrete
{
    public class Fabrika
    {
        List<IYemYapilisi> yemYapilisi;
        public Fabrika()
        {
            yemYapilisi = new List<IYemYapilisi>();
        }

        public string planlama()
        {
            string uretim = string.Empty;
            foreach (var item in yemYapilisi)
            {
                uretim += "" + item.YemYapilisi();
            }
            return uretim;
        }



    }
}
