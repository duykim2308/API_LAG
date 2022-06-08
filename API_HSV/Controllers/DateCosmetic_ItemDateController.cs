using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class DateCosmetic_ItemDateController : ApiController
    {
        // GET: api/DateCosmetic_ItemDate
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DateCosmetic_ItemDate/5
        public DataObjects.DateCosmetic Get(string id, string location)
        {
            DataObjects.DateCosmetic obj = new DataObjects.DateCosmetic();
            obj = Bussiness.DateCosmetic.GetDate(id, location);
            return obj;
        }

        // GET: api/DateCosmetic_ItemDate/GetPOSERP
        [Route("api/DateCosmetic_ItemDate/GetPOSERP/{id}")]
        [HttpGet]
        public DataObjects.DateCosmeticERP GetPOSERP(string id, string company)
        {
            DataObjects.DateCosmeticERP obj = new DataObjects.DateCosmeticERP();
            obj = Bussiness.DateCosmetic.GetPOSERP(id, company);
            return obj;
        }

        // GET: api/DateCosmetic_ItemDate/GetERP
        [Route("api/DateCosmetic_ItemDate/GetERP/{id}")]
        [HttpGet]
        public List<DataObjects.DateCosmeticERP.Data> GetERP(string id, string type, string company)
        {
            List<DataObjects.DateCosmeticERP.Data> obj = new List<DataObjects.DateCosmeticERP.Data>();
            obj = Bussiness.DateCosmetic.GetERP(id, type, company);
            return obj;
        }

        // POST: api/DateCosmetic_ItemDate
        public void Post(DataObjects.DateCosmeticERP obj)
        {
            Bussiness.DateCosmetic.InsertPOSERP(obj);
        }

        // POST: api/DateCosmetic_ItemDate/id
        public void Post(string id, string location)
        {
            Bussiness.DateCosmetic.InsertERP(id, location);
        }

        // PUT: api/DateCosmetic_ItemDate/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DateCosmetic_ItemDate/5
        public void Delete(int id)
        {
        }

    }
}
