using Day11_Web_API_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Day11_Web_API_Crud.Controllers
{
    public class CrudApiController : ApiController
    {
        PracticeEntities1 db = new PracticeEntities1();


        // Get all Employee
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployees()
        {
            List<Employee> list = db.Employees.ToList();
            return Ok(list);
        }


        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
           var emp = db.Employees.Where(model => model.id == id).FirstOrDefault();
            return Ok(emp);
        }


        // Create Employee
        [System.Web.Http.HttpPost]
        public IHttpActionResult Create(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
            return Ok(e);
        }



        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var emp = db.Employees.Where(model => model.id == id).FirstOrDefault();
            db.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
