using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    //[System.Web.Http.Authorize]
    public class pda_UserController : ApiController
    {
        // GET: api/pda_User
        public List<DataObjects.PDA.PDA_User> Get()
        {
            List<DataObjects.PDA.PDA_User> user = new List<DataObjects.PDA.PDA_User>();
            user = Bussiness.PDA.GetUser("");
            return user;
        }

        // GET: api/pda_User/5
        public List<DataObjects.PDA.PDA_User> Get(string id)
        {
            List<DataObjects.PDA.PDA_User> user = new List<DataObjects.PDA.PDA_User>();
            user = Bussiness.PDA.GetUser(id);
            return user;
        }

        // POST: api/pda_User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/pda_User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/pda_User/5
        public void Delete(int id)
        {
        }
    }
}
