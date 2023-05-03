using BarberShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberShopSystem.Controllers
{
    public class HairStylistController : Controller
    {
        BarberShopEntities2 dbObject = new BarberShopEntities2();


        public ActionResult GetHairStylists()
        {
            List<HairStylist> hairStylistsList = dbObject.HairStylists.ToList();
            return View(hairStylistsList);
        }

        [HttpGet]
        public ActionResult AddHairStylist()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHairStylist(HairStylist hairstylistObject)
        {
            dbObject.HairStylists.Add(hairstylistObject);
            dbObject.SaveChanges();
            return RedirectToAction("GetHairStylists");
        }

        [HttpGet]
        public ActionResult UpdateHairStylist(int id)
        {
            var hairStylistRecord = dbObject.HairStylists.Where(x=> x.HairStylistId == id).FirstOrDefault();
            return View(hairStylistRecord);
        }

        [HttpPost]
        public ActionResult UpdateHairStylist(HairStylist hairstylistObject)
        {
            var hairStylistRecord = dbObject.HairStylists.Where(x => x.HairStylistId == hairstylistObject.HairStylistId).FirstOrDefault();
            
            if(hairStylistRecord != null)
            {
                hairStylistRecord.Name = hairstylistObject.Name;
                hairStylistRecord.Email = hairstylistObject.Email;
                hairStylistRecord.MobileNumber = hairstylistObject.MobileNumber;
                hairStylistRecord.City = hairstylistObject.City;
                hairStylistRecord.Experience = hairstylistObject.Experience;

                dbObject.SaveChanges();
            }

            return RedirectToAction("GetHairStylists");
        }

    }
}