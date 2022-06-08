using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_TOController : ApiController
    {
        // GET: api/pda_TO
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_TO/5
        public List<DataObjects.PDA.PDA_TO> Get(string id)
        {
            List<DataObjects.PDA.PDA_TO> lsArray = new List<DataObjects.PDA.PDA_TO>();
            try
            {
                lsArray = Bussiness.PDA.GetTO(id, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        public List<DataObjects.PDA.PDA_TO> Get(string id, string id2)
        {
            List<DataObjects.PDA.PDA_TO> lsArray = new List<DataObjects.PDA.PDA_TO>();
            try
            {
                lsArray = Bussiness.PDA.GetTO(id, id2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // POST: api/pda_TO
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_TO/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_TO/5
        public void Delete(int id)
        {
        }
    }
}
