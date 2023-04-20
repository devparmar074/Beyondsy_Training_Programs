using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class function_Example
    {
        public void Example_1(string str)
        {
           
            DateTime dt = DateTime.Now;
            Console.WriteLine("Hello, "+ str + " you are Logged in at "+ dt);
        }


        public int Example_2(int num1, int num2)
        {
                    return num1 + num2;
        }

        public int Example_3(string str)
        {
            int counter = 0;
            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == 32)
                {
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public void Example_4(int num)
        { 
            if(num % 2 == 0)
            {
                Console.WriteLine(num + " is a EVEN.");
            }
            else
            {
                Console.WriteLine(num + " is a ODD.");
            }
        }

        public int Example_5(int number)
        {
            int sum = 0;
                        
            while (number != 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }

            return sum;
        }

        public void Example_6(int number)
        {
            int counter = 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;                    
                }
                               
            }
            if (counter == 0)
            {
                Console.WriteLine(number + " is  Prime Number.");
            }
            else
            {
                //counter = 0;
                Console.WriteLine(number + " is NOT a Prime Number");
            }
        }

        public int Example_7(int num)
        {
            // Example : 
            // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 

            if (num == 0 || num == 1)
            {
                return num;
            }

            return Example_7(num - 1) + Example_7(num - 2);
        }

        public void Example_8(int num1, int num2)
        {
            Console.WriteLine("Before Swapping : ");

            Console.WriteLine("1 : "+num1+"\n"+ "2 : "+ num2);

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After Swapping : ");
            Console.WriteLine("1 : " + num1 + "\n" + "2 : " + num2);
        }

        public int Example_9(int num)
        {
            /*if (n === 0) return 1
            return n * factorial(n - 1)*/

            if(num == 0 || num==1)
            {
                return num;
            }

            return num * Example_9(num - 1);
        }
        

        public int Example_10(int number)
        {
            
                if(number == 1)
                {
                    return 1;
                }
            return Example_10(number / 2) * 10 + number % 2;
        }
           
         
    }
}

