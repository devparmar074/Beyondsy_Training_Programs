using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class MyException : Exception 
    {
        public void numbers_only()
        {
            Console.WriteLine("Please Enter Numbers Only Between 1 and 2.");
        }

        public void string_only()
        {

            /*foreach (char c in str)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;*/
            Console.WriteLine("You have Entered incorrect String.\n" + "Please Enter Correct String.");
        }

        public void divide_by_zero()
        {
            Console.WriteLine("You can not divide any number by zero.");
        }

        
        
    }
}
