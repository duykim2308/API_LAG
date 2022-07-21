using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_TransferOrder
    {
        public static DataObjects.LAG.AX_TransferOrder Get(string fd, string td, string location)
        {
            DataObjects.LAG.AX_TransferOrder transferOrder = new DataObjects.LAG.AX_TransferOrder();
            List<DataObjects.LAG.TransferOrder> lsArray = new List<DataObjects.LAG.TransferOrder>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@fd", fd)); 
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@td", td)); 
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", location)); 
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_TransferOrder_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.TransferOrder(row)); }
                if (lsArray.Count > 0) transferOrder.transferorders = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_TransferOrder_Get" + ex.Message); }
            finally { conn.Close(); }
            return transferOrder;
        }

        public static DataObjects.LAG.AX_TransferOrderObject GetDetail(string id)
        {
            DataObjects.LAG.AX_TransferOrderObject transferorder = new DataObjects.LAG.AX_TransferOrderObject();
            DataObjects.LAG.TransferOrder header = new DataObjects.LAG.TransferOrder();
            List<DataObjects.LAG.TransferLine> lsLine = new List<DataObjects.LAG.TransferLine>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", id)); 
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_AX_TransferOrder_GetDetail", lsInput);
                if(ds.Tables.Count == 2)
                {
                    DataTable dtheader = new DataTable();
                    DataTable dtline = new DataTable();
                    dtheader = ds.Tables[0];
                    dtline = ds.Tables[1];
                    foreach (System.Data.DataRow row in dtheader.Rows) { header = new DataObjects.LAG.TransferOrder(row); }
                    foreach (System.Data.DataRow row in dtline.Rows) { lsLine.Add(new DataObjects.LAG.TransferLine(row)); }
                    transferorder.transferorder = header;
                    transferorder.transferlines = lsLine;
                }
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_TransferOrder_GetDetail" + ex.Message); }
            finally { conn.Close(); }
            return transferorder;
        }
    }
}
 