using SOLID_Prensipleri.LSP.GoodExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.LSP.GoodExample.Concrete
{
    public class Iphone : Base
    {
        public override void ekran(string value)
        {
            throw new NotImplementedException();
        }
    }
}
