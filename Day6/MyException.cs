using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class MyException : Exception
    {
        public void numbers_only()
        {
            Console.WriteLine("Please enter Numbers only.\n");
        }

        public void character_Only()
        {
            Console.WriteLine("Please Enter only Character.\n"+ "Numbers are not allowed.\n");
        }

        public void is_white_space_Entered()
        {
            Console.WriteLine("White Space NOT Allowed.");
        }

        public void string_not_Allowed()
        {
            Console.WriteLine("Only Character is Allowed.\n" + "String is NOT Allowed.\n");
        }

        public void null_is_not_Allowed()
        {
            Console.WriteLine("Null is not Allowed\n"+"Please Provide Valid input. ");
        }

        public void indexoutofbound()
        {
            Console.WriteLine("Array is Full!!!!!!!");
        }
    }
}
