﻿using Microsoft.Ajax.Utilities;
using SessionPracice.Filters;
using SessionPracice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace SessionPracice.Controllers
{
    /*[SessionState(SessionStateBehavior.Required)]*/

    
    public class HomeController : Controller
    {
        PracticeEntities2 dbObject = new PracticeEntities2();


        [CustomAuthenticationFilter]
        public ActionResult Index()
        {
           /* if (Session["Username"] == null)
            {
                return RedirectToAction("Login");   
            }

            else
            {*/
                List<Student> studentData = dbObject.Students.ToList();
                return View(studentData);
            //}            
        }

        

        [HttpGet]
        
        public ActionResult Login()
        {
           
           
            return View();
        }

        [HttpPost]
       
        public ActionResult Login(User userObject)
        {
            /*var Username = dbObject.Users.Where(model => model.UserName == userObject.UserName).FirstOrDefault();
            var password = dbObject.Users.Where(model => model.Password == userObject.Password).FirstOrDefault();*/
            var credentials = dbObject.Users.Where(model => model.UserName == userObject.UserName && model.Password == userObject.Password).FirstOrDefault();


            if (ModelState.IsValid)

            {
                if(credentials != null)
                {
                    Session["Username"] = credentials.UserName;
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid.");   
                    return View(userObject);
                }
            }
            else
            {
                return View(userObject);
            }




           /* if (credentials == null)
            {
                return View();
            }
            else
            {
                Session["Username"] = userObject.UserName;
                return RedirectToAction("Index");
            }*/

           /* if (!ModelState.IsValid)
            {
                return View(userObject);
            }
            else
            {
                Session["Username"] = ;
                return RedirectToAction("Index");
            } */

        }

        public ActionResult Error()
        {
            ViewBag.Error = "Please Provide Username and Password.";
            return View();
        }


        [CustomAuthenticationFilter]
        [HttpGet]
        public ActionResult Create()
        {
           /* if (Session["Username"] == null)
            {
                return RedirectToAction("Login");
            }

            else
            {*/
                return View();
           // }

                // ->   1st Method DropDown with Enumerable

                /* List<GenderTable> genderList = dbObject.GenderTables.ToList();
                 ViewBag.genderList = new SelectList(genderList, "GenderId", "GenderType");

                List<StandardTable> listOfStandard = dbObject.StandardTables.ToList();
                ViewBag.listOfStandard = new SelectList(listOfStandard, "StandardId", "Standard");
             --------------------------------------------------------------------------------------------
                 */


                // ->   2nd Method of DropDown : 
                // List<GenderTable> genderList = new List<GenderTable>();


                // List<GenderTable> genderList = dbObject.GenderTables.ToList();
                /*var genderList = dbObject.GenderTables.ToList();
                if (genderList != null)
                {
                    ViewBag.genderList = genderList;
                }*/

                // List<GenderTable> standardList = dbObject.GenderTables.ToList();
                /*var standardList = dbObject.StandardTables.ToList();
                if (standardList != null)
                {
                    ViewBag.standardList = standardList;
                }*/


               
        }

      
        [HttpPost]
        public ActionResult Create(Student studentObject)
        {
           /* if (Session["Username"] == null)
            {
                return RedirectToAction("Login");
            }

            else
            {*/
                dbObject.Students.Add(studentObject);

                dbObject.SaveChanges();
                //int rowOfData = dbObject.SaveChanges();

                /* if(rowOfData > 0)
                 {
                     TempData["Created"] = "<script>alert('Student Data Inserted Successfully.')</script>";
                  }*/

                return RedirectToAction("Index");
            //} 
        }

        [CustomAuthenticationFilter]
        [HttpGet]
        public ActionResult Edit(int id)
        {

            /*if (Session["Username"] == null)
            {
                return RedirectToAction("Login");
            }

            else
            {*/
                var data = dbObject.Students.Where(x => x.Id == id).FirstOrDefault();

                return View(data);
           // }

                // ->   1st Method DropDown with Enumerable : 
                /* List<GenderTable> genderList = dbObject.GenderTables.ToList();
                 ViewBag.genderList = new SelectList(genderList, "GenderId", "GenderType");

                // ->   2nd Method of DropDown : 
                 List<StandardTable> listOfStandard = dbObject.StandardTables.ToList();
                 ViewBag.listOfStandard = new SelectList(listOfStandard, "StandardId", "Standard");*/

                // List<GenderTable> genderList = dbObject.GenderTables.ToList();
                /*var genderList = dbObject.GenderTables.ToList();
                if (genderList != null)
                {
                    ViewBag.genderList = genderList;
                }

                // List<GenderTable> standardList = dbObject.GenderTables.ToList();
                var standardList = dbObject.StandardTables.ToList();
                if (standardList != null)
                {
                    ViewBag.standardList = standardList;
                }*/

               
        }

        [HttpPost]
        public ActionResult Edit(Student studentObject)
        {
            var data = dbObject.Students.Where(x => x.Id == studentObject.Id).FirstOrDefault();

            if (data != null)
            { 
                data.Name = studentObject.Name;
                data.Email = studentObject.Email;
                // data.Gender = studentObject.Gender;
              //  data.GenderId = studentObject.GenderId;

                data.Division = studentObject.Division;
                data.City = studentObject.City;
              //  data.StandardId = studentObject.StandardId;

                data.Contact = studentObject.Contact;

                dbObject.SaveChanges();
            }

            return RedirectToAction("Index");
        }

       [CustomAuthenticationFilter]
        [HttpGet]
        public ActionResult Details(int id)
        {
            var recordById = dbObject.Students.Where(x => x.Id == id).FirstOrDefault();
            return View(recordById);
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