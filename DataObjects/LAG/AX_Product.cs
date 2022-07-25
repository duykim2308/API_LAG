using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_Product
    {
        public List<Product> products { get; set; }
    }

    public class Product
    {
        public string Item { get; set; }
        public string Name { get; set; }
        public string BusinessLine { get; set; } 
        public string SubCat { get; set; } 
        public string ProductCat { get; set; } 
        public DateTime CreateDate { get; set; }
        public List<Variant> Variants { get; set; }

        public Product()
        {
            Item = "";
            Name = "";
            BusinessLine = "";
            SubCat = "";
            ProductCat = "";
            CreateDate = DateTime.Now;
            new List<Variant>();
        }

        public Product(System.Data.DataRow row)
        {
            Item = row["Item"] != null ? row["Item"].ToString() : "";
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            BusinessLine = row["BusinessLine"] != null ? row["BusinessLine"].ToString() : "";
            SubCat = row["SubCat"] != null ? row["SubCat"].ToString() : "";
            ProductCat = row["ProductCat"] != null ? row["ProductCat"].ToString() : "";
            CreateDate = row["CreateDate"] != null ? DateTime.Parse(row["CreateDate"].ToString()) : DateTime.Now;
        }
    }


    public class Variant
    {
        public string Name { get; set; }
        public string RetailVariantID { get; set; }
        public string InventDimID { get; set; }
        public string Size { get; set; }
        public string Style { get; set; }
        public string Config { get; set; }
        public string Color { get; set; }
        public List<PriceGroups> PriceGroups { get; set; }

        public Variant()
        {
            Name = "";
            RetailVariantID = "";
            InventDimID = "";
            Size = "";
            Style = "";
            Config = "";
            Color = "";
            new List<PriceGroups>();
        }

        public Variant(System.Data.DataRow row)
        {
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            RetailVariantID = row["RetailVariantID"] != null ? row["RetailVariantID"].ToString() : "";
            InventDimID = row["InventDimID"] != null ? row["InventDimID"].ToString() : "";
            Size = row["Size"] != null ? row["Size"].ToString() : "";
            Style = row["Style"] != null ? row["Style"].ToString() : "";
            Config = row["Config"] != null ? row["Config"].ToString() : "";
            Color = row["Color"] != null ? row["Color"].ToString() : "";
        }
    }

    public class PriceGroups
    {
        public string InventDimID { get; set; }
        public string PriceGroup { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string UnitID { get; set; }

        public PriceGroups()
        {
            InventDimID = "";
            PriceGroup = "";
            FromDate = DateTime.Now;
            ToDate = DateTime.Now;
            Amount = 0;
            Currency = "";
            UnitID = "";
        }

        public PriceGroups(System.Data.DataRow row)
        { 
            InventDimID = row["InventDimID"] != null ? row["InventDimID"].ToString() : "";
            PriceGroup = row["PriceGroup"] != null ? row["PriceGroup"].ToString() : "";
            FromDate = row["FromDate"] != null ? DateTime.Parse(row["FromDate"].ToString()) : DateTime.Now;
            ToDate = row["ToDate"] != null ? DateTime.Parse(row["ToDate"].ToString()) : DateTime.Now;
            Amount = row["Amount"] != null ? decimal.Parse(row["Amount"].ToString()) : 0;
            Currency = row["Currency"] != null ? row["Currency"].ToString() : "";
            UnitID = row["UnitID"] != null ? row["UnitID"].ToString() : "";
        }


    }


}


