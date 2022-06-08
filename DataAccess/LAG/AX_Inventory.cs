using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_Inventory
    {
        public static List<DataObjects.LAG.AX_Inventory> Get(string location, string item)
        {
            List<DataObjects.LAG.AX_Inventory> lsArray = new List<DataObjects.LAG.AX_Inventory>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", location));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@item", item));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_InventoryByLocation", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.AX_Inventory(row)); }
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_InventoryByLocation" + ex.Message); }
            finally { conn.Close(); }
            return lsArray;
        }
    }
}
