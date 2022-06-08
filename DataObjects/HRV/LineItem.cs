using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class LineItem
    {
        public double id { get; set; }
        public double order_id { get; set; }
        public int fulfillable_quantity { get; set; }
        public string fulfillment_status { get; set; }
        public double grams { get; set; }
        public double price { get; set; }
        public double price_original { get; set; }
        public string product_id { get; set; }
        public int quantity { get; set; }
        public bool requires_shipping { get; set; }
        public string sku { get; set; }
        public string title { get; set; }
        public string variant_id { get; set; }
        public string variant_title { get; set; }
        public string vendor { get; set; }
        public string name { get; set; }
        public bool gift_card { get; set; }
        public bool taxable { get; set; }
    }
}
