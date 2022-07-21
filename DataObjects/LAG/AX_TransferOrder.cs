using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_TransferOrder
    {
        public List<TransferOrder> transferorders { get; set; }
    }

    public class AX_TransferOrderObject
    {
        public TransferOrder transferorder { get; set; }
        public List<TransferLine> transferlines { get; set; }
    }

    public class TransferOrder
    {
        public string TransferID { get; set; }
        public string InventLocationFrom { get; set; }
        public string InventLocationTo { get; set; }
        public string InventLocationTransit { get; set; }
        public string TransferStatus { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public DateTime? CreateDatetime { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryCustomer { get; set; }
        public string CustomerName { get; set; }
        public string SalesID { get; set; }
        public string Notes { get; set; }
        public string PhoneNum { get; set; }
        public string PSNum { get; set; }
        public string Symbol { get; set; }
        public string Lag_TFNotes { get; set; }

        public TransferOrder()
        {
            TransferID = "";
            InventLocationFrom = "";
            InventLocationTo = "";
            InventLocationTransit = "";
            TransferStatus = "";
            ShipDate = null;
            ReceiveDate = null;
            CreateDatetime = null;
            DeliveryAddress = "";
            DeliveryCustomer = "";
            CustomerName = "";
            SalesID = "";
            Notes = "";
            PhoneNum = "";
            PSNum = "";
            Symbol = "";
            Lag_TFNotes = "";
        }

        public TransferOrder(System.Data.DataRow row)
        { 
            TransferID = row["TransferID"] != null ? row["TransferID"].ToString() : "";
            InventLocationFrom = row["InventLocationFrom"] != null ? row["InventLocationFrom"].ToString() : "";
            InventLocationTo = row["InventLocationTo"] != null ? row["InventLocationTo"].ToString() : "";
            InventLocationTransit = row["InventLocationTransit"] != null ? row["InventLocationTransit"].ToString() : "";
            TransferStatus = row["TransferStatus"] != null ? row["TransferStatus"].ToString() : "";
            ShipDate = row["ShipDate"] != null ? DateTime.Parse(row["ShipDate"].ToString()) : default(DateTime?);
            ReceiveDate = row["ReceiveDate"] != null ? DateTime.Parse(row["ReceiveDate"].ToString()) : default(DateTime?);
            CreateDatetime = row["CreateDatetime"] != null ? DateTime.Parse(row["CreateDatetime"].ToString()) : default(DateTime?);
            DeliveryAddress = row["DeliveryAddress"] != null ? row["DeliveryAddress"].ToString() : "";
            DeliveryCustomer = row["DeliveryCustomer"] != null ? row["DeliveryCustomer"].ToString() : "";
            CustomerName = row["CustomerName"] != null ? row["CustomerName"].ToString() : "";
            SalesID = row["SalesID"] != null ? row["SalesID"].ToString() : "";
            Notes = row["Notes"] != null ? row["Notes"].ToString() : "";
            PhoneNum = row["PhoneNum"] != null ? row["PhoneNum"].ToString() : "";
            PSNum = row["PSNum"] != null ? row["PSNum"].ToString() : "";
            Symbol = row["Symbol"] != null ? row["Symbol"].ToString() : "";
            Lag_TFNotes = row["Lag_TFNotes"] != null ? row["Lag_TFNotes"].ToString() : "";
        }
    }

    public class TransferLine
    {
        public string TransferID { get; set; }
        public int LineNum { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Barcode { get; set; }
        public string InventDIMID { get; set; }
        public string UnitID { get; set; }
        public float QtyTransfer { get; set; }
        public float QtyShipped { get; set; }
        public float QtyReceived { get; set; }
        public DateTime? CreateDatetime { get; set; }

        public TransferLine()
        {
            TransferID = "";
            LineNum = 0;
            ItemID = "";
            ItemName = "";
            Barcode = "";
            InventDIMID = "";
            UnitID = "";
            QtyTransfer = 0;
            QtyShipped = 0;
            QtyReceived = 0;
            CreateDatetime = null;
        }

        public TransferLine(System.Data.DataRow row)
        { 
            TransferID = row["TransferID"] != null ? row["TransferID"].ToString() : "";
            LineNum = row["LineNum"] != null ? int.Parse(row["LineNum"].ToString()) : 0;
            ItemID = row["ItemID"] != null ? row["ItemID"].ToString() : "";
            ItemName = row["ItemName"] != null ? row["ItemName"].ToString() : "";
            Barcode = row["Barcode"] != null ? row["Barcode"].ToString() : "";
            InventDIMID = row["InventDIMID"] != null ? row["InventDIMID"].ToString() : "";
            UnitID = row["UnitID"] != null ? row["UnitID"].ToString() : "";
            QtyTransfer = row["QtyTransfer"] != null ? float.Parse(row["QtyTransfer"].ToString()) : 0;
            QtyShipped = row["QtyShipped"] != null ? float.Parse(row["QtyShipped"].ToString()) : 0;
            QtyReceived = row["QtyReceived"] != null ? float.Parse(row["QtyReceived"].ToString()) : 0;
            CreateDatetime = row["CreateDatetime"] != null ? DateTime.Parse(row["CreateDatetime"].ToString()) : default(DateTime?);  
        }

    }


} 