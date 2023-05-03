using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarberShopSystem.Models.ViewModel
{
    public class UserReg
    {
        [Key]
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public Nullable<bool> IsMobileVerified { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

        ////////////////////////////////////////////////////////////

   
        public int ShopId { get; set; }
        
        public Nullable<System.DateTime> OpenTime { get; set; }
        public Nullable<System.DateTime> CloseTime { get; set; }
        public Nullable<bool> Status { get; set; }
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopCity { get; set; }
        public string ShopPassword { get; set; }


    }

    


}