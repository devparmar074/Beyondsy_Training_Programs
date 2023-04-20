using Day11_WebAPI_Database_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Day11_WebAPI_Database_First.Controllers
{
    public class StudentController : ApiController
    {
        PracticeEntities1 db = new PracticeEntities1();

        // get all Employee
        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<Student> obj = db.Students.ToList();

            return Ok(obj); 
        }


        // For getEmployee by Id.
        [System.Web.Http.HttpGet]
        public IHttpActionResult ActionbyId(string id)
        {
            var obj = db.Students.Where(model => model.id == id).FirstOrDefault();

            return Ok(obj);
        }


    }
}
