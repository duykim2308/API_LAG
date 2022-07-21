using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_SalesOrder
    {
        public static DataObjects.LAG.AX_SalesOrder Get(string fd, string td, string location)
        {
            DataObjects.LAG.AX_SalesOrder salesorders = new DataObjects.LAG.AX_SalesOrder();
            List<DataObjects.LAG.SalesOrder> lsArray = new List<DataObjects.LAG.SalesOrder>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@fd", fd)); 
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@td", td)); 
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", location)); 
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_SalesOrder_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.SalesOrder(row)); }
                if (lsArray.Count > 0) salesorders.salesorders = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_SalesOrder_Get" + ex.Message); }
            finally { conn.Close(); }
            return salesorders;
        }

        public static DataObjects.LAG.AX_SalesOrderObject GetDetail(string id)
        {
            DataObjects.LAG.AX_SalesOrderObject salesorder = new DataObjects.LAG.AX_SalesOrderObject();
            DataObjects.LAG.SalesOrder header = new DataObjects.LAG.SalesOrder();
            List<DataObjects.LAG.SalesLine> lsLine = new List<DataObjects.LAG.SalesLine>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", id)); 
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_AX_SalesOrder_GetDetail", lsInput);
                if(ds.Tables.Count == 2)
                {
                    DataTable dtheader = new DataTable();
                    DataTable dtline = new DataTable();
                    dtheader = ds.Tables[0];
                    dtline = ds.Tables[1];
                    foreach (System.Data.DataRow row in dtheader.Rows) { header = new DataObjects.LAG.SalesOrder(row); }
                    foreach (System.Data.DataRow row in dtline.Rows) { lsLine.Add(new DataObjects.LAG.SalesLine(row)); }
                    salesorder.salesorder = header;
                    salesorder.saleslines = lsLine;
                }
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_SalesOrder_GetDetail" + ex.Message); }
            finally { conn.Close(); }
            return salesorder;
        }
    }
}
 