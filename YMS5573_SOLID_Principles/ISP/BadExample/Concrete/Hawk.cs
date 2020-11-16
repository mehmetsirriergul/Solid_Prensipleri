using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.ISP.BadExample.Abstraction;

namespace YMS5573_SOLID_Principles.ISP.BadExample.Concrete
{
    public class Hawk : IBird
    {
        public string Fly()
        {
            return "Şahinler uçabilir..!";
        }

        public string Walk()
        {
            return "Şahinler yürüyebilir..!";
        }
    }
}
