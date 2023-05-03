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
    
    public partial class HairStylist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HairStylist()
        {
            this.Bookings = new HashSet<Booking>();
            this.Haircuts = new HashSet<Haircut>();
        }
    
        public int HairStylistId { get; set; }
        public int ShopId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public Nullable<int> Experience { get; set; }
        public string MobileNumber { get; set; }
    
        public virtual BarberShop BarberShop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Haircut> Haircuts { get; set; }
    }
}
