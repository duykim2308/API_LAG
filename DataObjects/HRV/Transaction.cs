using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Transaction
    {
        public double amount { get; set; }
        public object authorization { get; set; }
        public string created_at { get; set; }
        public object device_id { get; set; }
        public string gateway { get; set; }
        public int id { get; set; }
        public string kind { get; set; }
        public int order_id { get; set; }
        public object receipt { get; set; }
        public object status { get; set; }
        public bool test { get; set; }
        public int user_id { get; set; }
        public object payment_details { get; set; }
        public int? parent_id { get; set; }
        public string currency { get; set; }
        public string haravan_transaction_id { get; set; }
        public string external_transaction_id { get; set; }
    }
}
