using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.SRP.GoodExample
{
    public class Good_Loger
    {
        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date: ");
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Information: ").Append(information);
            return sb.ToString();
        }
    }
}
