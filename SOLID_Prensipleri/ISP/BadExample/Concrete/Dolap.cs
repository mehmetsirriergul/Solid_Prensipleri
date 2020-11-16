using SOLID_Prensipleri.ISP.BadExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.ISP.BadExample.Concrete
{
    public class Dolap : IMobilya
    {
        public string cekmece()
        {
            return "3 çekmekce olacak..!";
        }

        public string kapak()
        {
            return "2 kapak olacak"; 
        }

        public string mentese()
        {
            return "Tek menteşe olacak"; 
        }
    }
}
