using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5573_SOLID_Principles.OCP.BadExample
{
    public enum CoffeeType
    {
        Latte,
        Espresso,
        Machiato
    }

    public class BadCoffe
    {
        public double GetTotalPrice(double amount, CoffeeType coffeeType)
        {
            double totalPrice = 0;

            if (coffeeType == CoffeeType.Espresso)
            {
                totalPrice += amount * 4.50;
            }
            else if (coffeeType == CoffeeType.Latte)
            {
                totalPrice += amount * 5.25;
            }
            else if(coffeeType == CoffeeType.Machiato)
            {
                totalPrice += amount * 6.75;
            }
            return totalPrice;
        }
    }
}
