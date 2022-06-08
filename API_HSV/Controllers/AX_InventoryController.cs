using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AX_InventoryController : ApiController
    {
        // GET: api/AX_Product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/AXInventory")]
        public List<DataObjects.LAG.AX_Inventory> GetInventory(string location, string item)
        {
            return Bussiness.LAG.AX_Inventory.Get(location, item);
        }

        // POST: api/AX_Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AX_Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AX_Product/5
        public void Delete(int id)
        {
        }
    }
}
