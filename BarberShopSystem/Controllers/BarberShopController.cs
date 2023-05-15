using BarberShopSystem.Filters;
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
        BarberShopEntities3 dbObject = new BarberShopEntities3();

        /*[CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult AddService()
        {   
           
            return View();
        }

            
        [HttpPost]
        public ActionResult AddService(BarberShopService barbershopserviceObject,int id)
        {            
            barbershopserviceObject.ShopId = id;

            dbObject.BarberShopServices.Add(barbershopserviceObject);
            dbObject.SaveChanges();

            return RedirectToAction("ShopProfile", "User");
        }

        [CustomAuthenticationFilter]
        [HttpGet]
        public ActionResult GetServices()
        {
            List<BarberShopService> serviceList = dbObject.BarberShopServices.ToList();

            return View(serviceList);
        }

        [CustomAuthenticationFilter]
        [HttpGet]
        public ActionResult GetServiceByShopId(int id)
        {

            List<BarberShopService> serviceList = dbObject.BarberShopServices.Where(x => x.ShopId == id).ToList();

            //var hairStylistsListByShopId = hairStylistsList.FindAll(x => x.ShopId == id).FirstOrDefault();

            // var hairStylist = dbObject.HairStylists.FirstOrDefault(x => x.ShopId == id);

            // var hairStylistsList = dbObject.HairStylists.Where(x => x.ShopId == id ).FirstOrDefault();

            return View(serviceList);
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var serviceRecord = dbObject.BarberShopServices.Where(x => x.ServiceId == id).FirstOrDefault();

            return View(serviceRecord);
        }

        [HttpPost]
        public ActionResult UpdateService(BarberShopService barberShopServiceObject)
        {
            var serviceRecord = dbObject.BarberShopServices.Where(x => x.ServiceId == barberShopServiceObject.ServiceId).FirstOrDefault();

            if (serviceRecord != null)
            {
               
                barberShopServiceObject.ServiceName = serviceRecord.ServiceName;
                barberShopServiceObject.ServicePrice = serviceRecord.ServicePrice;
            }
            return RedirectToAction("GetServiceByShopId");
        }

        [HttpDelete]
        public ActionResult DeleteService(int id)
        {
            var serviceRecord = dbObject.BarberShopServices.Where((x) => x.ServiceId == id).FirstOrDefault();
            dbObject.BarberShopServices.Remove(serviceRecord);
            dbObject.SaveChanges();
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