using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class ProductPrice
    {
        public string body_html { get; set; }
        public DateTime created_at { get; set; }
        public string handle { get; set; }
        public int id { get; set; }
        public string product_type { get; set; }
        public DateTime published_at { get; set; }
        public string published_scope { get; set; }
        public object template_suffix { get; set; }
        public string title { get; set; }
        public DateTime updated_at { get; set; }
        public string vendor { get; set; }
        public string tags { get; set; }
        public List<ImagePrice> images { get; set; }
        public ImagePrice image { get; set; }
        public List<OptionPrice> options { get; set; }
        public List<VariantPrice> variants { get; set; }

        public class VariantPrice
        {
            public object barcode { get; set; }
            public decimal compare_at_price { get; set; }
            public string fulfillment_service { get; set; }
            public int grams { get; set; }
            public int id { get; set; }
            public string inventory_management { get; set; }
            public string inventory_policy { get; set; }
            public string option1 { get; set; }
            public string option2 { get; set; }
            public string option3 { get; set; }
            public int position { get; set; }
            public decimal price { get; set; }
            public int product_id { get; set; }
            public bool requires_shipping { get; set; }
            public string sku { get; set; }
            public bool taxable { get; set; }
            public string title { get; set; }
            public object updated_at { get; set; }
            public int inventory_quantity { get; set; }
            public int old_inventory_quantity { get; set; }
            public object image_id { get; set; }
            public double weight { get; set; }
            public string weight_unit { get; set; }
        }

        public class OptionPrice
        {
            public int product_id { get; set; }
            public string name { get; set; }
            public int position { get; set; }
        }

        public class ImagePrice
        {
            public object created_at { get; set; }
            public int id { get; set; }
            public int position { get; set; }
            public int product_id { get; set; }
            public object updated_at { get; set; }
            public string src { get; set; }
            public List<object> variant_ids { get; set; }
        }
    }
}
