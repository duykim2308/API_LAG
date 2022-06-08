using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AX_LocationController : ApiController
    {
        // GET: api/AX_Product
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("api/AXLocation")]
        public List<DataObjects.LAG.AX_Location> GetProduct()
        {
            return Bussiness.LAG.AX_Location.Get();
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
