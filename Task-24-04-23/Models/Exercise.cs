//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_24_04_23.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Exercise
    {
        [Required(ErrorMessage = "Please Enter ID.")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Name.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Email.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Gender.")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Please Enter Division.")]
        [StringLength(1)]
        public string Division { get; set; }


        [Required(ErrorMessage = "Please Enter Division.")]
        [StringLength(10)]
        public string City { get; set; }
    }
}