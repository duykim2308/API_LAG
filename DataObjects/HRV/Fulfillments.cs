using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Fulfillments
    {
        public string created_at { get; set; }
        public int id { get; set; }
        public int order_id { get; set; }
        public object receipt { get; set; }
        public string status { get; set; }
        public string tracking_company { get; set; }

        //public List<string> tracking_numbers { get; set; }
        public string tracking_number { get; set; }

        public string tracking_url { get; set; }

        //public List<string> tracking_urls { get; set; }
        public string updated_at { get; set; }

        public bool notify_customer { get; set; }
        public string district_code { get; set; }
        public double cod_amount { get; set; }
        public string carrier_status_name { get; set; }
        public string carrier_cod_status_name { get; set; }
    }

    public class Fulfillments_fulfilled
    {
        public string tracking_number { get; set; }
        public bool notify_customer { get; set; }

        public Fulfillments_fulfilled()
        {
            tracking_number = "";
            notify_customer = true;
        }
    }
}
