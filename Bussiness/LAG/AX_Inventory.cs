using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_Inventory
    {
        public static DataObjects.LAG.AX_Inventory Get(string location, string item)
        {
            return DataAccess.LAG.AX_Inventory.Get(location, item);
        }
    }
}
