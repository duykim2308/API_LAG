using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_Location
    {
        public static DataObjects.LAG.AX_Location Get()
        {
            return DataAccess.LAG.AX_Location.Get();
        }
    }
}
