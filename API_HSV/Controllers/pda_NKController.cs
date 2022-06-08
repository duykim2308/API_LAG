using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_NKController : ApiController
    {
        // GET: api/pda_NK
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_NK/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/pda_NK
        public int Post(DataObjects.PDA.PDA_NK obj)
        {
            return Bussiness.PDA.CreateNK(obj);
        }

        // PUT: api/pda_NK/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_NK/5
        public void Delete(int id)
        {
        }
    }
}
