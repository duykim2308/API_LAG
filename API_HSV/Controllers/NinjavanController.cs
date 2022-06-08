using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class NinjavanController : ApiController
    {
        // GET: api/Ninjavan
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ninjavan/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ninjavan

        [HttpPost]
        [Route("api/NinjaVan/VSTYLE")]
        public void Post_HSV(DataObjects.Ninjavan value)
        {
            Bussiness.Ninjavan.Insert("VSTYLE", value);
        }

        // PUT: api/Ninjavan/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ninjavan/5
        public void Delete(int id)
        {
        }
    }
}
