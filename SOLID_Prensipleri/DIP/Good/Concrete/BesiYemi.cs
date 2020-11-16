using SOLID_Prensipleri.DIP.Good.Absraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.DIP.Good.Concrete
{
    public class BesiYemi : IYemYapilisi
    {
        public string YemYapilisi()
        {
            return"Besi Yemi rasyonlarına göre yem yapılır";
        }
    }
}
