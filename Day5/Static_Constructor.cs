using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Static_Constructor
    {
        private static string name;
        private static string password;

        static Static_Constructor()
        {
            Console.WriteLine("enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("enter passwrod : ");
            password = Console.ReadLine();

            Console.WriteLine("Name : "+ name + "City : "+ password+ "\n");
            Console.WriteLine("You are Logged in at "+DateTime.Now);
        }

        




    }
}
