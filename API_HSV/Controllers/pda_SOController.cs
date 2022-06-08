using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_SOController : ApiController
    {
        // GET: api/pda_SO
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_SO/5
        public List<DataObjects.PDA.PDA_SO> Get(string id)
        {
            List<DataObjects.PDA.PDA_SO> lsArray = new List<DataObjects.PDA.PDA_SO>();
            try
            {
                lsArray = Bussiness.PDA.GetSO(id, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        public List<DataObjects.PDA.PDA_SO> Get(string id, string id2)
        {
            List<DataObjects.PDA.PDA_SO> lsArray = new List<DataObjects.PDA.PDA_SO>();
            try
            {
                lsArray = Bussiness.PDA.GetSO(id, id2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // POST: api/pda_SO
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_SO/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_SO/5
        public void Delete(int id)
        {
        }
    }
}
