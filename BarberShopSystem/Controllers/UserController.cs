using BarberShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberShopSystem.Controllers
{
   /* public class ViewModel
    {
        public IEnumerable<BarberShop> BarberShop { get; set; }
        public IEnumerable<User> User { get; set; }
    }*/


    public class UserController : Controller
    {
        // BarberShop Entity Object Created.
        BarberShopEntities2 dbObject = new BarberShopEntities2();
                


        [HttpGet]
        public ActionResult ChooseUser()
        {
            // Dynamic model way to use multiple model in one VIew.
           /* dynamic mymodel = new ExpandoObject();
            mymodel.Users = dbObject.Users.ToList();
            mymodel.BarberShop = dbObject.BarberShops.ToList();
            */


            List<UserTypes2> userTypeList = dbObject.UserTypes2.ToList();
            ViewBag.userTypeList = new SelectList(userTypeList, "UserTypeId", "UserType");

           // return View(mymodel);
            return View();
        }


        [HttpPost]
        public ActionResult ChooseUser(UserTypes2 usertype)
        {
           

            /* var type = usertype.UserTypeId;*/

            /*if (usertype.UserTypeId == 1)
            {
                return RedirectToAction("ShopRegistration");
            }
            else if (usertype.UserTypeId == 2)
            {
                return RedirectToAction("Registration");
            }
            else
            {
                return RedirectToAction("Errorpage");
            }*/
            return View();
        }



        /// <summary>
        ///        Customers CRUD
        /// </summary>
        /// 



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
            List<BarberShop> barbershopList = dbObject.BarberShops.ToList();
            ViewBag.barbershopList = barbershopList;
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

            if (barbershopRecord != null)
            {
                barbershopRecord.ShopName = barbershopObject.ShopName;
                barbershopRecord.ShopAddress = barbershopObject.ShopAddress;
                barbershopRecord.ShopCity = barbershopObject.ShopCity;
                barbershopRecord.OpenTime = barbershopObject.OpenTime;
                barbershopRecord.CloseTime = barbershopObject.CloseTime;

                dbObject.SaveChanges();
            }

            return View("ShopProfile");
        }

        [HttpDelete]
        public ActionResult DeleteShopData(int id)
        {
            var barbershopRecord = dbObject.BarberShops.Where(x => x.ShopId == id).FirstOrDefault();
            dbObject.BarberShops.Remove(barbershopRecord);
            dbObject.SaveChanges();
            return View("ShoProfile");
        }


        
        public ActionResult GetHairStylist()
        {
            List<HairStylist> listOfhairStylist = dbObject.HairStylists.ToList();

            return View(listOfhairStylist);
        }



        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User userObject)
        {
            dbObject.Users.Add(userObject);
            //userObject.CreatedDate = DateTime.Now;

            dbObject.SaveChanges();

            return View("Profile");
        }

        [HttpGet]
        public ActionResult Profile()
        {
            List<User> usersData = dbObject.Users.ToList();
            ViewBag.Profile = usersData;
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

            if (userRecord != null)
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

        



        /// <summary>
        ///         BarberShop CRUD
        /// </summary>








    
    }
}