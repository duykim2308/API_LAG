using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class AX_TransferOrderController : ApiController
    {
        // GET: api/AXTransferOrder
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        //http://localhost:52481/api/AXTransferOrder?fd='20220601'&td='20220602'&location='TPBHW'
        [Route("api/AXTransferOrder")]
        public DataObjects.LAG.AX_TransferOrder GetOrder(string fd, string td, string location)
        {
            return Bussiness.LAG.AX_TransferOrder.Get(fd, td, location);
        }

        [HttpGet]
        //http://localhost:52481/api/AXTransferOrder/IMTF-000021
        [Route("api/AXTransferOrder/{id}")]
        public DataObjects.LAG.AX_TransferOrderObject GetDetail(string id)
        {
            return Bussiness.LAG.AX_TransferOrder.GetDetail(id);
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
