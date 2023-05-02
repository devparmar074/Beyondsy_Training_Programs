using BarberShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberShopSystem.Controllers
{
    public class BarberShopController : Controller
    {
        // Object Created
        BarberShopEntities2 dbObject = new BarberShopEntities2();

                   
        public ActionResult Regstration()
        {
             
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Profile()
        {
            List<BarberShop> barberShopData = new List<BarberShop>();
            return View(barberShopData);
        }

        [HttpGet]
        public ActionResult AddShopData()
        {
            return View();
        }

        [HttpPost]  
        public ActionResult AddShopData(BarberShop barbershopObject)
        {
            dbObject.BarberShops.Add(barbershopObject);
            dbObject.SaveChanges();
            return View("Profile");
        }

        
        public ActionResult HairStylist()
        {


            return View();
        }

        public ActionResult Timeslots()
        {
            return View();
        }

        public ActionResult Bookings()
        {
            return View();
        }

        public ActionResult CancelBooking()
        {
            return View();
        }

    }
}