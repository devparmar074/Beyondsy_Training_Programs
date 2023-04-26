using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MainCrud.models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter ID.")]
       // [StringLength(10) ]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        //[StringLength(50)]
        public string Name{ get; set; }

        [Required(ErrorMessage = "Please Select Gender.")]
        public GenderList Gender  { get; set; }

        [Required(ErrorMessage = "Please Enter standard 1-12.")]
        [Range (1, 12)]


       // Without DropDownList
        public int Standard { get; set; }
       // public List<int> Standard { get; set; }

        [Required(ErrorMessage = "Please Enter Standard.")]
        public char Division { get; set; }

        [Required]
        [StringLength (10)]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Enter City.")]
       // [StringLength(15)]
        public string City { get; set; }


    }

    public enum GenderList
    {
        Male,
        Female,
        Other
    }
}