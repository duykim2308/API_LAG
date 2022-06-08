using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_Product
    {
        public string Item { get; set; }
        public string Name { get; set; }
        public string BusinessLine { get; set; } 
        public string SubCat { get; set; } 
        public string ProductCat { get; set; } 
        public string RetailVariantID { get; set; } 
        public string InventDimID { get; set; } 
        public string Size { get; set; } 
        public string Style { get; set; } 
        public string Config { get; set; } 
        public string Color { get; set; } 


        public AX_Product()
        {
            Item = "";
            Name = "";
            BusinessLine = "";
            SubCat = "";
            ProductCat = "";
            RetailVariantID = "";
            InventDimID = "";
            Size = "";
            Style = "";
            Config = "";
            Color = "";
        }

        public AX_Product(System.Data.DataRow row)
        {
            Item = row["Item"] != null ? row["Item"].ToString() : "";
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            BusinessLine = row["BusinessLine"] != null ? row["BusinessLine"].ToString() : "";
            SubCat = row["SubCat"] != null ? row["SubCat"].ToString() : "";
            RetailVariantID = row["RetailVariantID"] != null ? row["RetailVariantID"].ToString() : "";
            InventDimID = row["InventDimID"] != null ? row["InventDimID"].ToString() : "";
            Size = row["Size"] != null ? row["Size"].ToString() : "";
            Style = row["Style"] != null ? row["Style"].ToString() : "";
            Config = row["Config"] != null ? row["Config"].ToString() : "";
            Color = row["Color"] != null ? row["Color"].ToString() : ""; 
        }
    }
}
