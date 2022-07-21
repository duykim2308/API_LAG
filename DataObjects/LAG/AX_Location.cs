using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_Location
    {
        public List<Location> locations { get; set; }
    }

    public class Location
    {
        public string LocationCode { get; set; }
        public string Name { get; set; }
        public string Site { get; set; } 
        public string Transit { get; set; }  


        public Location()
        {
            LocationCode = "";
            Name = "";
            Site = "";
            Transit = ""; 
        }

        public Location(System.Data.DataRow row)
        {
            LocationCode = row["Location"] != null ? row["Location"].ToString() : "";
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            Site = row["Site"] != null ? row["Site"].ToString() : "";
            Transit = row["Transit"] != null ? row["Transit"].ToString() : ""; 
        }
    }
}
