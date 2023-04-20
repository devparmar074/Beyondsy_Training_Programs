using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Demo
    {
        static void Main()
        {
            // Object creation: 
                example object1 = new example();

            String_Examples string_object = new String_Examples();

            LINQ_Examples LINQ_object = new LINQ_Examples();    


            Console.WriteLine("enter program no : ");
            int program  = int.Parse(Console.ReadLine());

            switch (program)
            {
                case 1: object1.merge_2_sorted_arrays();
                    break;

                case 2:
                    string_object.reverse_string();
                    break;

                case 3:
                    string_object.copy_string();
                    break;

                case 4:
                    string_object.total_number_of_vowel_Consonant();
                    break;

                case 5:
                    string_object.maximum_occuring_char();
                    break;


                case 6:
                    object1.jagged_array();
                    break;

                case 7:
                    LINQ_object.Example_1();
                    break;

                case 8:
                    LINQ_object.Example_2();
                    break;

                case 9:
                    LINQ_object.Example_3();
                    break;

                case 10:
                    object1.average_of_all_element();
                    break;

                case 11:
                    LINQ_object.Example_4();
                    break;


                case 12:
                    LINQ_object.Example_6();
                    break;

                case 13:
                    string_object.Maximum_char_in_string();
                    break;

                case 14:
                    LINQ_object.Example_5();
                    break;
            }
        }
    }
}
