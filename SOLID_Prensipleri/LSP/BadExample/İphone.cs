using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.LSP.BadExample
{
    public class İphone : Base
    {
        public override void ekran(string value)
        {
            throw new NotImplementedException();
        }

        public override void hafiza(string value)
        {
            throw new NotImplementedException();
        }
    }
}
