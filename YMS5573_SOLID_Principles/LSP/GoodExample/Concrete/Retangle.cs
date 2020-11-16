using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.LSP.GoodExample.Abstraction;

namespace YMS5573_SOLID_Principles.LSP.GoodExample.Concrete
{
    public class Retangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RetangleAre()
        {
            return Width * Height;
        }
    }
}
