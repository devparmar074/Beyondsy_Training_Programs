using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarberShopSystem.Models.ViewModel
{
    public class BarberShopAndBarberService
    {
        BarberShopEntities3 dbObject = new BarberShopEntities3();

        List<BarberShop> barberShopList = new List<BarberShop>();

        List<BarberShopService> barberShopServiceList = new List<BarberShopService>();

        List<HairStylist> hairStylistList = new List<HairStylist>();    


        [Key]
       
        public int ShopId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> OpenTime { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public Nullable<bool> Status { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopCity { get; set; }
        public string ShopPassword { get; set; }
        public string ShopKey { get; set; }


       /* [Key]*/
       /* public int ShopId { get; set; }*/
        public string ServiceName { get; set; }
        public string ServicePrice { get; set; }

    }
}