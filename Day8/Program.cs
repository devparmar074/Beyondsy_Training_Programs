using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Object Creation : 
                Arrays object1 = new Arrays();

            function_Example function_object = new function_Example();

            Strings_Examples string_object = new Strings_Examples();




            Console.WriteLine("Enter Program number : ");
            int program = int.Parse(Console.ReadLine());

            switch (program)
            {
                case 1:
                    object1.delete_duplicate();
                    break;

                case 80:
                    function_object.Example_1("dev");
                    break;

                case 81:
                    int num1, num2;

                    Console.WriteLine("enter num 1:");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter num 2:");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("the Addition of two number is : \n");
                    Console.WriteLine(function_object.Example_2(num1, num2));
                        
                    break;


                case 82:
                    Console.WriteLine("Enter String");
                    string str = Console.ReadLine();

                    Console.WriteLine( function_object.Example_3(str));

                    break;


                case 83:
                    Console.WriteLine("Enter number : ");
                    int number = int.Parse(Console.ReadLine());

                    function_object.Example_4(number);

                    break;


                case 84:
                    Console.WriteLine("Enter number : ");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine(function_object.Example_5(num));
                    break;


                case 85:
                    Console.WriteLine("Enter number : ");
                    int digit = int.Parse(Console.ReadLine());

                    function_object.Example_6(digit);
                    break;

                case 86:
                    Console.WriteLine("Enter number : ");
                    int fibonacci_input = int.Parse(Console.ReadLine());

                    Console.WriteLine(function_object.Example_7(fibonacci_input)); 
                    break;


                case 87:
                    int input1, input2;

                    Console.WriteLine("enter num 1:");
                    input1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter num 2:");
                    input2 = int.Parse(Console.ReadLine());

                    function_object.Example_8(input1,input2);
                    break;


                case 88:
                    Console.WriteLine("Enter number : ");
                    int factorial_input = int.Parse(Console.ReadLine());

                    Console.WriteLine( function_object.Example_9(factorial_input));
                    break;

                case 89:
                    Console.WriteLine("Enter number : ");
                    int binary_input = int.Parse(Console.ReadLine());

                    Console.WriteLine(function_object.Example_10(binary_input) );
                    break;

                case 90:

                    break;


                case 91:
                    string_object.Example_1("dev");
                    break;

                case 92:
                    string_object.Example_2("Hello Good Morning!!!!");
                    break;

                case 93:                                   

                    Console.WriteLine(string_object.Example_3()); 
                    break;

                case 94:

                    string_object.Example_4();
                    break;
            }


        }

    }
}
