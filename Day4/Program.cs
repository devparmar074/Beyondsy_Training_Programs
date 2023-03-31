using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

            Switch_Case_Examples obj1 = new Switch_Case_Examples();
            Calculator c1 = new Calculator();

            Console.WriteLine("Enter Program Number");
            int programs = Convert.ToInt32(Console.ReadLine());


            switch (programs)
            {
                case 1:
                    obj1.print_days_in_month();
                    break;

                case 2:
                    c1.Calculation();
                    break;


                default:
                    Console.WriteLine("INVALID");
                    break;

                    obj1.print_days_in_month();
            }
            Console.ReadLine();
        }
    }
}
