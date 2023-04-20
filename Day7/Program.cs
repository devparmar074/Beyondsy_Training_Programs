using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Program
    {

        static void Main(string[] args)
        {
            Arrays object1 = new Arrays();

            Console.WriteLine(" Enter Program : ");
            int program  = int.Parse(Console.ReadLine());

            switch (program)
            {
                case 1:object1.copy_array_elements();
                    break;

                case 2:object1.get_count_of_each_character();
                    break;

                case 3:object1.reverse_array();
                    break;

                case 4:
                    Console.WriteLine(object1.second_largest_element_in_Array()); 
                    break;

                case 5:
                    Console.WriteLine(object1.total_Duplicate_numbers());
                    break;
            }







            Console.ReadLine();

        }
    }
}










