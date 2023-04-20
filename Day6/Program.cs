using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {

        static void Main(string[] args)
        {
            // Object Creation : 
            Array object1 = new Array();

            Switch_Examples object2 = new Switch_Examples();

              int[] sample = {5,9,2,7,6,3};
            



            Console.WriteLine("Enter Program number : ");
            int program = int.Parse(Console.ReadLine());

            bool exit = true;

            while(exit)
            {
                switch (program)
                {
                    case 1:
                        object1.getArraylength();
                        break;

                    case 2:
                        object2.check_vowel();
                        break;

                    case 3:
                        object2.isEven_odd();
                        break;

                    case 4:
                        object1.min_max_in_array();
                        break;

                    case 5:
                        object1._2D_to_1D();
                        break;

                    case 6:
                        object1.print_negative_numbers();
                        break;

                    case 7:
                        Console.WriteLine(object1.print_Sum());
                        break;

                    case 8:
                        object1.count_odd_even_Numbers();
                        break;

                    case 9:
                        object1.add_element();
                        break;

                    case 10:
                        object1.add_element_arrayList();
                        
                        break;

                    case 11: 
                        object1.print_unique_element();
                        break;

                    case 12:
                        object1.sort_Array(sample);
                        break;

                    case -1:
                        exit = false;
                        break;


                    default:
                        Console.WriteLine("INVALID Input");
                        break;
                }
                Console.ReadLine();
            }

                     
        }
    }
}
