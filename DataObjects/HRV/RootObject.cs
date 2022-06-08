using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.HRV
{
    public class RootProduct
    {
        public List<Product> products { get; set; }
    }

    public class RootProductPrice
    {
        public ProductPrice product { get; set; }
    }

}
