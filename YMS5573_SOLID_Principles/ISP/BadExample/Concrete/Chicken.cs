using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.ISP.BadExample.Abstraction;

namespace YMS5573_SOLID_Principles.ISP.BadExample.Concrete
{
    public class Chicken : IBird //Bu implemantation sonucunda "Chicken.cs" gereksiz davranışlara kazanmış olur.
    {

        public string Fly()
        {
            return "Her tavuk uçamaz..!";
        }

        public string Walk()
        {
            return "Tavuk yürüyebilir..!";
        }
    }
}
