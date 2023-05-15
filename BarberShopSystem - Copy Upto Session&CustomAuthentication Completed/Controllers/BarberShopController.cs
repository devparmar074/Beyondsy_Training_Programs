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