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
        public static DataObjects.LAG.AX_Inventory Get(string location, string item)
        {
            DataObjects.LAG.AX_Inventory inventory = new DataObjects.LAG.AX_Inventory();
            List<DataObjects.LAG.Inventory> lsArray = new List<DataObjects.LAG.Inventory>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@location", location));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@item", item));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_InventoryByLocation", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.Inventory(row)); }
                if (lsArray.Count > 0) inventory.inventories = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_InventoryByLocation" + ex.Message); }
            finally { conn.Close(); }
            return inventory;
        }
    }
}
