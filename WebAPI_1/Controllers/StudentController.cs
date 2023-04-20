using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_1.Models;

namespace WebAPI_1.Controllers
{
    public class StudentController : ApiController
    {
        db_testEntities db = new db_testEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<tbl_Student> obj = new List<tbl_Student>();
            return Ok(obj);
        }


    }
}
