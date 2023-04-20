using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Task1_Day13.Models
{
    public class Students
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Division")]
        public char Division { get; set; }

        [Display(Name = "Standard")]
        public int Standard { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Stream")]
        public string Stream { get; set; }
        
        //public List<>    

        public Students(Students st)
        {

        }

        public Students(int id, string name, int standard, int age, string city, string stream)
        {
            this.Id = id;
            this.Name = name;
            this.Standard = standard;
            this.Age = age;
            this.City = city;
            this.Stream = stream;
        }

        public Students()
        {

        }
    }

    

}