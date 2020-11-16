using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.LSP.BadExample
{
    public class Telefon
    {
        readonly Base _iphone = new İphone();
        readonly Base _samsung = new Samsung();
        public void Tel(string value)
        {
            _iphone.ekran(value);
            _iphone.hafiza(value);

            _samsung.ekran(value);
            _samsung.hafiza(value);

        }
    }
}
