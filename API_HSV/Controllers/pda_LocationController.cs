using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class pda_LocationController : ApiController
    {
        // GET: api/pda_Location
        public List<DataObjects.PDA.PDA_Location> Get()
        {
            List<DataObjects.PDA.PDA_Location> lsArray = new List<DataObjects.PDA.PDA_Location>();
            try
            {
                lsArray = Bussiness.PDA.GetLocation("");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // GET: api/pda_Location/5
        public List<DataObjects.PDA.PDA_Location> Get(string id)
        {
            List<DataObjects.PDA.PDA_Location> lsArray = new List<DataObjects.PDA.PDA_Location>();
            try
            {
                lsArray = Bussiness.PDA.GetLocation(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lsArray;
        }

        // POST: api/pda_Location
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_Location/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_Location/5
        public void Delete(int id)
        {
        }
    }
}
