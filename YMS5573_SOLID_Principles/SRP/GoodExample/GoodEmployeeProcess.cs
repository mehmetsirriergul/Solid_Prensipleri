using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.SRP.Model;

namespace YMS5573_SOLID_Principles.SRP.GoodExample
{
    public class GoodEmployeeProcess
    {
        GoodLogerProcess logger;
        public GoodEmployeeProcess()
        {
            logger = new GoodLogerProcess();
        }

        string log;

        public bool InsertEmployee(Employee employee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.Append(employee.Id);
                sb.AppendLine();
                sb.Append(employee.FirstName);
                sb.AppendLine();
                sb.Append(employee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\YMS5573Log.txt", log);

                log = logger.BuildLog("Employee insert succesfully: " + employee.Id);
                logger.LogFile(@"C:\YMS5573Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                log = logger.BuildLog("Hata Mesajı: " + ex.Message);
                logger.LogFile(@"C:\YMS5573Log.txt", log);

                return false;
            }
        }
    }
}
