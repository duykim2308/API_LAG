using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess.LAG
{
    public class AX_Product
    {
        public static DataObjects.LAG.AX_Product Get(string Search)
        {
            DataObjects.LAG.AX_Product product = new DataObjects.LAG.AX_Product();
            List<DataObjects.LAG.Product> lsArrayProducts = new List<DataObjects.LAG.Product>();
            List<DataObjects.LAG.Variant> lsArrayvariants = new List<DataObjects.LAG.Variant>();
            List<DataObjects.LAG.PriceGroups> lsArraypricegroups = new List<DataObjects.LAG.PriceGroups>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@search", Search));
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_AX_Product_Get", lsInput);
                System.Data.DataTable dtproduct = new System.Data.DataTable();
                System.Data.DataTable dtvariant = new System.Data.DataTable();
                System.Data.DataTable dtpricegroup = new System.Data.DataTable();

                if (ds.Tables.Count > 1)
                {
                    dtproduct = ds.Tables[0];
                    dtvariant = ds.Tables[1];
                    dtpricegroup = ds.Tables[2];

                    foreach (System.Data.DataRow row_product in dtproduct.Rows)
                    {
                        foreach (System.Data.DataRow row_variant in dtvariant.Rows)
                        {
                            var pricegroup_ = dtpricegroup.Select("InventDimID='" + row_variant["InventDimID"] + "'").AsEnumerable();// + row_variant["InventDimID"]); 
                            foreach (System.Data.DataRow row_pricegroup in pricegroup_)
                            {
                                lsArraypricegroups.Add(new DataObjects.LAG.PriceGroups(row_pricegroup));
                            }
                            DataObjects.LAG.Variant variant_ = new DataObjects.LAG.Variant();
                            variant_.Name = row_variant["Name"] != null ? row_variant["Name"].ToString() : "";
                            variant_.RetailVariantID = row_variant["RetailVariantID"] != null ? row_variant["RetailVariantID"].ToString() : "";
                            variant_.InventDimID = row_variant["InventDimID"] != null ? row_variant["InventDimID"].ToString() : "";
                            variant_.Size = row_variant["Size"] != null ? row_variant["Size"].ToString() : "";
                            variant_.Style = row_variant["Style"] != null ? row_variant["Style"].ToString() : "";
                            variant_.Config = row_variant["Config"] != null ? row_variant["Config"].ToString() : "";
                            variant_.Color = row_variant["Color"] != null ? row_variant["Color"].ToString() : "";
                            variant_.PriceGroups = lsArraypricegroups.Where(m => m.InventDimID == row_variant["InventDimID"].ToString()).ToList();
                            lsArrayvariants.Add(variant_);
                        }
                        DataObjects.LAG.Product product_ = new DataObjects.LAG.Product();
                        product_.Item = row_product["Item"] != null ? row_product["Item"].ToString() : "";
                        product_.Name = row_product["Name"] != null ? row_product["Name"].ToString() : "";
                        product_.BusinessLine = row_product["BusinessLine"] != null ? row_product["BusinessLine"].ToString() : "";
                        product_.SubCat = row_product["SubCat"] != null ? row_product["SubCat"].ToString() : "";
                        product_.ProductCat = row_product["ProductCat"] != null ? row_product["ProductCat"].ToString() : "";
                        product_.CreateDate = row_product["CreateDate"] != null ? DateTime.Parse(row_product["CreateDate"].ToString()) : DateTime.Now;
                        product_.Variants = lsArrayvariants;
                        lsArrayProducts.Add(product_);
                    }
                    if (lsArrayProducts.Count > 0) product.products = lsArrayProducts;
                }

                else if (ds.Tables.Count == 1)
                {
                    dtproduct = ds.Tables[0];
                    foreach (System.Data.DataRow row_product in dtproduct.Rows)
                    {
                        DataObjects.LAG.Product product_ = new DataObjects.LAG.Product();
                        product_.Item = row_product["Item"] != null ? row_product["Item"].ToString() : "";
                        product_.Name = row_product["Name"] != null ? row_product["Name"].ToString() : "";
                        product_.BusinessLine = row_product["BusinessLine"] != null ? row_product["BusinessLine"].ToString() : "";
                        product_.SubCat = row_product["SubCat"] != null ? row_product["SubCat"].ToString() : "";
                        product_.ProductCat = row_product["ProductCat"] != null ? row_product["ProductCat"].ToString() : "";
                        product_.CreateDate = row_product["CreateDate"] != null ? DateTime.Parse(row_product["CreateDate"].ToString()) : DateTime.Now;
                        product_.Variants = lsArrayvariants;
                        lsArrayProducts.Add(product_);
                    }

                    if (lsArrayProducts.Count > 0) product.products = lsArrayProducts;
                }
                 
                else product = null;
            }
            catch (Exception ex) { FileLog.WriteFileLog("DataAccess-->sp_AX_Product_Get" + ex.Message); }
            finally { conn.Close(); }
            return product;
        }
    }
}
