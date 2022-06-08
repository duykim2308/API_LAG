using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.HRV
{
    public class Order
    {
        public static int Create(DataObjects.HRV.Order obj)
        {
            int result = -1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter { ParameterName = "@XML", SqlDbType = SqlDbType.Xml, Value = Utilities.XML.GetXMLFromObject(obj) });
                result = conn.ExecuteNonQuery("sp_HRV_Order_CreateXML_Webhook", lsInput);
                conn.Commit();
            }
            catch (Exception ex) { conn.RollBack(); result = -1; Utilities.FileLog.WriteFileLog("DataAccess-->sp_HRV_Order_CreateXML-->Create::" + Utilities.XML.GetXMLFromObject(obj) ); }
            finally { conn.Close(); }
            return result;
        }


        private static int CreateXML(string value, DataProvider.ConnectionAPI conn)
        {
            List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
            lsInput.Add(new System.Data.SqlClient.SqlParameter { ParameterName = "@XML", SqlDbType = System.Data.SqlDbType.Xml, Value = value });
            return conn.ExecuteNonQuery("sp_HRV_Order_CreateXML_Webhook", lsInput);
        }


        public static int CreateXML(List<DataObjects.HRV.OrderXML> lsArray)
        {
            int result = -1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                result = CreateXML(Utilities.XML.GetXMLFromObject(lsArray), conn);
                conn.Commit();
            }
            catch (Exception ex) { conn.RollBack(); result = -1; Utilities.FileLog.WriteFileLog("eCommerce.Core.DAO.eCom-->Order-->Create::" + ex.Message); }
            finally { conn.Close(); }
            return result;
        }
    }
}
