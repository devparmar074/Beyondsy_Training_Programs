using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Day11_WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {

        string[] employees = { "Dev", "Param", "Rishit" };

        [HttpGet]
        public string[] getemployees()
        {
            return employees;
        }

        public string getEmployeebyId(int id)
        {
            return employees[id];
        }
    }
}
