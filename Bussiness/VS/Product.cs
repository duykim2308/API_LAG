using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.VS
{
    public class AX_Product
    {
        public static DataObjects.VS.Product Get()
        {
            return DataAccess.VS.Product.Get();
        }
    }
}
