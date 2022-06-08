using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DataAccess
{
    public class PDA
    {

        public static List<DataObjects.PDA.PDA_TO> GetTO(string id, string stockid)
        {
            List<DataObjects.PDA.PDA_TO> lsArray = new List<DataObjects.PDA.PDA_TO>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@toid", id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", stockid));
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_scd_pda_TO_Get", lsInput);
                foreach (System.Data.DataRow row in ds.Tables[0].Rows)
                {
                    lsArray.Add(new DataObjects.PDA.PDA_TO(row));
                    System.Data.DataRow[] datas = ds.Tables[1].Select("TO_ID = '" + row["TO_ID"] + "' and ( StockIn = '" + row["StockIn"] + "' or StockOut = '" + row["StockOut"] + "' )");
                    foreach (System.Data.DataRow rowline in datas)
                    {
                        lsArray[lsArray.Count - 1].TO_Detail.Add(new DataObjects.PDA.PDA_TO.PDA_TO_Detail(rowline));
                    }
                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_TO-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_TOHeader> GetTOHeader(string id)
        {
            List<DataObjects.PDA.PDA_TOHeader> lsArray = new List<DataObjects.PDA.PDA_TOHeader>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                //lsInput.Add(new System.Data.SqlClient.SqlParameter("@fd", fd != DateTime.Parse("0001-01-01") ? fd : DateTime.Parse("1753-01-01")));
                //lsInput.Add(new System.Data.SqlClient.SqlParameter("@td", td != DateTime.Parse("0001-01-01") ? td : DateTime.Parse("1753-01-01")));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@toid", id));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_TO_Header_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_TOHeader(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->scd_pda_TOHeader-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_SO> GetSO(string soid, string stockid)
        {
            List<DataObjects.PDA.PDA_SO> lsArray = new List<DataObjects.PDA.PDA_SO>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@soid", soid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", stockid));
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_scd_pda_SO_Get", lsInput);
                foreach (System.Data.DataRow row in ds.Tables[0].Rows)
                {
                    lsArray.Add(new DataObjects.PDA.PDA_SO(row));
                    System.Data.DataRow[] datas = ds.Tables[1].Select("SO_ID = '" + row["SO_ID"] + "' and StockID = '" + row["StockID"] + "'");
                    foreach (System.Data.DataRow rowline in datas)
                    {
                        lsArray[lsArray.Count - 1].SO_Detail.Add(new DataObjects.PDA.PDA_SO.PDA_SO_Detail(rowline));
                    }
                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_SO-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_SOHeader> GetSOHeader(DateTime fd, DateTime td, string stockID)
        {
            List<DataObjects.PDA.PDA_SOHeader> lsArray = new List<DataObjects.PDA.PDA_SOHeader>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@fd", fd != DateTime.Parse("0001-01-01") ? fd : DateTime.Parse("1753-01-01")));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@td", td != DateTime.Parse("0001-01-01") ? td : DateTime.Parse("1753-01-01")));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", stockID));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_SO_Header_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_SOHeader(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->scd_pda_SOHeader-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_PO> GetPO(string poid, string stockid)
        {
            List<DataObjects.PDA.PDA_PO> lsArray = new List<DataObjects.PDA.PDA_PO>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@poid", poid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", stockid));
                System.Data.DataSet ds = conn.ExecuteNonQueryDataSet("sp_scd_pda_PO_Get", lsInput);
                foreach (System.Data.DataRow row in ds.Tables[0].Rows)
                {
                    lsArray.Add(new DataObjects.PDA.PDA_PO(row));
                    System.Data.DataRow[] datas = ds.Tables[1].Select("PO_ID = '" + row["PO_ID"] + "' and StockID = '" + row["StockID"] + "'");
                    foreach (System.Data.DataRow rowline in datas)
                    {
                        lsArray[lsArray.Count - 1].PO_Detail.Add(new DataObjects.PDA.PDA_PO.PDA_PO_Detail(rowline));
                    }
                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_PO-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_POHeader> GetPOHeader(DateTime fd, DateTime td, string stockID)
        {
            List<DataObjects.PDA.PDA_POHeader> lsArray = new List<DataObjects.PDA.PDA_POHeader>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@fd", fd != DateTime.Parse("0001-01-01") ? fd : DateTime.Parse("1753-01-01")));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@td", td != DateTime.Parse("0001-01-01") ? td : DateTime.Parse("1753-01-01")));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", stockID));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_PO_Header_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_POHeader(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->scd_pda_ITEM-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int CreateNK(DataObjects.PDA.PDA_NK obj)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@nkid", obj.NK_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@poid", obj.PO_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@nktype", obj.NK_Type));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@nkname", obj.NK_Name));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@nkdate", obj.NK_Date));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", obj.UserID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@pdaid", obj.PDAID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", obj.StockID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@providerid", obj.ProviderID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@providername", obj.ProviderName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", obj.Barcode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@totalquantity", obj.TotalQuantity));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@status", obj.Status));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@description", obj.Description));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", obj.CreateByUser));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@createdate", obj.CreateDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@modifybyuser", obj.ModifyByUser));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@modifydate", obj.ModifyDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@active", obj.Active));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_NK_Header_Create", lsInput);

                foreach (DataObjects.PDA.PDA_NK.PDA_NKDetail objs in obj.NKDetail)
                {
                    List<System.Data.SqlClient.SqlParameter> lsInputs = new List<System.Data.SqlClient.SqlParameter>();
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@nkid", objs.NK_ID));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@nkline", objs.NK_Line));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@productid", objs.ProductID));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@variant", objs.Variant));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@producttype", objs.ProductType));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@productname", objs.ProductName));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@barcode", objs.Barcode));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@quantity", objs.Quantity));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@unit", objs.Unit));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@description", objs.Description));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@image", objs.Image));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", objs.CreateByUser));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@createdate", objs.CreateDate));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@modifybyuser", objs.ModifyByUser));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@modifydate", objs.ModifyDate));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@active", objs.Active));
                    System.Data.DataTable dts = conn.ExecuteNonQueryDataTable("sp_scd_pda_NK_Detail_Create", lsInputs);
                }
            }
            catch (Exception ex)
            {
                conn.RollBack(); result = 0;
                FileLog.WriteFileLog("DataAccess-->scd_pda_NK-->Create::" + ex.Message); 
            }
            finally { conn.Close(); }
            return result;
        }

        public static int CreateXK(DataObjects.PDA.PDA_XK obj)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@xkid", obj.XK_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@soid", obj.SO_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@xktype", obj.XK_Type));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@xkname", obj.XK_Name));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@xkdate", obj.XK_Date));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", obj.UserID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@pdaid", obj.PDAID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", obj.StockID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@customerid", obj.CustomerID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@customername", obj.CustomerName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", obj.Barcode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@totalquantity", obj.TotalQuantity));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@status", obj.Status));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@description", obj.Description));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", obj.CreateByUser));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@createdate", obj.CreateDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@modifybyuser", obj.ModifyByUser));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@modifydate", obj.ModifyDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@active", obj.Active));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_XK_Header_Create", lsInput);

                foreach (DataObjects.PDA.PDA_XK.PDA_XKDetail objs in obj.XKDetail)
                {
                    List<System.Data.SqlClient.SqlParameter> lsInputs = new List<System.Data.SqlClient.SqlParameter>();
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@xkid", objs.XK_ID));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@xkline", objs.XK_Line));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@productid", objs.ProductID));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@variant", objs.Variant));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@producttype", objs.ProductType));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@productname", objs.ProductName));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@barcode", objs.Barcode));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@quantity", objs.Quantity));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@unit", objs.Unit));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@description", objs.Description));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@image", objs.Image));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", objs.CreateByUser));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@createdate", objs.CreateDate));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@modifybyuser", objs.ModifyByUser));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@modifydate", objs.ModifyDate));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@active", objs.Active));
                    System.Data.DataTable dts = conn.ExecuteNonQueryDataTable("sp_scd_pda_XK_Detail_Create", lsInputs);
                }
            }
            catch (Exception ex)
            {
                conn.RollBack(); result = 0;
                FileLog.WriteFileLog("DataAccess-->scd_pda_XK-->Create::" + ex.Message); 
            }
            finally { conn.Close(); }
            return result;
        }

        public static int CreateCK(DataObjects.PDA.PDA_CK obj)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ckid", obj.CK_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@toid", obj.TO_ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cktype", obj.CK_Type));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ckname", obj.CK_Name));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ckdate", obj.CK_Date));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", obj.UserID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@pdaid", obj.PDAID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockin", obj.StockIn));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockout", obj.StockOut));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", obj.Barcode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@totalquantity", obj.TotalQuantity));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@status", obj.Status));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@description", obj.Description));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", obj.CreateByUser));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@createdate", obj.CreateDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@modifybyuser", obj.ModifyByUser));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@modifydate", obj.ModifyDate));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@active", obj.Active));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_CK_Header_Create", lsInput);

                foreach (DataObjects.PDA.PDA_CK.PDA_CKDetail objs in obj.CKDetail)
                {
                    List<System.Data.SqlClient.SqlParameter> lsInputs = new List<System.Data.SqlClient.SqlParameter>();
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@ckid", objs.CK_ID));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@ckline", objs.CK_Line));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@productid", objs.ProductID));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@variant", objs.Variant));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@producttype", objs.ProductType));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@productname", objs.ProductName));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@barcode", objs.Barcode));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@quantity", objs.Quantity));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@unit", objs.Unit));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@description", objs.Description));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@image", objs.Image));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", objs.CreateByUser));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@createdate", objs.CreateDate));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@modifybyuser", objs.ModifyByUser));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@modifydate", objs.ModifyDate));
                    lsInputs.Add(new System.Data.SqlClient.SqlParameter("@active", objs.Active));
                    System.Data.DataTable dts = conn.ExecuteNonQueryDataTable("sp_scd_pda_CK_Detail_Create", lsInputs);
                }
            }
            catch (Exception ex)
            {
                conn.RollBack(); result = 0;
                FileLog.WriteFileLog("DataAccess-->scd_pda_CK-->Create::" + ex.Message); 
            }
            finally { conn.Close(); }
            return result;
        }

        public static int CreateKK(List<DataObjects.PDA.PDA_KK> obj)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();

                for (int i = 0; i < obj.ToArray().Length; i++)
                {
                    List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@kkid", obj[i].KK_ID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@kkdate", obj[i].KK_Date));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@pdaid", obj[i].PDAID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", obj[i].UserID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", obj[i].StockID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@binid", obj[i].BinID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@productid", obj[i].ProductID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@variant", obj[i].Variant));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", obj[i].Barcode));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@unit", obj[i].Unit));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@quantity", obj[i].Quantity));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@description", obj[i].Description));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@image", obj[i].Image));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@createbyuser", obj[i].CreateByUser));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@createdate", obj[i].CreateDate));
                    System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_KK_Create", lsInput);
                }
            }
            catch (Exception ex)
            {
                conn.RollBack(); result = 0;
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_KK-->Create::" + ex.Message); 
            }
            finally { conn.Close(); }
            return result;
        }

        public static int CreateError(List<DataObjects.PDA.PDA_Error> obj)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();

                for (int i = 0; i < obj.ToArray().Length; i++)
                {
                    List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@iderror", obj[i].IDError));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@nameerror", obj[i].NameError));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@description", obj[i].Description));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", obj[i].UserID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@pdaid", obj[i].PDAID));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@createbydate", obj[i].CreateDate));
                    lsInput.Add(new System.Data.SqlClient.SqlParameter("@active", obj[i].Active));
                    System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Error_Create", lsInput);
                }
            }
            catch (Exception ex)
            {
                conn.RollBack(); result = 0;
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_Error-->Create::" + ex.Message); 
            }
            finally { conn.Close(); }
            return result;
        }

        public static List<DataObjects.PDA.PDA_Item> GetItem(string itemno)
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@itemno", itemno));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Item_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Item(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->scd_pda_ITEM-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_Item> DeleteItem()
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Item_Delete", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Item(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->scd_pda_ITEM-->Delete::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_Item> GetItemFilter(int id)
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", id));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Item_GetFilter", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Item(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_Item_GetFilter-->GetFilter::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_ItemBarcode> GetItemBarcode(string barcode)
        {
            List<DataObjects.PDA.PDA_ItemBarcode> lsArray = new List<DataObjects.PDA.PDA_ItemBarcode>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", barcode));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_ItemBarcode_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_ItemBarcode(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_ItemBarcode-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<int> DeleteItemBarcode()
        {
            List<int> lsArray = new List<int>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_ItemBarcode_Delete", lsInput);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lsArray.Add(int.Parse(dt.Rows[i][0].ToString()));
                }
                //foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_ItemBarcode(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_ItemBarcode-->Delete::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_ItemBarcode> GetItemBarcodeFilter(int id)
        {
            List<DataObjects.PDA.PDA_ItemBarcode> lsArray = new List<DataObjects.PDA.PDA_ItemBarcode>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", id));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_ItemBarcode_GetFilter", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_ItemBarcode(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_ItemBarcode_GetFilter-->GetFilter::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_Barcode> GetBarcode(string barcode)
        {
            List<DataObjects.PDA.PDA_Barcode> lsArray = new List<DataObjects.PDA.PDA_Barcode>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", barcode));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Barcode_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Barcode(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_Barcode-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_Barcode> GetBarcodeFilter(int id)
        {
            List<DataObjects.PDA.PDA_Barcode> lsArray = new List<DataObjects.PDA.PDA_Barcode>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", id));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Barcode_GetFilter", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Barcode(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_Barcode_GetFilter-->GetFilter::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static int CreateItemBarcode(DataObjects.PDA.PDA_ItemBarcode item)
        {
            int result = 1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@barcode", (object)item.Barcode ?? DBNull.Value));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@productid", (object)item.ProductID ?? DBNull.Value));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@variant", (object)item.Variant ?? DBNull.Value));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", (object)item.UserID ?? DBNull.Value));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@pdaid", (object)item.PDAID ?? DBNull.Value));
                conn.ExecuteNonQuery("sp_scd_pda_ItemBarcode_Create", lsInput);
                conn.Commit();
            }
            catch (Exception ex)
            {
                conn.RollBack(); result = 0; FileLog.WriteFileLog("DataAccess-->PDA_ItemBarcode-->Create::" + ex.Message); 
            }
            finally { conn.Close(); }
            return result;
        }

        public static List<DataObjects.PDA.PDA_Location> GetLocation(string id)
        {
            List<DataObjects.PDA.PDA_Location> lsArray = new List<DataObjects.PDA.PDA_Location>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@id", id));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Location_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Location(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->scd_pda_Location-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_User> GetUser(string userid)
        {
            List<DataObjects.PDA.PDA_User> lsArray = new List<DataObjects.PDA.PDA_User>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@userid", userid));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_User_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_User(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_User-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_Count> GetCount()
        {
            List<DataObjects.PDA.PDA_Count> lsArray = new List<DataObjects.PDA.PDA_Count>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Count", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Count(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_Count-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }

        public static List<DataObjects.PDA.PDA_Inventory> GetInventory(DateTime Date, string stockID)
        {
            List<DataObjects.PDA.PDA_Inventory> lsArray = new List<DataObjects.PDA.PDA_Inventory>();
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@d", Date != DateTime.Parse("0001-01-01") ? Date : DateTime.Parse("1753-01-01")));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@stockid", stockID));
                System.Data.DataTable dt = conn.ExecuteNonQueryDataTable("sp_scd_pda_Inventory_Get", lsInput);
                foreach (System.Data.DataRow row in dt.Rows) { lsArray.Add(new DataObjects.PDA.PDA_Inventory(row)); }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("DataAccess-->sp_scd_pda_Inventory-->Get::" + ex.Message); 
            }
            finally { conn.Close(); }
            return lsArray;
        }


    }
}
