using BarberShopSystem.Filters;
using BarberShopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberShopSystem.Controllers
{
    public class HomeController : Controller
    {
        BarberShopEntities3 dbObject = new BarberShopEntities3();

       /* [CustomAuthenticationFilter]*/
        public ActionResult Index()
        {
             List<BarberShop> cityList = dbObject.BarberShops.ToList();

            ViewBag.cityList = new SelectList(cityList, "ShopId", "ShopCity");



            List<BarberShop> barberShops = dbObject.BarberShops.ToList();
           
          //  var hairstylistList = dbObject.HairStylists.ToList();
         //   TempData["hairstylistList"] = hairstylistList;
          //  HairStylist hairStylist = new HairStylist();
          //  ViewBag["hairstylist"] = hairStylist.Name;
           

            return View(barberShops);
        }


        /*[CustomAuthenticationFilter]*/
        public ActionResult ShopDetails(int id)
        {
            List<BarberShopService> serviceList = dbObject.BarberShopServices.Where(x => x.ShopId == id).ToList();
            // var serviceList1 = dbObject.BarberShopServices.Where(x => x.ShopId == id).FirstOrDefault();


            //dbObject.BarberShopServices.ToList();
            ViewBag.serviceList = new SelectList(serviceList, "ShopId", "ServiceName");

            List<HairStylist> hairStylistList = dbObject.HairStylists.Where(x => x.ShopId == id).ToList();

            ViewBag.hairStylistList = new SelectList(hairStylistList, "HairStylistId", "Name");


            List<BarberShop> shop = dbObject.BarberShops.Where(x => x.ShopId == id).ToList();

            return View(shop);
        }

        
    }
}