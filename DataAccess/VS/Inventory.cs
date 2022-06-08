using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.VS
{
    public class Inventory
    {
        public static DataObjects.VS.Inventory Get()
        {
            List<DataObjects.VS.Inventory.Inventorys> lsArray = new List<DataObjects.VS.Inventory.Inventorys>();
            DataObjects.VS.Inventory inventory = new DataObjects.VS.Inventory();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_VS_API_Inventory", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.VS.Inventory.Inventorys(row)); }
                inventory.inventorys = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->VS.Inventory-->Get::" + ex.Message); }
            finally { conn.Close(); }
            return inventory;
        }

    }
}
