﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.ISP.GoodExample.Abstraction;

namespace YMS5573_SOLID_Principles.ISP.GoodExample.Concrete
{
    public class Penguin : IFlightlessBird, ISwimmingBird
    {
        public string Swim()
        {
            return "Penguin can swimm..!";
        }

        public string Walk()
        {
            return "Penguin can walk..!";
        }
    }
}
