//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShopSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int BookingId { get; set; }
        public int ShopId { get; set; }
        public int UserId { get; set; }
        public string DiscountCouponId { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<int> TransactionId { get; set; }
        public Nullable<bool> PaymentStatus { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ServiceId { get; set; }
    
        public virtual BarberShop BarberShop { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual User User { get; set; }
    }
}
