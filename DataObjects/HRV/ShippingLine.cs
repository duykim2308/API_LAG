using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class ShippingLine
    {
        public string code { get; set; }
        public double price { get; set; }
        public object source { get; set; }
        public string title { get; set; }
    }
}
