using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5573_SOLID_Principles.OCP.GoodExample.Abstraction
{
    public abstract class GoodCoffee
    {
        public abstract double GetTotalPrice(double amount);
    }
}
