using Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [Filter.BasicAuthentication]
    public class VSController : ApiController
    {
        [HttpGet]
        // GET: api/VS
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet] 
        [Route("api/Product/Get")] 
        public DataObjects.VS.Product GetProduct()
        {
            return Bussiness.VS.AX_Product.Get();
        }

        [HttpGet] 
        [Route("api/Inventory/Get")] 
        public DataObjects.VS.Inventory GetInventory()
        {
            return Bussiness.VS.Inventory.Get();
        }

        // POST: api/VS
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/VS/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/VS/5
        public void Delete(int id)
        {
        }
    }
}
