using Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Day3
{
    class Program
    {

        static void Main(string[] args)
        {
            // Constructor_Practice c1 = new Constructor_Practice();

            // Constructor_Practice c2 = new Constructor_Practice("Dev","Junagadh");

            // Constructor_Practice();
            //c2 = new Constructor_Practice();

            //Bus Ahmd_to_jnd = new Bus();



            //   Static_Constructor s1 = new Static_Constructor();

           /* Display_bus obj1 = new Display_bus(" ");
            Console.ReadLine();*/




            DateTime current = DateTime.Now;

            DateTime bus1 = new DateTime(2023, 04, 02);
            DateTime bus2 = new DateTime(2023, 03, 20);

           
                if (bus1 > current)
                {
                    Console.WriteLine("Next Bus Available at : " +bus1);
                }

                else
                {
                    Console.WriteLine("there is no bus!!!");
                }

            Console.WriteLine("--------------------------------------");

            if (bus2 > current)
            {
                Console.WriteLine("Next Bus Available at : " + bus1);
            }

            else
            {
                Console.WriteLine("there is no bus!!!");
            }



            ////////////////////////////////////////////
            ///

          /*  ---------Static Constructor:
            -called only once.

    -called before default contructor.

    - used to initialize static variables in class.
	-used to perfrom 1 time action only once.

---------Private Constructor:
	-use for today only application.
	-use for restrict class.

---------Static Class:
	-use for when we want to fix our data.



---------Constructors:
	-use for open DB Connection.


---------Construction in Inheritance:*/
	-



        }
    }
}