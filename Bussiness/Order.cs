using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Order
    {
        public static DataSet Order_History(string ID)
        {
            return DataAccess.Order.Order_History(ID);
        }
    }
}
