using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.VS
{
    public class Product
    {
        public List<Products> products { get; set; }

        public class Products
        {
            public string ItemNo { get; set; }
            public string Barcode { get; set; }
            public string ItemName { get; set; }
            public string Category { get; set; }
            public int UnitPrice { get; set; }
            public string Brand { get; set; }

            public Products()
            {
                ItemNo = "";
                Barcode = "";
                ItemName = "";
                Category = "";
                UnitPrice = 0;
                Brand = "";
            }

            public Products(System.Data.DataRow row)
            {
                ItemNo = row["ItemNo"].ToString();
                Barcode = row["Barcode"].ToString();
                ItemName = row["ItemName"].ToString();
                Category = row["Category"].ToString();
                UnitPrice = int.Parse(row["UnitPrice"].ToString());
                Brand = row["Brand"].ToString();
            }
        }
    }
    
}
