using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.LSP.BadExample
{
    public class Samsung : Base
    {
        public override void ekran(string value)
        { 
            olculer(5.1);
        }

        public override void hafiza(string value)
        {
            throw new NotImplementedException();
        }
    }
}
