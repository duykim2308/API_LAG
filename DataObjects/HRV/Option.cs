using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class Option
    {
        public string name { get; set; }
        public long id { get; set; }
        public int position { get; set; }
        public long product_id { get; set; }
    }
}
