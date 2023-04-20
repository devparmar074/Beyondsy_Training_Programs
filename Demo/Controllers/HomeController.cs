using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {

        static List<Student> listOfStudents = new List<Student>()
        {
            new Student 
            {
                Id = 1,
                Name = "test",
               
                
            },

            new Student
            {
                Id = 2,
                Name = "test2",
               
            },
            new Student
            {
                Id = 3,
                Name = "test3",
                
            }
        };

public ActionResult Index()
        {
            /// For Dropdown : 
            /*  List<Student> dropdownStudent = listOfStudents.ToList();

              ViewBag.Students = new SelectList(dropdownStudent,"name");*/

            //return View();
            ///
            /* List<SelectListItem> studentList = new List<SelectListItem>()
             {
                 new SelectListItem()
                 {
                     Text = "test1", Value="1",Selected=true
                 },

                 new SelectListItem()
                 {
                     Text = "test2", Value="2",Selected=true
                 },

                 new SelectListItem()
                 {
                     Text = "test3", Value="3",Selected=true
                 }
             };*/

            //  ViewBag.studentListView = studentList;


            //For Display a list of Students.
              var list = listOfStudents.ToList();

              return View(list);

            /* List<Student> listOfStudents = new List<Student>()
            {
                new Student
                   {
                       Id = 1,
                       Name = "test",
                       Gender = "Male"

                   },

                new Student
                   {
                       Id = 2,
                       Name = "test2",
                       Gender = "Female"
                   },
                new Student
                   {
                       Id = 3,
                       Name = "test3",
                       Gender = "Male"
                   }
            };*/


            /*Student student1 = new Student()
            {
                Id = 1,
                Name = "dev",
                Gender = "Male"
            };

            Student student2 = new Student()
            {
                Id = 2,
                Name = "dev",
                Gender = "Male"
            };

            Student student3 = new Student()
            {
                Id = 3,
                Name = "dev",
                Gender = "Male"
            };
*/
            //  return View(listOfStudents);


            ////////////////////////////////////////////////////////////

           /* ViewBag.list = new List<Student>
            {
                new SelectListItem
                {
                    Text = "male"
                }

            };*/

          ///  return View();
        }  

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student obj)
        {            
            listOfStudents.Add(obj);

            return View("Index");                      
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

        public ActionResult About()
        {
            return View();
        }

    }
}