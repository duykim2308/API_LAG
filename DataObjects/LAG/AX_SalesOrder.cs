using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_SalesOrder
    {
        public List<SalesOrder> salesorders { get; set; }
    }

    public class AX_SalesOrderObject
    {
        public SalesOrder salesorder { get; set; }
        public List<SalesLine> saleslines { get; set; }
    }

    public class SalesOrder
    {
        public string SalesID { get; set; }
        public string SalesType { get; set; }
        public string SalesName { get; set; }
        public string CustAccount { get; set; }
        public string CustInvoiceID { get; set; }
        public string CustGroup { get; set; }
        public string PriceGroupID { get; set; }
        public string CustomerRef { get; set; }
        public string DeliveryDate { get; set; }
        public string PostingProfile { get; set; }
        public string InventLocationID { get; set; }
        public string SalesUnitID { get; set; }
        public string CreateBy { get; set; }
        public string LAGReceiveAddress { get; set; }

        public SalesOrder()
        {
            SalesID = "";
            SalesType = "";
            SalesName = "";
            CustAccount = "";
            CustInvoiceID = "";
            CustGroup = "";
            PriceGroupID = "";
            CustomerRef = "";
            DeliveryDate = "";
            PostingProfile = "";
            InventLocationID = "";
            SalesUnitID = "";
            CreateBy = "";
            LAGReceiveAddress = "";
        }

        public SalesOrder(System.Data.DataRow row)
        {
            SalesID = row["SalesID"] != null ? row["SalesID"].ToString() : "";
            SalesType = row["SalesType"] != null ? row["SalesType"].ToString() : "";
            SalesName = row["SalesName"] != null ? row["SalesName"].ToString() : "";
            CustAccount = row["CustAccount"] != null ? row["CustAccount"].ToString() : "";
            CustInvoiceID = row["CustInvoiceID"] != null ? row["CustInvoiceID"].ToString() : "";
            CustGroup = row["CustGroup"] != null ? row["CustGroup"].ToString() : "";
            PriceGroupID = row["PriceGroupID"] != null ? row["PriceGroupID"].ToString() : "";
            CustomerRef = row["CustomerRef"] != null ? row["CustomerRef"].ToString() : "";
            DeliveryDate = row["DeliveryDate"] != null ? row["DeliveryDate"].ToString() : "";
            PostingProfile = row["PostingProfile"] != null ? row["PostingProfile"].ToString() : "";
            InventLocationID = row["InventLocationID"] != null ? row["InventLocationID"].ToString() : "";
            SalesUnitID = row["SalesUnitID"] != null ? row["SalesUnitID"].ToString() : "";
            CreateBy = row["CreateBy"] != null ? row["CreateBy"].ToString() : "";
            LAGReceiveAddress = row["LAGReceiveAddress"] != null ? row["LAGReceiveAddress"].ToString() : "";
        }
    }

    public class SalesLine
    {
        public string SalesID { get; set; }
        public int LineNo { get; set; }
        public string ItemID { get; set; } 
        public string Name { get; set; }
        public float Qty { get; set; }
        public string TaxGroup { get; set; }
        public float SalesPrice { get; set; }
        public float DiscountAmt { get; set; }
        public float LineAmt { get; set; }
        public string SalesUnit { get; set; }
        public string Note { get; set; } 

        public SalesLine()
        {
            SalesID = "";
            LineNo = 0;
            ItemID = "";
            Name = "";
            Qty = 0;
            TaxGroup = "";
            SalesPrice = 0;
            DiscountAmt = 0;
            LineAmt = 0;
            SalesUnit = ""; 
            Note = "";
        }

        public SalesLine(System.Data.DataRow row)
        {
            SalesID = row["SalesID"] != null ? row["SalesID"].ToString() : "";
            LineNo = row["LineNo"] != null ? int.Parse(row["LineNo"].ToString()) : 0;
            ItemID = row["ItemID"] != null ? row["ItemID"].ToString() : "";
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            Qty = row["Qty"] != null ? float.Parse(row["Qty"].ToString()) : 0;
            TaxGroup = row["TaxGroup"] != null ? row["TaxGroup"].ToString() : "";
            SalesPrice = row["SalesPrice"] != null ? float.Parse(row["SalesPrice"].ToString()) : 0;
            DiscountAmt = row["DiscountAmt"] != null ? float.Parse(row["DiscountAmt"].ToString()) : 0;
            LineAmt = row["LineAmt"] != null ? float.Parse(row["LineAmt"].ToString()) : 0;
            SalesUnit = row["SalesUnit"] != null ? row["SalesUnit"].ToString() : ""; 
            Note = row["Note"] != null ? row["Note"].ToString() : "";
        }

    }


} 