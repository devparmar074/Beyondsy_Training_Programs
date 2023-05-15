using BarberShopSystem.Filters;
using BarberShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberShopSystem.Controllers
{
    public class BookingController : Controller
    {
        BarberShopEntities3 dbObject = new BarberShopEntities3();

        /*[CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult Addbooking(int id, int uid,Booking bookingObject )
        {
            bookingObject.ShopId = id;
            bookingObject.UserId = uid;

            List<BarberShopService> serviceList = dbObject.BarberShopServices.Where(x => x.ShopId == id).ToList();
          // var serviceList1 = dbObject.BarberShopServices.Where(x => x.ShopId == id).FirstOrDefault();


            //dbObject.BarberShopServices.ToList();
            ViewBag.serviceList = new SelectList(serviceList, "ShopId", "ServiceName");

            List<HairStylist> hairStylistList = dbObject.HairStylists.Where(x => x.ShopId == id).ToList();

            ViewBag.hairStylistList = new SelectList(hairStylistList, "HairStylistId", "Name");
                     


            return View("Addbooking",bookingObject);
        }

     
        [HttpPost]
        public ActionResult Addbooking(Booking bookingObject)
        {
           if(bookingObject == null)
            {
                return RedirectToAction("Error");
               
            }
           else
            {
                bookingObject.CreatedTime = DateTime.Now;
                dbObject.Bookings.Add(bookingObject);
                dbObject.SaveChanges();
                //  TempData["ShopId"] = bookingObject.ShopId;

                return RedirectToAction("GetBookingById", bookingObject);
            }
             
            
        }

       /* [CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult GetBookingById(int id, int uid)
        {
          /*  bookingObject.ShopId = id;
            bookingObject.UserId = uid;*/

            List<Booking> bookings = dbObject.Bookings.Where(x => x.BookingId == id).ToList();

            return View(bookings);
        }

        /*[CustomAuthenticationFilter]*/
        [HttpGet]
        public ActionResult ConfirmBooking(int id)
        {
           // bookingObject.UserId = uid;

            List<Booking> bookings = dbObject.Bookings.Where(x => x.BookingId == id).ToList();
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public ActionResult ConfirmBooking()
        {
           // List<Booking> bookings = dbObject.Bookings.Where(x => x.BookingId == id).ToList();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Error()
        {
            ViewBag.Error = "Error Page";
            return View();
        }


    }
}