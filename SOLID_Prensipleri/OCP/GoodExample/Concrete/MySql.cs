using SOLID_Prensipleri.OCP.GoodExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.OCP.GoodExample.Concrete
{
    public class MySql : IVeritabani
    {
        public bool dbadi(string value)
        {
            return true;
        }
    }
}
