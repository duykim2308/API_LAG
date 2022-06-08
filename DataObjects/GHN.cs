using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class GHN
    {
        public int CODAmount { get; set; }
        public DateTime CODTransferDate { get; set; }
        public string ClientOrderCode { get; set; }
        public int ConvertedWeight { get; set; }
        public string Description { get; set; }
        public Fees Fee { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public string OrderCode { get; set; }
        public string Reason { get; set; }
        public string ReasonCode { get; set; }
        public string ShipperName { get; set; }
        public string ShipperPhone { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
        public int TotalFee { get; set; }
        public string Type { get; set; }
        public string Warehouse { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }

        public class Fees
        {
            public int Coupon { get; set; }
            public int Insurance { get; set; }
            public int MainService { get; set; }
            public int R2S { get; set; }
            public int Return { get; set; }
            public int StationDO { get; set; }
            public int StationPU { get; set; }
        }
    }


    public class GHNXML
    {
        public string Company { get; set; }
        public string OrderCode { get; set; }
        public string Description { get; set; }
        public int CODAmount { get; set; }
        public DateTime? CODTransferDate { get; set; }
        public string Reason { get; set; }
        public string ReasonCode { get; set; }
        public string ShipperName { get; set; }
        public string ShipperPhone { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
        public int TotalFee { get; set; }
        public string Type { get; set; }
        public string Warehouse { get; set; } 
    }
}
