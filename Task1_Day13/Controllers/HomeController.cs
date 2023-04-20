using Microsoft.Ajax.Utilities;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Task1_Day13.Models;

namespace Task1_Day13.Controllers
{  
    public class HomeController : Controller
    {       

        HttpClient client = new HttpClient();
               

        static List<Students> listOfStudents = new List<Students>()
            {
             new Students
             {
                 Id = 1,
                 Name="Dev",
                 Division='A',
                 Standard = 12,
                 Age=19,
                 City="Junagadh",
                 Stream= "Science"
             },

             new Students
             {
                 Id = 2,
                 Name="Param",
                 Division='B',
                 Standard = 11,
                 Age=18,
                 City="Bhavnagar",
                 Stream= "Commerce"
             },

             new Students
             {
                 Id = 3,
                 Name="Rishit",
                 Division='A',
                 Standard = 10,
                 Age=18,
                 City="Ankleshwar",
                 Stream= "Arts"
             },

             new Students
             {
                 Id = 4,
                 Name="Mayur",
                 Division='C',
                 Standard = 09,
                 Age=15,
                 City="Surat",
                 Stream= "Diploma"
             },

             new Students
             {
                 Id = 5,
                 Name="Mohit",
                 Division='B',
                 Standard = 12,
                 Age=20,
                 City="Junagadh",
                 Stream= "MBA"
             }
         };


        public ActionResult Index()
        {
            var list = new List<Students>();

            return View(list);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Students obj)
        {
           /* ViewData["createTitle"] = "Create Student";*/
           listOfStudents.Add(obj);


            return View("Index", obj);
            
                       
              /*  return RedirectToAction("Index");*/
        }

        public ActionResult Details(int id)
        {
            Students obj = listOfStudents.Find(student => student.Id == id);
            return View(obj);
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.updateTitle = "Update Student";

            var obj = listOfStudents.Where(x => x.Id == id).FirstOrDefault();
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(Students obj)
        {
            var data = listOfStudents.Where(x => x.Id == obj.Id).FirstOrDefault();
            if(data != null)
            {
                data.Id = obj.Id;
                data.Name = obj.Name;
                data.Division = obj.Division;
                data.Standard  = obj.Standard;
                data.Age = obj.Age;
                data.City = obj.City;
                data.Stream = obj.Stream;
             }

            obj.Name = "OK";

            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var obj = listOfStudents.Where(x => x.Id == id).FirstOrDefault();
           // return View(obj);
            listOfStudents.Remove(obj);

            ViewData["Students"] = listOfStudents;

            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
                        
        }
       
    }
}