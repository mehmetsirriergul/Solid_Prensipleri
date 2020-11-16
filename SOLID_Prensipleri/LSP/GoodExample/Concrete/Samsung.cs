using SOLID_Prensipleri.LSP.GoodExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.LSP.GoodExample.Concrete
{
    public class Samsung : Base, IHafiza
    {
        public override void ekran(string value)
        {
            throw new NotImplementedException();
        }

        public void hafiza(string value)
        {
            throw new NotImplementedException();
        }
    }
}
