using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Variant
    {
        public object barcode { get; set; }
        public double compare_at_price { get; set; }
        public string created_at { get; set; }
        public object fulfillment_service { get; set; }
        public double grams { get; set; }
        public long id { get; set; }
        public string inventory_management { get; set; }
        public string inventory_policy { get; set; }
        public int inventory_quantity { get; set; }
        public int old_inventory_quantity { get; set; }
        public object inventory_quantity_adjustment { get; set; }
        public int position { get; set; }
        public double price { get; set; }
        public long product_id { get; set; }
        public bool requires_shipping { get; set; }
        public string sku { get; set; }
        public bool taxable { get; set; }
        public string title { get; set; }
        public string updated_at { get; set; }
        public int? image_id { get; set; }
        public string option1 { get; set; }
        public object option2 { get; set; }
        public object option3 { get; set; } 
    }
}
