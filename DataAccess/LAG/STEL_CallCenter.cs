using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class STEL_CallCenter
    {
        public static int Create(List<DataObjects.LAG.STEL_CallCenterXML> lsArray)
        {
            int result = -1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter { ParameterName = "@XML", SqlDbType = SqlDbType.Xml, Value = Utilities.XML.GetXMLFromObject(lsArray) });
                result = conn.ExecuteNonQuery("sp_CallCenter_Stel_Create", lsInput);
                conn.Commit();
            }
            catch (Exception ex) { conn.RollBack(); result = -1; Utilities.FileLog.WriteFileLog("DataAccess-->sp_CallCenter_Stel_Create::" + ex.Message); }
            finally { conn.Close(); }
            return result;
        }

        //public static List<DataObjects.LAG.STEL_CallCenter> Create(int worldfonepbxmanagerid, string direction, string callstatus
        //    , string workstatus, DateTime starttime, DateTime answertime, DateTime endtime
        //    , int totalduration, int billduration, string calluuid, string user
        //    , string userextension, string customer, string customernumber, string customertype, string customercode, string calltype, string disposition, string dnis, string causetxt)
        //{
        //    List<DataObjects.LAG.STEL_CallCenter> lsArray = new List<DataObjects.LAG.STEL_CallCenter>();
        //    DataProvider.ConnectionAPI conn = null;
        //    try
        //    {
        //        conn = new DataProvider.ConnectionAPI();
        //        conn.Open();
        //        List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@worldfonepbxmanagerid", worldfonepbxmanagerid));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@direction", direction));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@callstatus", callstatus));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@workstatus", workstatus));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@starttime", starttime));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@answertime", answertime));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@endtime", endtime));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@totalduration", totalduration));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@billduration", billduration));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@calluuid", calluuid));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@user", user));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@userextension", userextension));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@customer", customer));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@customernumber", customernumber));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@customertype", customertype));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@customercode", customercode));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@calltype", calltype));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@disposition", disposition));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@dnis", dnis));
        //        lsInput.Add(new System.Data.SqlClient.SqlParameter("@causetxt", causetxt));
        //        System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_CallCenter_Stel_Create", lsInput);
        //        foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.STEL_CallCenter(row)); }
        //    }
        //    catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_CallCenter_Stel_Create" + ex.Message); }
        //    finally { conn.Close(); }
        //    return lsArray;
        //}
    }
}
