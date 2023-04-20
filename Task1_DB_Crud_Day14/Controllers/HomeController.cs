using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1_DB_Crud_Day14.Models;

namespace Task1_DB_Crud_Day14.Controllers
{
    public class HomeController : Controller
    {
        PracticeEntities2 db_object = new PracticeEntities2();

        public ActionResult Index()
        {
            var list = db_object.Students.ToList(); 

            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student st)
        {
            db_object.Students.Add(st);
            db_object.SaveChanges();
            /// ViewBag.Message("Student Created");
            ViewData["Created"] = "Student Created";

            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db_object.Students.Where(x => x.id == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Student st)
        {
            var data = db_object.Students.Where(x => x.id == st.id).FirstOrDefault();

            if(data != null)
            {
                data.name = st.name;
                data.standard = st.standard;
                db_object.SaveChanges();
                ViewData["updated"] = "Student Data Updated.";
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = db_object.Students.Where(x => x.id == id).FirstOrDefault();

            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = db_object.Students.Where(x => x.id == id).FirstOrDefault();
            db_object.Students.Remove(data);
            db_object.SaveChanges();
            // ViewBag.Message("Student Deleted SuccessFully...");
            ViewData["Deleted"] = "Student Deleted Successfully.";

            return RedirectToAction("Index");
        }

        
    }
}