using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.HRV
{
    public class Order
    {
        public static int Create(DataObjects.HRV.Order obj)
        {
            return DataAccess.HRV.Order.Create(obj);
        }

        public static int CreateXML(DataObjects.HRV.Order order)
        {
            List<DataObjects.HRV.Order> lsArray = new List<DataObjects.HRV.Order>();
            lsArray.Add(order);
            return CreateXML(lsArray);
        }

        public static int CreateXML(List<DataObjects.HRV.Order> lsOrders)
        {
            if (lsOrders != null)
            {
                //lsOrders.ForEach(fe => fe.ProcessLineItemNew());
                lsOrders.ForEach(fe => fe.ResetShippingAddress());
                //lsOrders.ForEach(fe => fe.ProcessComments());
                List<DataObjects.HRV.OrderXML> lsArray = new List<DataObjects.HRV.OrderXML>();
                lsOrders.ForEach(fe => lsArray.Add(new DataObjects.HRV.OrderXML(fe)));
                return DataAccess.HRV.Order.CreateXML(lsArray);
            }
            else
                return -1;
        }

    }
}
