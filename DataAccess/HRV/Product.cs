using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.HRV
{
    public class Product
    {
        public static int Create(List<DataObjects.HRV.Product> lsArray)
        {
            int result = -1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                result = Create(Utilities.XML.GetXMLFromObject(lsArray), conn);
                conn.Commit();
            }
            catch (Exception ex) { conn.RollBack(); result = -1; Utilities.FileLog.WriteFileLog("HRV.eCom-->Product-->Create::" + ex.Message); }
            finally { conn.Close(); }
            return result;
        }

        private static int Create(string value, DataProvider.ConnectionAPI conn)
        {
            List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
            lsInput.Add(new System.Data.SqlClient.SqlParameter { ParameterName = "@XML", SqlDbType = System.Data.SqlDbType.Xml, Value = value });
            return conn.ExecuteNonQuery("sp_HRV_Product_CreateXML_Webhook", lsInput);
        }

    }
}
