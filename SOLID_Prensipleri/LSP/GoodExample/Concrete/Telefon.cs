using SOLID_Prensipleri.LSP.GoodExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.LSP.GoodExample.Concrete
{
    public class Telefon
    {
        readonly Base _samsung = new Samsung();
        readonly Samsung _samsung1 = new Samsung();
        readonly Base _iphone = new Iphone();

        public void Tel(string value)
        {
            _samsung.ekran(value);
            _samsung1.hafiza(value);
            _iphone.ekran(value);
        }
    }
}
