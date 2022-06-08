using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_INVENTORYController : ApiController
    {
        // GET: api/pda_INVENTORY
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_INVENTORY/5
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/pda_INVENTORY
        public List<DataObjects.PDA.PDA_Inventory> Post(DataObjects.PDA.PDA_Inventory.InputInventory obj)
        {
            List<DataObjects.PDA.PDA_Inventory> array = new List<DataObjects.PDA.PDA_Inventory>();
            array = Bussiness.PDA.GetInventory(obj.Date, obj.StockID);
            return array;
        }

        // PUT: api/pda_INVENTORY/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_INVENTORY/5
        public void Delete(int id)
        {
        }
    }
}
