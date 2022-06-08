using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class Insider_Email
    {
        
        public static int Create(DataObjects.Insider_Email.XML item)
        {
            List<DataObjects.Insider_Email.XML> lsArray = new List<DataObjects.Insider_Email.XML>();
            lsArray.Add(item);
            return DataAccess.Insider_Email.Create(lsArray);
        }

         

    }
}
