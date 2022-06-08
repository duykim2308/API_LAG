using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.VS
{
    public class Inventory
    {
        public List<Inventorys> inventorys { get; set; }

        public class Inventorys
        {
            public string ItemNo { get; set; }
            public string Location { get; set; }
            public int Quantity { get; set; }

            public Inventorys()
            {
                ItemNo = "";
                Location = "";
                Quantity = 0;
            }

            public Inventorys(System.Data.DataRow row)
            {
                ItemNo = row["ItemNo"].ToString();
                Location = row["Location"].ToString();
                Quantity = int.Parse(row["Quantity"].ToString());
            }
        }
         
       
    }
}
