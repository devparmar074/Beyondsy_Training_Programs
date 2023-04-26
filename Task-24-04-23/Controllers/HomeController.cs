using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_24_04_23.Models;

namespace Task_24_04_23.Controllers
{
    public class HomeController : Controller
    {
        PracticeEntities1 dbObject = new PracticeEntities1();

        public ActionResult Index()
        {
            List<Exercise> exercises = dbObject.Exercises.ToList();
            ViewBag.model = exercises;
            return View(exercises); 
        }


        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Create(Exercise exerciseObject)
        {
            dbObject.Exercises.Add(exerciseObject);
            dbObject.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var fetchedRecord = dbObject.Exercises.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.model = fetchedRecord;

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var fetchedRecord = dbObject.Exercises.Where((x) => x.Id == id).FirstOrDefault();

            return View(fetchedRecord);
        }

        public ActionResult Edit(Exercise exerciseObject)
        {
            var fetchedData = dbObject.Exercises.Where(x => x.Id == exerciseObject.Id).FirstOrDefault();

            if(fetchedData != null)
            {
                fetchedData.Name = exerciseObject.Name;
                fetchedData.Email = exerciseObject.Email;
                fetchedData.Gender = exerciseObject.Gender;
                fetchedData.Division = exerciseObject.Division;
                fetchedData.City = exerciseObject.City;
                
            }
            dbObject.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var deletedRecord = dbObject.Exercises.Where((x)=> x.Id == id).FirstOrDefault();
            dbObject.Exercises.Remove(deletedRecord);
            dbObject.SaveChanges();

            return View("Index");
        }
        
    }
}