
using YMS5573_SOLID_Principles.LSP.GoodExample.Abstraction;

namespace YMS5573_SOLID_Principles.LSP.GoodExample.Concrete
{
    public class Square : Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
