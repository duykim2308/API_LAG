using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_Customer
    {
        public static DataObjects.LAG.AX_Customers Get(string search)
        {
            return DataAccess.LAG.AX_Customer.Get(search);
        }
    }
}
