using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class LDAPController : ApiController
    {
        // GET: api/LDAP/5

        //[Route("api/LDAP/{id}")]
        //public DataObjects.LDAP Get(string id)
        //{
        //    return Bussiness.LDAP.GetUser_anr(new DataObjects.LDAP.Login(id));
        //}

        //[Route("api/LDAP/email/{email}")]
        //public DataObjects.LDAP GetbyEmail(string email)
        //{
        //    return Bussiness.LDAP.GetUser_Email(email);
        //}

        //[Route("api/LDAP/pager/{pager}")]
        //public DataObjects.LDAP GetbyPager(string pager)
        //{
        //    return Bussiness.LDAP.GetUser_Pager(pager);
        //}

        // POST: api/LDAP
        public DataObjects.LDAP Post(DataObjects.LDAP.Login value)
        {
            return Bussiness.LDAP.Login(value);
        }
    }
}
