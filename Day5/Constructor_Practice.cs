using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Constructor_Practice
    {

        private static string Name;
        private static string City;

        

        public Constructor_Practice()
        {
            Name = Console.ReadLine();
            City = Console.ReadLine();

            Console.WriteLine("from Default Constructor : ");
            Console.WriteLine("Hello, " + Name + " you are from " + City);
        }



        public Constructor_Practice(string name , string city)
        {
            Name = name;
            City = city;
            Console.WriteLine("from Parameterized Constructor : ");
            Console.WriteLine("Hello, " + name + " you are from " + city);
        }


                
    }
}
