using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Ninjavan
    {
        public static int Create(List<DataObjects.Ninjavan> lsArray)
        {
            return DataAccess.Ninjavan.Create(lsArray);
        }

        public static int Create(DataObjects.Ninjavan item)
        {
            List<DataObjects.Ninjavan> lsArray = new List<DataObjects.Ninjavan>();
            lsArray.Add(item);
            return DataAccess.Ninjavan.Create(lsArray);
        }

        public static int Insert(string Company, DataObjects.Ninjavan item)
        {
            if (item != null)
            {
                item.company = Company;
                return Create(item);
            }
            else
                return -1;

        }
    }
}
