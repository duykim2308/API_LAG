using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess
{
    class Log
    {
        public static List<DataObjects.Log> Get()
        {
            List<DataObjects.Log> lsArray = new List<DataObjects.Log>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_Log_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.Log(row)); }
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->Log-->Get::" + ex.Message); }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int Create(string type, string function, string error)
        {
            int result = 1;
            List<DataObjects.Log> lsArray = new List<DataObjects.Log>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Type", type));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Function", function));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Error", error));
                result = conn.ExecuteNonQuery("sp_Log_Insert", lsInput);
            }
            catch (Exception ex) { result = 0; FileLog.WriteFileLog("DataAccess-->Log-->Insert::" + ex.Message); }
            finally { conn.Close(); }
            return result;
        }
    }
}
