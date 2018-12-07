using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using employeeDataAccess;

namespace WebApitest.Controllers
{
    public class employeeController : ApiController
    {
        public IEnumerable<employe_tbl> Get()
        {
            using (android7Entities entities = new android7Entities())
            {
                return entities.employe_tbl.ToList();
            }
        }

        public employe_tbl Get(string id)
        {
            using (android7Entities entities = new android7Entities())
            {
                return entities.employe_tbl.FirstOrDefault(e => e.id == id);
            }
        }
    }
}
