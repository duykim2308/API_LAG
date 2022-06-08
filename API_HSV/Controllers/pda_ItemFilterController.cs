using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_ItemFilterController : ApiController
    {
        // GET: api/pda_ItemFilter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/pda_ItemFilter/5
        public List<DataObjects.PDA.PDA_Item> Get(int id)
        {
            List<DataObjects.PDA.PDA_Item> lsArray = new List<DataObjects.PDA.PDA_Item>();
            try
            {
                lsArray = Bussiness.PDA.GetItemFilter(id);
            }
            catch (Exception ex)
            {

            }
            return lsArray;
        }

        // POST: api/pda_ItemFilter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_ItemFilter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_ItemFilter/5
        public void Delete(int id)
        {
        }
    }
}
