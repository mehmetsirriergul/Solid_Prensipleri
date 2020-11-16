using SOLID_Prensipleri.ISP.BadExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.ISP.BadExample.Concrete
{
    public class Unite : IMobilya
    {
        public string cekmece()
        {
            return "Tek çekmece olacak";
        }

        public string kapak()
        {
            return "4 Kapaklı olacak";
        }

        public string mentese()
        {
            return "Çift menteşe olacak";
        }
    }
}
