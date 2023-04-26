using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2_21stApril23.Model;


namespace Task2_21stApril23.Controllers
{
    public class StudentController : Controller
    {
        // Object created.
        PracticeEntities2 dbObject = new PracticeEntities2();


        // GET: Student
        public ActionResult Index()
        {
            List<Student> listOfStudents = dbObject.Students.ToList();
            return View(listOfStudents);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<GenderTable> genderList = dbObject.GenderTables.ToList();
            ViewBag.genderList = new SelectList(genderList, "GenderId", "GenderType");



            List<StandardTable> listOfStandard = dbObject.StandardTables.ToList();
            ViewBag.listOfStandard = new SelectList(listOfStandard, "StandardId", "Standard");

            /*var listOfStandard = dbObject.StandardTables.ToList();
            ViewBag.listOfStandard = new SelectList(listOfStandard);*/


          /*  List<StandardTable> listOfStandard1 = new List<StandardTable>();
            listOfStandard1 = dbObject.StandardTables.ToList();
            ViewBag.listOfStandard = new SelectList(listOfStandard1, "GenderId", "GenderType");*/

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student studentObject)
        {
            // for selecting and store gender :
            //var gender = dbObject.GenderTables.ToString();

            /*var selectedvalue = dbObject.GenderTables.ToString();
            ViewBag.GenderType = selectedvalue.ToString();*/
            ///////////////////////////////////////////////////////////////////////

            
            //studentObject.Gender = SelectListItem("Standard");
            

            /////////////////////////////////////////////////////////////////////////////////////
            ///
            //    ViewBag.enderList = dbObject.GenderTables.Select(x => new SelectListItem { Text = x.GenderType, Value = x.GenderId.ToString() }).ToList();


            //////////////////////////////////////////////////////////////////////////
            ///


            /*-----------------------------------------------------------------------------------------------*/

            // for Standard : 
            /* var listOfStandard = dbObject.StandardTables.ToList();
             ViewBag.listOfStandard = new SelectList(listOfStandard);


             List<StandardTable> listOfStandard1 = new List<StandardTable>();
             listOfStandard1 = dbObject.StandardTables.ToList();
         ViewBag.listOfStandard = new SelectList(listOfStandard1, "GenderId", "GenderType");*/

            dbObject.Students.Add(studentObject);
            dbObject.SaveChanges();
          
          return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var data = dbObject.Students.Where(x => x.Id == id).FirstOrDefault();

            return View(data);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = dbObject.Students.Where(x => x.Id == id).FirstOrDefault();
            List<GenderTable> genderList = dbObject.GenderTables.ToList();
            ViewBag.genderList = new SelectList(genderList, "GenderId", "GenderType");


            List<StandardTable> listOfStandard = dbObject.StandardTables.ToList();
            ViewBag.listOfStandard = new SelectList(listOfStandard, "StandardId", "Standard");
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Student studentObject)
        {
            var data = dbObject.Students.Where(x => x.Id == studentObject.Id).FirstOrDefault();
                
            if (data != null)
            {
                data.Name = studentObject.Name;
                data.Email = studentObject.Email;

                
                data.GenderId = studentObject.GenderId;


                data.Division = studentObject.Division;
                data.City = studentObject.City;
               data.StandardId = studentObject.StandardId;  
                data.Contact = studentObject.Contact;
                
                dbObject.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var data = dbObject.Students.Where(x => x.Id == id).FirstOrDefault();
            dbObject.Students.Remove(data);
            dbObject.SaveChanges();            
            return RedirectToAction("Index");
        }



    }
}