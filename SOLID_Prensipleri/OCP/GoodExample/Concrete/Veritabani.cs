using SOLID_Prensipleri.OCP.GoodExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.OCP.GoodExample.Concrete
{
    public class Veritabani
    {
        private readonly IVeritabani _veritabani;
        public Veritabani(IVeritabani veritabani)
        {
            _veritabani = veritabani;
        }

        public void Dbadi(string value)
        {
            _veritabani.dbadi(value);
        }
    }
}
