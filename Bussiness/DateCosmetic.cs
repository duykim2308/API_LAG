using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class DateCosmetic
    {
        public static DataObjects.DateCosmetic GetDate(string ItemNo, string Location)
        {
            DataObjects.DateCosmetic obj = DataAccess.DateCosmetic.GetDate(ItemNo, Location);
            return obj;
        }

        public static DataObjects.DateCosmeticERP GetPOSERP(string id, string company)
        {
            DataObjects.DateCosmeticERP obj = DataAccess.DateCosmetic.GetPOSERP(id, company);
            return obj;
        }

        public static List<DataObjects.DateCosmeticERP.Data> GetERP( string id, string type, string company)
        {
            List<DataObjects.DateCosmeticERP.Data> list = DataAccess.DateCosmetic.GetERP(id, type, company);
            return list;
        }

        public static int InsertPOSERP(DataObjects.DateCosmeticERP obj)
        {
            return DataAccess.DateCosmetic.InsertPOSERP(obj);
        }

        public static int InsertERP(string id, string location)
        {
            return DataAccess.DateCosmetic.InsertERP(id, location);
        }
    }
}
