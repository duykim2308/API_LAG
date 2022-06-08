using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class DateCosmetic
    {
        public List<Data> datas { get; set; }

        public class Data
        {
            public string ItemNo { get; set; }
            public string ItemName { get; set; }
            public string Location { get; set; }
            public string Variant { get; set; }
            public string Barcode { get; set; }
            public string Date { get; set; }
            public int Quantity { get; set; }

            public Data()
            {
                ItemNo = "";
                ItemName = "";
                Location = "";
                Variant = "";
                Barcode = "";
                Date = "";
                Quantity = 0;
            }

            public Data(System.Data.DataRow row)
            {
                ItemNo = row["ItemNo"].ToString() != null ? row["ItemNo"].ToString() : "";
                ItemName = row["ItemName"].ToString() != null ? row["ItemName"].ToString() : "";
                Location = row["Location"].ToString() != null ? row["Location"].ToString() : "";
                Variant = row["Variant"].ToString() != null ? row["Variant"].ToString() : "";
                Barcode = row["Barcode"].ToString() != null ? row["Barcode"].ToString() : "";
                Date = row["Date"].ToString() != null ? row["Date"].ToString() : "";
                Quantity = row["Quantity"].ToString() != null ? int.Parse(row["Quantity"].ToString()) : 0;
            }

        }

    }

    public class DateCosmeticERP
    {
        public string Company { get; set; }
        public string Location { get; set; }
        public DateTime? Date { get; set; }
        public string Document { get; set; }
        public string Type { get; set; }
        public string User { get; set; }
        public List<Data> datas { get; set; }

        public DateCosmeticERP()
        {
            Company = "";
            Location = "";
            Date = null;
            Document = "";
            Type = "";
            User = "";
            datas = new List<Data>();
        }

        public class Data
        {
            public string ItemNo { get; set; }
            public string ItemName { get; set; }
            public string Location { get; set; }
            public string Variant { get; set; }
            public string Barcode { get; set; }
            public string StringDate { get; set; }
            public int Quantity { get; set; }

            public Data()
            {
                ItemNo = "";
                ItemName = "";
                Location = "";
                Variant = "";
                Barcode = "";
                StringDate = "";
                Quantity = 0; 
            }

            public Data(System.Data.DataRow row)
            {
                ItemNo = row["ItemNo"].ToString() != null ? row["ItemNo"].ToString() : "";
                ItemName = row["ItemName"].ToString() != null ? row["ItemName"].ToString() : "";
                Location = row["Location"].ToString() != null ? row["Location"].ToString() : "";
                Variant = row["Variant"].ToString() != null ? row["Variant"].ToString() : "";
                Barcode = row["Barcode"].ToString() != null ? row["Barcode"].ToString() : "";
                StringDate = row["StringDate"].ToString() != null ? row["StringDate"].ToString() : "";
                Quantity = row["Quantity"].ToString() != null ? int.Parse(row["Quantity"].ToString()) : 0;
            }


        }

    }

}
