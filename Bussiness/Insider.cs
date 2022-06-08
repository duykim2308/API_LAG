using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Insider
    {
        
        public static int Create(DataObjects.Insider.XML item)
        {
            List<DataObjects.Insider.XML> lsArray = new List<DataObjects.Insider.XML>();
            lsArray.Add(item);
            return DataAccess.Insider.Create(lsArray);
        }

    }
}
