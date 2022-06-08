using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess
{
    public class Order
    {
        public static DataSet Order_History(string ID)
        {
            DataProvider.ConnectionAPI conn = null;
            System.Data.DataSet ds = new DataSet();
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", ID));

                ds = conn.ExecuteNonQueryDataSet("sp_VS_Order_History", lsInput);
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DMS.DataAccess-->sp_VS_Order_History-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return ds;
        }
    }
}
