using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5573_SOLID_Principles.DIP.Bad
{
    public class BadRestaurant
    {
        BadFish perch = new BadFish();
        BadPoultry duck = new BadPoultry();

        public string GenerateInstruction()
        {
            return perch.GetFishCookingInstruction() + " " + duck.GetPoultryCookingınstructions();
        }
    }
}
