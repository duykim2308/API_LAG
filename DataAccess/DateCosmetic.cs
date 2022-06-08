using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess
{
    public class DateCosmetic
    {
        public static DataObjects.DateCosmetic GetDate(string ItemNo, string Location)
        {
            DataObjects.DateCosmetic obj = new DataObjects.DateCosmetic();
            List<DataObjects.DateCosmetic.Data> arrays = new List<DataObjects.DateCosmetic.Data>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@item", ItemNo));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", Location));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("TFS_RET_r012_CosmeticDate_API_GetDate", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { arrays.Add(new DataObjects.DateCosmetic.Data(row));}
                obj.datas = arrays;
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->TFS_RET_r012_CosmeticDate_API_GetDate-->GetDate::" + ex.Message); 
            }
            finally { conn.Close(); }
            return obj;
        }

        public static DataObjects.DateCosmeticERP GetPOSERP(string id, string company)
        {
            DataObjects.DateCosmeticERP obj = new DataObjects.DateCosmeticERP();
            List<DataObjects.DateCosmeticERP.Data> arrays = new List<DataObjects.DateCosmeticERP.Data>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@document", id)); 
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@company", company));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("TFS_RET_r012_CosmeticDate_API_POSERP_Get", lsInput);
                if(dt.Rows.Count > 0)
                {
                    obj.Company = dt.Rows[0]["Company"].ToString();
                    obj.Location = dt.Rows[0]["Location"].ToString();
                    obj.Date = DateTime.Parse(dt.Rows[0]["Date"].ToString());
                    obj.Document = dt.Rows[0]["Document"].ToString();
                    obj.Type = dt.Rows[0]["Type"].ToString();
                    obj.User = dt.Rows[0]["CreateUser"].ToString();
                    foreach (System.Data.DataRow row in dt.Rows) { arrays.Add(new DataObjects.DateCosmeticERP.Data(row)); }
                    obj.datas = arrays;
                }
                
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->TFS_RET_r012_CosmeticDate_API_POSERP_Get-->POSERP_Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return obj;
        }

        public static List<DataObjects.DateCosmeticERP.Data> GetERP(string id, string type, string company)
        {
            List<DataObjects.DateCosmeticERP.Data> arrays = new List<DataObjects.DateCosmeticERP.Data>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@document", id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@type", type));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@company", company));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("TFS_RET_r012_CosmeticDate_API_ERP_Get", lsInput);
                if (dt.Rows.Count > 0)
                { 
                    foreach (System.Data.DataRow row in dt.Rows) { arrays.Add(new DataObjects.DateCosmeticERP.Data(row)); } 
                }

            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->TFS_RET_r012_CosmeticDate_API_ERP_Get-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return arrays;
        }

        public static int InsertPOSERP(DataObjects.DateCosmeticERP obj) 
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@company", obj.Company));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", obj.Location));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@date", obj.Date));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@document", obj.Document));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@type", obj.Type));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@user", obj.User));

                DataTable dt = new DataTable();
                dt.Columns.Add("ItemNo", typeof(string)); 
                dt.Columns.Add("Variant", typeof(string));
                dt.Columns.Add("Barcode", typeof(string));
                dt.Columns.Add("Quantity", typeof(int));
                dt.Columns.Add("StringDate", typeof(string));
                foreach (var item in obj.datas)
                {
                    DataRow row = dt.NewRow();
                    row["ItemNo"] = item.ItemNo; 
                    row["Variant"] = item.Variant;
                    row["Barcode"] = item.Barcode;
                    row["Quantity"] = item.Quantity;
                    row["StringDate"] = item.StringDate;
                    dt.Rows.Add(row);
                } 
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@MyTable", dt));
                result = conn.ExecuteNonQuery("TFS_RET_r012_CosmeticDate_API_POSERP_Insert", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                Utilities.FileLog.WriteFileLog("DataAccess.SCD-->TFS_RET_r012_CosmeticDate_API-->POSERP_Insert::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static int InsertERP(string id, string location)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@document", id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", location)); 
                result = conn.ExecuteNonQuery("TFS_RET_r012_CosmeticDate_API_ERP_Insert", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                Utilities.FileLog.WriteFileLog("DataAccess.SCD-->TFS_RET_r012_CosmeticDate_API-->Insert::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

    }
}
