using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Product
    {
        public string body_html { get; set; }
        public string created_at { get; set; }
        public string handle { get; set; }
        public long id { get; set; }
        public List<Image> images { get; set; }
        public string product_type { get; set; }
        public string published_at { get; set; }
        public string published_scope { get; set; }
        public string tags { get; set; }
        public string template_suffix { get; set; }
        public string title { get; set; }
        public string updated_at { get; set; }
        public List<Variant> variants { get; set; }
        public string vendor { get; set; }
        public List<Option> options { get; set; }
        public bool only_hide_from_list { get; set; }
    }

    public class ProductWebhook
    {
        public string body_html { get; set; }
        public object body_plain { get; set; }
        public string created_at { get; set; }
        public string handle { get; set; }
        public int id { get; set; }
        public List<Image> images { get; set; }
        public string product_type { get; set; }
        public string published_at { get; set; }
        public string published_scope { get; set; }
        public string tags { get; set; }
        public string template_suffix { get; set; }
        public string title { get; set; }
        public string updated_at { get; set; }
        public List<Variant> variants { get; set; }
        public string vendor { get; set; }
        public List<Option> options { get; set; }
        public bool only_hide_from_list { get; set; }
        public string metafields_global_title_tag { get; set; }
        public string metafields_global_description_tag { get; set; }
        public bool not_allow_promotion { get; set; }
    }
}
