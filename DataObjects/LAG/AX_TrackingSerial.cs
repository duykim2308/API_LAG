using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_TrackingSerial
    {
        public string Serial { get; set; }
        public string Status { get; set; }
        public string ProductCode { get; set; }
        public string Size { get; set; }
        public string Config { get; set; } 
        public string Style { get; set; } 
        public string Color { get; set; } 
        public string Note { get; set; }      
        public List<ImEx> imExs { get; set; }
        public List<ERPs> ERPs { get; set; }

        public AX_TrackingSerial()
        {
            Serial = "";
            Status = "";
            ProductCode = "";
            Size = "";
            Config = "";
            Style = "";
            Color = "";
            Note = "";
            new List<ImEx>();
        }

        public AX_TrackingSerial(System.Data.DataRow row)
        {
            Serial = row["Serial"] != null ? row["Serial"].ToString() : "";
            Status = row["Status"] != null ? row["Status"].ToString() : "";
            ProductCode = row["ProductCode"] != null ? row["ProductCode"].ToString() : "";
            Size = row["Size"] != null ? row["Size"].ToString() : "";
            Config = row["Config"] != null ? row["Config"].ToString() : "";
            Style = row["Style"] != null ? row["Style"].ToString() : "";
            Color = row["Color"] != null ? row["Color"].ToString() : "";
            Note = row["Note"] != null ? row["Note"].ToString() : ""; 
        }
    }

    public class ImEx
    {
        public DateTime? Time { get; set; }
        public string Document { get; set; }
        public string Type { get; set; }
        public int Qty { get; set; }
        public string UserName { get; set; }
        public string WareHouse { get; set; } 
        public string WareHouseName { get; set; } 
        public string FromToWarehouse { get; set; } 
        public string FromToWarehouseName { get; set; } 
        public string TransferType { get; set; } 
        public string TransferID { get; set; } 
        public string SourceType { get; set; } 
        public string SourceText { get; set; } 
        public string CustomerCode { get; set; } 
        public string CustomerName { get; set; } 

        public ImEx()
        {
            Time = null;
            Document = "";
            Type = "";
            Qty = 0;
            UserName = "";
            WareHouse = ""; 
            WareHouseName = ""; 
            FromToWarehouse = ""; 
            FromToWarehouseName = ""; 
            TransferType = ""; 
            TransferID = ""; 
            SourceType = ""; 
            SourceText = ""; 
            CustomerCode = ""; 
            CustomerName = ""; 
        }

        public ImEx(System.Data.DataRow row)
        {
            Time = row["Time"] != null ? DateTime.Parse(row["Time"].ToString()) : default(DateTime?);
            Document = row["Document"] != null ? row["Document"].ToString() : "";
            Type = row["Type"] != null ? row["Type"].ToString() : "";
            Qty = row["Qty"] != null ? int.Parse(row["Qty"].ToString()) : 0;
            UserName = row["UserName"] != null ? row["UserName"].ToString() : "";
            WareHouse = row["WareHouse"] != null ? row["WareHouse"].ToString() : "";
            WareHouseName = row["WareHouseName"] != null ? row["WareHouseName"].ToString() : "";
            FromToWarehouse = row["FromToWarehouse"] != null ? row["FromToWarehouse"].ToString() : "";
            FromToWarehouseName = row["FromToWarehouseName"] != null ? row["FromToWarehouseName"].ToString() : "";
            TransferType = row["TransferType"] != null ? row["TransferType"].ToString() : "";
            TransferID = row["TransferID"] != null ? row["TransferID"].ToString() : "";
            SourceType = row["SourceType"] != null ? row["SourceType"].ToString() : "";
            SourceText = row["SourceText"] != null ? row["SourceText"].ToString() : "";
            CustomerCode = row["CustomerCode"] != null ? row["CustomerCode"].ToString() : "";
            CustomerName = row["CustomerName"] != null ? row["CustomerName"].ToString() : ""; 
        }

    }

    public class ERPs
    {
        public string Type { get; set; }
        public string Document { get; set; }
        public string Status { get; set; } 
        public string UserName { get; set; }
        public DateTime? DateTime { get; set; }

        public ERPs()
        {
            Type = "";
            Document = "";
            Status = "";
            UserName = "";
            DateTime = null; 
        }

        public ERPs(System.Data.DataRow row)
        { 
            Type = row["Type"] != null ? row["Type"].ToString() : "";
            Document = row["Document"] != null ? row["Document"].ToString() : "";
            Status = row["Status"] != null ? row["Status"].ToString() : "";
            UserName = row["UserName"] != null ? row["UserName"].ToString() : "";
            DateTime = row["DateTime"] != null ? System.DateTime.Parse(row["DateTime"].ToString()) : default(DateTime?);
        }
    }



}