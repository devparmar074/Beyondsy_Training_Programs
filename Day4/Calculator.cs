using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Calculator
    {
        private double num1;
        private double num2;
        private string operand;
        double answer;

        public void get_digits()

        {
            Console.WriteLine("\n\n For Exit : Press N");
            //Console.Write("Enter First Number : ");
            
           // Console.Write("Enter Second Number : ");
            
        }

        ConsoleKeyInfo status;
        //double answer;
        public void Calculation()
        {
            try
            {
                num1 = double.Parse(Console.ReadLine());
                operand = Console.ReadLine();
                num2 = double.Parse(Console.ReadLine());

                throw new FormatException();

               // char char1 = Convert.ToChar(num1);
               

                //get_digits();

                while (true)
                {
                    switch (operand)
                    {
                        case "-":
                            answer = num1 - num2;
                            break;
                        case "+":
                            answer = num1 + num2;
                            break;
                        case "/":
                            try
                            {
                                if (num2 == 0)
                                {
                                    throw new MyException();
                                }
                            }
                            catch(MyException e)
                            {
                                e.divide_by_zero();
                            }
                            
                            {

                            }
                            answer = num1 / num2;
                            break;
                        case "*":
                            answer = num1 * num2;
                            break;

                        default:
                            answer = 0;
                            break;
                    }

                    Console.WriteLine("\n");
                    Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());

                    status = Console.ReadKey();
                    if (status.Key == ConsoleKey.N)
                    {
                        break;
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please Enter Valid Input.");
            }

            
        }
    }

    
}


