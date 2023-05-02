using BarberShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberShopSystem.Controllers
{
    public class UserController : Controller
    {
        // BarberShop Entity Object Created.
        BarberShopEntities2 dbObject = new BarberShopEntities2();


        [HttpGet]
        public ActionResult ChooseUser()
        {
            List<UserTypes2> userTypeList = dbObject.UserTypes2.ToList();
            ViewBag.userTypeList = new SelectList(userTypeList, "UserTypeId", "UserType");

            return View();
        }


        [HttpPost]
        public ActionResult ChooseUser(UserTypes2 usertype)
        {
            /* var type = usertype.UserTypeId;*/

            if (usertype.UserTypeId == 1)
            {
                return  RedirectToAction("ShopRegistration");
            }
            else if(usertype.UserTypeId == 2)
            {
                return RedirectToAction("Registration");
            }
            else
            {
                return RedirectToAction("Errorpage");
            }           
        }



        /// <summary>
        ///        Customers CRUD
        /// </summary>
        

        [HttpGet]
        public ActionResult Registration()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User userObject)
        {
            dbObject.Users.Add(userObject);
            userObject.CreatedDate = DateTime.Now;
            
            dbObject.SaveChanges();

            return View("Profile");
        }

        [HttpGet]
        public ActionResult Profile()
        {
            List<User> usersData = dbObject.Users.ToList();
            return View(usersData);
        }

        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var userRecord = dbObject.BarberShops.Where(x => x.UserId == id).FirstOrDefault();
            return View(userRecord);
        }

        [HttpPost]
        public ActionResult UpdateProfile(User userObject)
        {
            var userRecord = dbObject.Users.Where(x => x.UserId == userObject.UserId).FirstOrDefault();

            if(userRecord != null)
            {
                userRecord.Name = userObject.Name;
                userRecord.Email = userObject.Email;
               // userRecord.Password = userObject.Password;
               userRecord.MobileNumber = userObject.MobileNumber;
                userRecord.Gender = userObject.Gender;
                userRecord.Birthdate = userObject.Birthdate;


                dbObject.SaveChanges();
            }

            return RedirectToAction("Profile");
        }

        [HttpDelete]
       


        /// <summary>
        ///         BarberShop CRUD
        /// </summary>


        [HttpGet]
        public ActionResult ShopRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShopRegistration(BarberShop barbershopObject)
        {
            dbObject.BarberShops.Add(barbershopObject);
            dbObject.SaveChanges();
            return RedirectToAction("ShopProfile");
        }

        [HttpGet]
        public ActionResult ShopProfile()
        {
            List<BarberShop> barbershopList = new List<BarberShop>();
            return View(barbershopList);
        }

        [HttpGet]
        public ActionResult UpdateShopProfile(int id)
        {
            var barbershopRecord = dbObject.BarberShops.Where(x => x.ShopId == id).FirstOrDefault();
            return View(barbershopRecord);
        }

        [HttpPost]
        public ActionResult UpdateShopProfile(BarberShop barbershopObject)
        {
            var barbershopRecord = dbObject.BarberShops.Where(x => x.ShopId == barbershopObject.ShopId).FirstOrDefault();

            if(barbershopRecord != null)
            {
                barbershopRecord.Name = barbershopObject.Name;
                barbershopRecord.Address = barbershopObject.Address;
                barbershopRecord.City = barbershopObject.City;
                barbershopRecord.OpenTime = barbershopObject.OpenTime;
                barbershopRecord.CloseTime = barbershopObject.CloseTime;

                dbObject.SaveChanges();
            }

            return View("ShopProfile");
        }

        [HttpDelete]
        public ActionResult DeleteShopData(int id)
        {
            var barbershopRecord = dbObject.BarberShops.Where(x => x.ShopId==id).FirstOrDefault();
            dbObject.BarberShops.Remove(barbershopRecord);
            dbObject.SaveChanges();
            return View("ShoProfile");
        }


    }
}