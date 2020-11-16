using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Prensipleri.OCP.BadExample
{
    public class VeriEkleme
    {
        private readonly SQl _sql;
        private readonly Mysql _mysql;

        public VeriEkleme(SQl sql, Mysql mysql)
        {
            _sql = sql;
            _mysql = mysql;
        }

        public void veritabanidurumu(Dbler type,string value)
        {
            switch (type)
            {
                case Dbler.SQL:_sql.Sql(value);

                    break;
                case Dbler.Mysql:
                    _mysql.mysql(value);
                    break;
                
            }

        }
    }
}
