using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5573_SOLID_Principles.SRP.Model;

namespace YMS5573_SOLID_Principles.SRP.BadExample
{
    public class BadEmployeeProcess
    {
        public void InsertEmployee(Employee newEmployee)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                #region 1.Process => Çalşılanın bilgilerini ekleme
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                File.WriteAllText(@"C:\YMS5573EmployeeData.txt", sb.ToString());
                #endregion

                #region 2.Process => Çalışan ekleme işlemin loglarının tutulması
                sb = new StringBuilder();
                sb.Append("Kayıt Ekeleme Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append(newEmployee.Id);
                File.WriteAllText(@"C:\YMS5573Log.txt", sb.ToString());
                #endregion
            }
            catch (Exception ex)
            {
                #region 3.Process => Ekleme işlemin hata alınırsa
                sb = new StringBuilder();
                sb.Append("Hata Tarihi: ");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata mesajı: ");
                sb.AppendLine(ex.Message);
                File.WriteAllText(@"C:\YMS5573Log.txt", sb.ToString());
                System.Windows.Forms.MessageBox.Show("Hata alındı..!");
                #endregion
            }
        }
    }
}
