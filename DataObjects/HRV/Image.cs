using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Image
    {
        public string created_at { get; set; }
        public long id { get; set; }
        public int position { get; set; }
        public long product_id { get; set; }
        public string src { get; set; }
        public string updated_at { get; set; }
        public object attachment { get; set; }
        public string filename { get; set; }
        public List<object> variant_ids { get; set; }
    }
}
