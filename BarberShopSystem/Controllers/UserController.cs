using BarberShopSystem.Filters;
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
         public IEnumerable<n   > User { get; set; }
     }*/

    
    public class UserController : Controller
    {
        // BarberShop Entity Object Created.
        BarberShopEntities3 dbObject = new BarberShopEntities3();
                

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

        public static string GenerateRandomText(int textLength)
        {
            const string Chars = "ABCDEFGHIJKLMNPOQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(Chars, textLength)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
            return result;
        }

      /*  [CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult ShopRegistration()
        {

            return View();
        }

        [HttpPost]
        public ActionResult ShopRegistration(BarberShop barbershopObject)
        {
            var key = GenerateRandomText(10);
            barbershopObject.ShopKey = key;

           /* dbObject.BarberShops.Attach(barbershopObject);*/

            dbObject.BarberShops.Add(barbershopObject);

            dbObject.SaveChanges();
            return RedirectToAction("ShopProfile");
        }

        /*[CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult ShopLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShopLogin(BarberShop barbershopObject)
        {
            var credentials = dbObject.BarberShops.Where(model => model.ShopKey == barbershopObject.ShopKey && model.ShopPassword == barbershopObject.ShopPassword);

            if(credentials == null)
            {
                return View();
            }
            else
            {
                /*Session["ShopKey"] = barbershopObject.ShopKey;*/
                /* Session["Password"] = */
                return RedirectToAction("ShopProfile");
            }

           // return View();
        }


        [CustomAuthenticationFilter]
        [HttpGet]
        public ActionResult ShopProfile()
        {
            /*if (Session["UserModel"] == null)
            {
                return RedirectToAction("ShopLogin");
            }
            else
            {*/
                List<BarberShop> barbershopList = dbObject.BarberShops.ToList();
                ViewBag.barbershopList = barbershopList;
                return View(barbershopList);
            //}
                        
        }


        [CustomAuthenticationFilter]
        [HttpGet]
       
        public ActionResult UpdateShopProfile(int id)
        {
            /*if (Session["ShopKey"] == null)
            {
                return RedirectToAction("ShopLogin");
            }
            else
            {*/
                var barbershopRecord = dbObject.BarberShops.Where(x => x.ShopId == id).FirstOrDefault();
                return View(barbershopRecord);
            //}                            
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


       /* [HttpGet]
        public ActionResult GetHairStylist()
        {
            List<HairStylist> listOfhairStylist = dbObject.HairStylists.ToList();

            return View(listOfhairStylist);
        }*/


        // For a User : 

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
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User userObject)
        {
            var credentials = dbObject.Users.Where(model => model.Email == userObject.Email && model.Password == userObject.Password).FirstOrDefault();

            if (credentials != null)
            {
                Session["UserModel"] = userObject;
                var username = Session["UserModel"];
               
                
                ViewBag.greetings = userObject.Name;
                return RedirectToAction("ShopProfile");
            }

            else
            {
                //  userObject.Password = userObject.Password.Remove(0);

                /* Session["Password"] = */
                return View();
            }
            
            // return View();
        }


      /*  [CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult Profile()
        {
            List<User> usersData = dbObject.Users.ToList();
            ViewBag.Profile = usersData;
            return View(usersData);
        }


        /*[CustomAuthenticationFilter]*/
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