using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.OCP.GoodExample.Abstraction;

namespace YMS5573_SOLID_Principles.OCP.GoodExample.Concrete
{
    public class Espresso:GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 6.75;
        }
    }
}
