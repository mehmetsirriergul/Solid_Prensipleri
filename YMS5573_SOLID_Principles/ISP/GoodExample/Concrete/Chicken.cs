

using YMS5573_SOLID_Principles.ISP.GoodExample.Abstraction;

namespace YMS5573_SOLID_Principles.ISP.GoodExample.Concrete
{
    public class Chicken : IFlightlessBird
    {
        public string Walk()
        {
            return "Tavuklar yürür..!";
        }
    }
}
