
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API.db_context;
using WEB_API.Models;

namespace web_Api_crud.Controllers
{

    public class EmpController : ApiController
    {
        [HttpGet]
        [Route("emp/getemployee")]
        // GET api/<controller>
        public List<MYTABLE1> getname()
        {
            List<modelclass> listemp = new List<modelclass>();

            myprojectEntities objlist = new myprojectEntities();

            var res = objlist.MYTABLE1.ToList();

            return res;
        }

        [HttpPost]
        [Route("emp/saveEmployee")]
        public List<string> saveemp()
        {

            List<string> obj = new List<string>()
            {
                "neelam",
                "rohit",
                "vikas"

            };


            return obj;
        }
    }
}