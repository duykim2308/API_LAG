using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AX_CustomerController : ApiController
    {
        // GET: api/AX_Customer
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //http://ldcpbi/api/axcustomer/kim
        [HttpGet]
        [Route("api/AXCustomer/{search}")]
        public DataObjects.LAG.AX_Customers GetCustomer(string search)
        {
            return Bussiness.LAG.AX_Customer.Get(search);
        }


        //http://ldcpbi/api/axcustomer
        [HttpGet]
        [Route("api/AXCustomer")]
        public DataObjects.LAG.AX_Customers GetCustomer()
        {
            return Bussiness.LAG.AX_Customer.Get("");
        }

        // POST: api/AX_Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/AX_Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/AX_Customer/5
        public void Delete(int id)
        {
        }
    }
}
