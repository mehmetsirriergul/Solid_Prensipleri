using SOLID_Prensipleri.DIP.Good.Absraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.DIP.Good.Concrete
{
    public class SütYemi : IYemYapilisi
    {
        public string YemYapilisi()
        {
            return "Süt Yemi rasyonlarına göre üretimi yapılır";
        }
    }
}
