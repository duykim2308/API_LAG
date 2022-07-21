using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.LAG
{
    public class AX_Customers
    {
        public List<Customer> Customers {get;set;}
    }

        public class Customer
    {
        public string Account { get; set; }
        public string Name { get; set; }
        public string CustGroup { get; set; } 
        public string CustClassification { get; set; }  


        public Customer()
        {
            Account = "";
            Name = "";
            CustGroup = "";
            CustClassification = ""; 
        }

        public Customer(System.Data.DataRow row)
        {
            Account = row["Account"] != null ? row["Account"].ToString() : "";
            Name = row["Name"] != null ? row["Name"].ToString() : "";
            CustGroup = row["CustGroup"] != null ? row["CustGroup"].ToString() : "";
            CustClassification = row["CustClassification"] != null ? row["CustClassification"].ToString() : ""; 
        }
    }
}
