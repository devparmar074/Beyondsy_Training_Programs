using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1_DB_Crud_Day14.Models;

namespace Task1_DB_Crud_Day14.Controllers
{
    public class EmployeeController : Controller
    {
        PracticeEntities5 dbObject = new PracticeEntities5();

        bool isEmployeeCreate;

        bool flag;

        public ActionResult Index()
         {
              if(isEmployeeCreate == true)
            {
                ViewBag.created = "Employee Created Successfully...";
                
            }

              if(flag == true)
            {
                ViewData["msg"] = "Employee Created...";
            }
              
                var list = dbObject.Employees.ToList();
                return View(list);            
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee st)
        {
            dbObject.Employees.Add(st);
            
            isEmployeeCreate = true;
            flag = true;

            dbObject.SaveChanges();
                        
            return RedirectToAction("Index");
            
        }
        

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = dbObject.Employees.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var data = dbObject.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();

            if (data != null)
            {
                data.Name = emp.Name;
                data.Email = emp.Email;
                data.Gender = emp.Gender;
                data.Age = emp.Age;
                data.Designation = emp.Designation;
                data.Salary = emp.Salary;
                data.Contact = emp.Contact;
              //  data.standard = emp.standard;
                dbObject.SaveChanges();
               // ViewData["updated"] = "Student Data Updated.";
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = dbObject.Employees.Where(x => x.Id == id).FirstOrDefault();

            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = dbObject.Employees.Where(x => x.Id == id).FirstOrDefault();
            dbObject.Employees.Remove(data);
            dbObject.SaveChanges();
            // ViewBag.Message("Student Deleted SuccessFully...");
            //ViewData["Deleted"] = "Student Deleted Successfully.";

            return RedirectToAction("Index");
        }
    }
}