using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.DIP.Good.Absraction;

namespace YMS5573_SOLID_Principles.DIP.Good.Concrete
{
    public class Restaurant
    {
        List<IProduct> products; 
        public Restaurant()
        {
            products = new List<IProduct>();
        }
        public string GenerateInstruction()
        {
            string instruction = string.Empty;
            foreach (var item in products)
            {
                instruction += " " + item.GetCookingınstruction();
            }
            return instruction;
        }
    }
}
