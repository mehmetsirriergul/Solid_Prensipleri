using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.ISP.GoodExample.Abstraction;

namespace YMS5573_SOLID_Principles.ISP.GoodExample.Concrete
{
    public class Hawk : IFlightlessBird, IFlyingBird
    {
        public string Fly()
        {
            return "Hawks can flying..!";
        }

        public string Walk()
        {
            return "Hawks can walking..!";
        }
    }
}
