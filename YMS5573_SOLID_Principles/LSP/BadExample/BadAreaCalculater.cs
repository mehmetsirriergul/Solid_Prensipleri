using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5573_SOLID_Principles.LSP.BadExample
{
    public class BadAreaCalculater
    {
        public static double CalculateArea(BadRetangle retangle)
        {
            return retangle.Height * retangle.Width;
        }

        public static double CalculateArea(BadSquare badSquare)
        {
            return badSquare.Width * badSquare.Height;
        }
    }
}
