using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentManagementSystemEntities1 dbObject = new StudentManagementSystemEntities1();


        public ActionResult Index()
        {
            List<Student> studentData = dbObject.Students.ToList();
            return View(studentData);
        }

        [HttpGet]
        public ActionResult Create()
        {
            List<GenderTable> genderList = dbObject.GenderTables.ToList();
            ViewBag.genderList = new SelectList(genderList, "GenderId", "GenderType");


            List<StandardTable> listOfStandard = dbObject.StandardTables.ToList();
            ViewBag.listOfStandard = new SelectList(listOfStandard, "StandardId", "Standard");

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student studentObject)
        {
            dbObject.Students.Add(studentObject);
            int rowOfData = dbObject.SaveChanges();
            
            if(rowOfData > 0)
            {
                TempData["Created"] = "<script>alert('Student Data Inserted Successfully.')</script>";
             }

            return RedirectToAction("Index");
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

            if(data != null)
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

        [HttpGet]
        public ActionResult Details(int id)
        {
            var recordById = dbObject.Students.Where(x => x.Id == id).FirstOrDefault(); 
            return View(recordById);
        }


    
        public ActionResult Delete(int id)
        {
            var data = dbObject.Students.Where(x=> x.Id ==id).FirstOrDefault();

            dbObject.Students.Remove(data);
            dbObject.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}