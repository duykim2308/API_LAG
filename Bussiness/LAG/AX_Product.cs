using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_Product
    {
        public static List<DataObjects.LAG.AX_Product> Get()
        {
            return DataAccess.LAG.AX_Product.Get();
        }
    }
}
