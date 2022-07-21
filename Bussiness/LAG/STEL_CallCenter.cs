using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.LAG
{
    public class STEL_CallCenter
    {
        public static int Create(List<DataObjects.LAG.STEL_CallCenterXML> lsArray)
        {
            return DataAccess.LAG.STEL_CallCenter.Create(lsArray);
        }

        public static int Create(DataObjects.LAG.STEL_CallCenterXML item)
        {
            List<DataObjects.LAG.STEL_CallCenterXML> lsArray = new List<DataObjects.LAG.STEL_CallCenterXML>();
            lsArray.Add(item);
            return DataAccess.LAG.STEL_CallCenter.Create(lsArray);
        }

        public static int Insert(DataObjects.LAG.STEL_CallCenterXML item)
        {
            if (item != null)
            {
                return Create(item);
            }
            else
                return -1;

        }

        //public static List<DataObjects.LAG.STEL_CallCenter> Create(int worldfonepbxmanagerid, string direction, string callstatus
        //   , string workstatus, DateTime starttime, DateTime answertime, DateTime endtime
        //   , int totalduration, int billduration, string calluuid, string user
        //   , string userextension, string customer, string customernumber, string customertype, string customercode, string calltype, string disposition, string dnis, string causetxt)
        //{
        //    return DataAccess.LAG.STEL_CallCenter.Create(worldfonepbxmanagerid, direction, callstatus, workstatus, starttime, answertime, endtime, totalduration
        //        , billduration, calluuid, user, userextension, customer, customernumber, customertype, customercode, calltype, disposition, dnis, causetxt);
        //}
    }
}
