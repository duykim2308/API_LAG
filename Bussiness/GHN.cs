using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class GHN
    {
        public static int Create(List<DataObjects.GHNXML> lsArray)
        {
            return DataAccess.GHN.Create(lsArray);
        }

        public static int Create(DataObjects.GHNXML item)
        {
            List<DataObjects.GHNXML> lsArray = new List<DataObjects.GHNXML>();
            lsArray.Add(item);
            return DataAccess.GHN.Create(lsArray);
        }

        public static int Insert(DataObjects.GHNXML item)
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
