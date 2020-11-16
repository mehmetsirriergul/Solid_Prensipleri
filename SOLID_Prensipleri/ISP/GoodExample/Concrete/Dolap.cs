using SOLID_Prensipleri.ISP.GoodExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.ISP.GoodExample.Concrete
{
    public class Dolap : ICekmeceMob, IKapakMob
    {
        public string cekmece()
        {
            return "2 çekmelceli olacak";
        }

        public string kapak()
        {
            return "4 kapaklı olacak";
        }
    }
}
