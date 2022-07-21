using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_TrackingSerial
    {
        public static DataObjects.LAG.AX_TrackingSerial Get(string search)
        {
            DataObjects.LAG.AX_TrackingSerial trackingSerial = new DataObjects.LAG.AX_TrackingSerial();
            List<DataObjects.LAG.ImEx> lsArrayImEx = new List<DataObjects.LAG.ImEx>();
            List<DataObjects.LAG.ERPs> lsArrayERPs = new List<DataObjects.LAG.ERPs>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@serial", search)); 
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_AX_Serial_Tracking", lsInput);
                if (ds.Tables.Count >= 1)
                {
                    System.Data.DataTable dtHeader = ds.Tables[0];
                    System.Data.DataTable dtEx = ds.Tables[1];
                    System.Data.DataTable dtErp = ds.Tables[2];
                    foreach (System.Data.DataRow row in dtHeader.Rows) { trackingSerial = new DataObjects.LAG.AX_TrackingSerial(row); }

                    foreach (System.Data.DataRow row in dtEx.Rows) { lsArrayImEx.Add(new DataObjects.LAG.ImEx(row)); }
                    if (lsArrayImEx.Count > 0) trackingSerial.imExs = lsArrayImEx;

                    foreach (System.Data.DataRow row in dtErp.Rows) { lsArrayERPs.Add(new DataObjects.LAG.ERPs(row)); }
                    if (lsArrayERPs.Count > 0) trackingSerial.ERPs = lsArrayERPs;
                }
                else trackingSerial = null;
             
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_Serial_Tracking" + ex.Message); }
            finally { conn.Close(); }
            return trackingSerial;
        }
    }
}
