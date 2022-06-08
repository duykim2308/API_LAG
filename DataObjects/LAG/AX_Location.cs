using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_Location
    {
        public string Location { get; set; }
        public string Name { get; set; }
        public string Site { get; set; } 
        public string Transit { get; set; }  


        public AX_Location()
        {
            Location = "";
            Name = "";
            Site = "";
            Transit = ""; 
        }

        public AX_Location(System.Data.DataRow row)
        {
            Location = row["Location"] != null ? row["Location"].ToString() : "";
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            Site = row["Site"] != null ? row["Site"].ToString() : "";
            Transit = row["Transit"] != null ? row["Transit"].ToString() : ""; 
        }
    }
}
