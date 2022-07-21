using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_SalesOrder
    {
        public static DataObjects.LAG.AX_SalesOrder Get(string fd, string td, string location)
        {
            return DataAccess.LAG.AX_SalesOrder.Get(fd, td, location);
        }

        public static DataObjects.LAG.AX_SalesOrderObject GetDetail(string id)
        {
            return DataAccess.LAG.AX_SalesOrder.GetDetail(id);
        }
    }
}
