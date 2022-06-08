using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.VS
{
    public class Product
    {
        public static DataObjects.VS.Product Get()
        {
            List<DataObjects.VS.Product.Products> lsArray = new List<DataObjects.VS.Product.Products>();
            DataObjects.VS.Product product = new DataObjects.VS.Product();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_VS_API_Product", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.VS.Product.Products(row)); }
                product.products = lsArray;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->VS.Product-->Get::" + ex.Message); }
            finally { conn.Close(); }
            return product;
        }

    }
}
