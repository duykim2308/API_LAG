using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_Location
    {
        public static DataObjects.LAG.AX_Location Get()
        {
            DataObjects.LAG.AX_Location location = new DataObjects.LAG.AX_Location();
            List<DataObjects.LAG.Location> lsArray = new List<DataObjects.LAG.Location>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_Location_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.Location(row)); }
                if (lsArray.Count > 0) location.locations = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_Product_Get" + ex.Message); }
            finally { conn.Close(); }
            return location;
        }
    }
}
