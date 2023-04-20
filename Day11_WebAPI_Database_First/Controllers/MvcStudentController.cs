using Day11_WebAPI_Database_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Day11_WebAPI_Database_First.Controllers
{
    public class MvcStudentController : Controller
    {
        // GET: MvcStudent
        HttpClient client = new HttpClient();
        
        public ActionResult Index()
        {
            List<Student> list = new List<Student>();
            client.BaseAddress = new Uri("https://localhost:44379/api/Student");

            var response = client.GetAsync("Student");
            response.Wait();

            
            var test = response.Result;

            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Student>>();
                display.Wait();
                list = display.Result;
            }

            return View(list);
        }
    }
}