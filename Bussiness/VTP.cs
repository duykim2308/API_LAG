using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class VTP
    {
        public static int Create(List<DataObjects.VTPXML> lsArray)
        {
            return DataAccess.VTP.Create(lsArray);
        }

        public static int Create(DataObjects.VTPXML item)
        {
            List<DataObjects.VTPXML> lsArray = new List<DataObjects.VTPXML>();
            lsArray.Add(item);
            return DataAccess.VTP.Create(lsArray);
        }

        public static int Insert(DataObjects.VTPXML item)
        {
            if (item != null)
            { 
                return Create(item);
            }
            else
                return -1;

        }
    }
}
