using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AX_SalesOrderController : ApiController
    {
        // GET: api/AXSalesOrder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        //http://localhost:52481/api/AXSalesOrder?fd='20220601'&td='20220602'&location='TPBHW'
        [Route("api/AXSalesOrder")]
        public DataObjects.LAG.AX_SalesOrder GetOrder(string fd, string td, string location)
        {
            return Bussiness.LAG.AX_SalesOrder.Get(fd, td, location);
        }

        [HttpGet]
        //http://localhost:52481/api/AXSalesOrder/SO22-019831
        [Route("api/AXSalesOrder/{id}")]
        public DataObjects.LAG.AX_SalesOrderObject GetDetail(string id)
        {
            return Bussiness.LAG.AX_SalesOrder.GetDetail(id);
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
