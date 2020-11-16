using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.DIP.Good.Absraction;

namespace YMS5573_SOLID_Principles.DIP.Good.Concrete
{
    public class Levrek : IProduct
    {
        public string GetCookingınstruction()
        {
            return "fırında levrek tarifi..!";
        }
    }
}
