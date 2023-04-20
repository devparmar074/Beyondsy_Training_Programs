using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MainCrud.models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public GenderList Gender  { get; set; }

    }

    public enum GenderList
    {
        Male,
        Female,
        Other
    }
}