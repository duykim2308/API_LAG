using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.HRV
{
    public class Product
    {
        public static int Create(List<DataObjects.HRV.Product> lsArray)
        {
            return DataAccess.HRV.Product.Create(lsArray);
        }
    }
}
