using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class KiotViet_BranchController : ApiController
    {
        // GET: api/KiotViet_Branch
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/KiotViet_Branch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/KiotViet_Branch
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KiotViet_Branch/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/KiotViet_Branch/5
        public void Delete(int id)
        {
        }
    }
}
