using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class AX_TransferOrder
    {
        public static DataObjects.LAG.AX_TransferOrder Get(string fd, string td, string location)
        {
            return DataAccess.LAG.AX_TransferOrder.Get(fd, td, location);
        }

        public static DataObjects.LAG.AX_TransferOrderObject GetDetail(string id)
        {
            return DataAccess.LAG.AX_TransferOrder.GetDetail(id);
        }
    }
}
