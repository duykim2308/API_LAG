using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_Customer
    {
        public static DataObjects.LAG.AX_Customers Get(string search)
        {
            DataObjects.LAG.AX_Customers aX_Customers = new DataObjects.LAG.AX_Customers();
            List<DataObjects.LAG.Customer> lsArray = new List<DataObjects.LAG.Customer>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@search", search)); 
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_AX_Customer_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.LAG.Customer(row)); }
                if (lsArray.Count > 0) aX_Customers.Customers = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_Customer_Get" + ex.Message); }
            finally { conn.Close(); }
            return aX_Customers;
        }
    }
}
