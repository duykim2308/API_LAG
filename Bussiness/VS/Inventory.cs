using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.VS
{
    public class Inventory
    {
        public static DataObjects.VS.Inventory Get()
        {
            return DataAccess.VS.Inventory.Get();
        }
    }
}
