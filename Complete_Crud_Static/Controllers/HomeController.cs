using MainCrud.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;


namespace MainCrud.Controllers
{
    public class HomeController : Controller
    {
        static List<Student> listOfStudents = new List<Student>();

        /*public ActionResult Index()
        {           
            return View();
        }*/

        public ActionResult Index(Student studentObject)
        {
            ViewBag.model = listOfStudents;
            //  return View(listOfStudents);
            return View();
            
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student studentObject)
        {
            var selectedvalue = studentObject.Gender;
            ViewBag.GenderType = selectedvalue.ToString();
                listOfStudents.Add(studentObject);

            //return View("Index",studentObject);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Student obj = listOfStudents.Find(student => student.Id == id);
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
        public ActionResult Edit(Student obj)
        {
            var data = listOfStudents.Where(x => x.Id == obj.Id).FirstOrDefault();
            if (data != null)
            {
                data.Id = obj.Id;
                data.Name = obj.Name;
            }

            //return RedirectToAction("Index");
            return View("Index");
        }


        public ActionResult Delete(int id)
        {
            var deleteData = listOfStudents.Where(x => x.Id == id).FirstOrDefault();
           
            listOfStudents.Remove(deleteData);

           // ViewData["Students"] = listOfStudents;

            
            return RedirectToAction("index");
            //return View("Index");

        }

    }
}