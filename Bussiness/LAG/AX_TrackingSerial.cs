using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_TrackingSerial
    {
        public static DataObjects.LAG.AX_TrackingSerial Get(string search)
        {
            return DataAccess.LAG.AX_TrackingSerial.Get(search);
        }
    }
}
