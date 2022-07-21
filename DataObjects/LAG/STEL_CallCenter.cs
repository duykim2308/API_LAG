using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class STEL_CallCenter
    {
        public int worldfonepbxmanagerid { get; set; }
        public string direction { get; set; }
        public string callstatus { get; set; }
        public string workstatus { get; set; }
        public DateTime starttime { get; set; }
        public DateTime answertime { get; set; }
        public DateTime endtime { get; set; }
        public int totalduration { get; set; }
        public int billduration { get; set; }
        public string calluuid { get; set; }
        public string user { get; set; }
        public string userextension { get; set; }
        public string customer { get; set; }
        public string customernumber { get; set; }
        public string customertype { get; set; }
        public string customercode { get; set; }
        public string calltype { get; set; }
        public string disposition { get; set; }
        public string dnis { get; set; }
        public string causetxt { get; set; }


        public STEL_CallCenter()
        {
            worldfonepbxmanagerid = 0;
            direction = "";
            callstatus = "";
            workstatus = "";
            starttime = DateTime.Now;
            answertime = DateTime.Now;
            endtime = DateTime.Now;
            totalduration = 0;
            billduration = 0;
            calluuid = "";
            user = "";
            userextension = "";
            customer = "";
            customernumber = "";
            customertype = "";
            customercode = "";
            calltype = "";
            disposition = "";
            dnis = "";
            causetxt = "";
        }

        public STEL_CallCenter(System.Data.DataRow row)
        {
            worldfonepbxmanagerid = row["worldfonepbxmanagerid"] != null ? int.Parse(row["worldfonepbxmanagerid"].ToString()) : 0;
            direction = row["direction"] != null ? row["direction"].ToString() : "";
            callstatus = row["callstatus"] != null ? row["callstatus"].ToString() : "";
            workstatus = row["workstatus"] != null ? row["workstatus"].ToString() : "";
            starttime = row["starttime"] != null ? DateTime.Parse(row["starttime"].ToString()) : DateTime.Now;
            answertime = row["answertime"] != null ? DateTime.Parse(row["answertime"].ToString()) : DateTime.Now;
            endtime = row["endtime"] != null ? DateTime.Parse(row["endtime"].ToString()) : DateTime.Now;
            totalduration = row["totalduration"] != null ? int.Parse(row["totalduration"].ToString()) : 0;
            billduration = row["billduration"] != null ? int.Parse(row["billduration"].ToString()) : 0;
            calluuid = row["calluuid"] != null ? row["calluuid"].ToString() : "";
            user = row["user"] != null ? row["user"].ToString() : "";
            userextension = row["userextension"] != null ? row["userextension"].ToString() : "";
            customer = row["customer"] != null ? row["customer"].ToString() : "";
            customernumber = row["customernumber"] != null ? row["customernumber"].ToString() : "";
            customertype = row["customertype"] != null ? row["customertype"].ToString() : "";
            customercode = row["customercode"] != null ? row["customercode"].ToString() : "";
            calltype = row["calltype"] != null ? row["calltype"].ToString() : "";
            disposition = row["disposition"] != null ? row["disposition"].ToString() : "";
            dnis = row["dnis"] != null ? row["dnis"].ToString() : "";
            causetxt = row["causetxt"] != null ? row["causetxt"].ToString() : "";
        }
    }

    public class STEL_CallCenterXML
    {
        public int worldfonepbxmanagerid { get; set; }
        public string direction { get; set; }
        public string callstatus { get; set; }
        public string workstatus { get; set; }
        public DateTime? starttime { get; set; }
        public DateTime? answertime { get; set; }
        public DateTime? endtime { get; set; }
        public int totalduration { get; set; }
        public int billduration { get; set; }
        public string calluuid { get; set; }
        public string user { get; set; }
        public string userextension { get; set; }
        public string customer { get; set; }
        public string customernumber { get; set; }
        public string customertype { get; set; }
        public string customercode { get; set; }
        public string calltype { get; set; }
        public string disposition { get; set; }
        public string dnis { get; set; }
        public string causetxt { get; set; }

    }


}
