using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5573_SOLID_Principles.LSP.GoodExample.Abstraction
{
    public abstract class Shape
    {
        //Diğer bütün sınınflarda kalıtım verecek ortak özellikler burada yazılır.

        public int Id { get; set; }
    }
}
