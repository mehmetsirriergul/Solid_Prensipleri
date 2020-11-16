using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Prensipleri.SRP.GoodExample;
using SOLID_Prensipleri.SRP.Model;

namespace SOLID_Prensipleri.SRP.GoodExample
{
    public class GoodProduct
    {
        Good_Loger loger;

        public GoodProduct()
        {
            loger = new Good_Loger();
        }

        string log;

        public bool AddProduct(Product product)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(product.Id);
                sb.AppendLine();
                sb.Append(product.ProductName);
                sb.AppendLine();
                sb.Append(product.CategoryName);
                sb.AppendLine();
                sb.Append(product.CreateTime);
                sb.AppendLine();

                log = loger.BuildLog(sb.ToString());
                

                log = loger.BuildLog("Product add : " + product.Id);
                

                return true;
            }
            catch (Exception ex)
            {
                log = loger.BuildLog("Hata Mesajı: " + ex.Message);
               

                return false;
            }
        }
    }
}

