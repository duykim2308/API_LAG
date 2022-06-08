using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_Inventory
    {
        public string Item { get; set; }
        public string Location { get; set; }
        public string Size { get; set; } 
        public string Config { get; set; }  
        public string Color { get; set; }  
        public string Style { get; set; }  
        public float PhysicalInventory { get; set; }  


        public AX_Inventory()
        {
            Item = "";
            Location = "";
            Size = "";
            Config = ""; 
            Color = ""; 
            Style = "";
            PhysicalInventory = 0; 
        }

        public AX_Inventory(System.Data.DataRow row)
        {
            Item = row["Item"] != null ? row["Item"].ToString() : "";
            Location = row["Location"] != null ? row["Location"].ToString() : "";
            Size = row["Size"] != null ? row["Size"].ToString() : "";
            Config = row["Config"] != null ? row["Config"].ToString() : "";
            Style = row["Style"] != null ? row["Style"].ToString() : "";
            PhysicalInventory = row["PhysicalInventory"] != null ? float.Parse(row["PhysicalInventory"].ToString()) : 0;
        }
    }
}
