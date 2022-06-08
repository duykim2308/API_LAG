using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_Product
    {
        public static List<DataObjects.LAG.AX_Product> Get()
        {
            List<DataObjects.LAG.AX_Product> lsArray = new List<DataObjects.LAG.AX_Product>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_Product_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.AX_Product(row)); }
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_Product_Get" + ex.Message); }
            finally { conn.Close(); }
            return lsArray;
        }
    }
}
