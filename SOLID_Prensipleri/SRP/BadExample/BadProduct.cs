using SOLID_Prensipleri.SRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.SRP.BadExample
{
   public  class BadProduct
    {
        public void AddProduct(Product newproduct)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(newproduct.Id);
                sb.AppendLine();
                sb.Append(newproduct.ProductName);
                sb.AppendLine();
                sb.Append(newproduct.CategoryName);
                sb.AppendLine();
                sb.Append(newproduct.CreateTime);
                sb.AppendLine();

                sb = new StringBuilder();
                sb.Append("Eklenme Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append(newproduct.Id);

                    }
            catch (Exception ex)
            {

                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata mesajı: ");
                sb.AppendLine(ex.Message);
            }
        }
    }
}
