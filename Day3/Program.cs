using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {

        static void Main(string[] args)
        {

            loops obj1 = new loops();
            
            Console.WriteLine("Enter Program Number");
            int programs = Convert.ToInt32(Console.ReadLine());

           
                switch (programs)
                {
                    case 32:
                        obj1.check_Triangle();
                        break;

                    case 33:
                        obj1.print_Alphabets();
                        break;

                    case 34:
                        obj1.print_ASCII();
                        break;

                    case 35:
                        obj1.multiplication_table();
                        break;

                    case 36:
                        obj1.reverse_Natural_numbers();
                        break;

                    case 37:
                        Console.WriteLine(obj1.sum_of_digits());
                        break;

                    case 38:
                        Console.WriteLine(obj1.sum_of_even_numbers());
                        break;

                    case 39:
                        Console.WriteLine(obj1.sum_of_Odd_numbers());
                        break;

                    case 40:
                        obj1.swap_first_last_number();
                        break;

                    case 41:
                        Console.WriteLine(obj1.sum_of_swap_numbers());
                        break;

                    case 42:
                        obj1.find_first_last_digit();
                        break;

                    case 43:
                        Console.WriteLine(obj1.get_Product());
                        break;

                    case 44:
                        Console.WriteLine(obj1.reverse_digit());
                        break;

                    case 45:
                        Console.WriteLine(obj1.getPower());
                        break;

                    case 46:
                        Console.WriteLine(obj1.find_factorial());
                        break;

                    case 47:
                        obj1.check_Armstrong_number();
                        break;

                    case 48:
                        Console.WriteLine(obj1.number_of_Armstrong_number());
                        break;

                    case 49:
                        Console.WriteLine(obj1.getCompoundInterest());
                        break;

                    case 50:
                        obj1.isPrime();
                        break;

                    case 51:
                        obj1.ispalindroome();
                        break;

                    case 52:
                        obj1.print_Words_of_Numbers();
                        break;

                    case 53:
                        obj1.Highest_Common_Factor();
                        break;

                    case 54:
                        obj1.Lowest_Common_Factor();
                        break;


                    case -1:
                        break;
                        //exit(0);

                    default:
                        break;



                }

            Console.ReadLine();
        }
    
    }
}
