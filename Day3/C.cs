using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Day3
{
    public class C
    {


        public void check_Triangle()
        {
            Console.WriteLine("Enter Angle 1 : ");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Angle 2 : ");
            int angle2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Angle 3 : ");
            int angle3 = Convert.ToInt32(Console.ReadLine());

            int total = angle1 + angle2 + angle3;

            if(total == 180)
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("NOT Valid");
            }

        }


        public void print_Alphabets()
        {
            for(int i =65; i<=90;i++)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
        }


        public void print_ASCII()
        {
            // 65-90 = Uppar case & 97-122 = Lower case
            
             for (int i = 65; i <= 122; i++)
            {
                if (i > 90 && i <= 96)
                    continue;

                Console.WriteLine(Convert.ToChar(i) + "'s ASCII Vaue is : "+ i);
                Console.WriteLine(" ");
            }
        }

        public void multiplication_table()
        {
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i =1; i<= 10; i++)
            {
                Console.WriteLine(number+" * "+i+" = "+ number*i);
                Console.WriteLine(" ");
            }
        }

        public void reverse_Natural_numbers()
        {
            Console.WriteLine("Enter number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }


        }

        public int sum_of_digits()
        {
            int sum = 0;

            //Console.WriteLine("Enter size : ");
            //int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[3];
           

            try
            {
                Console.WriteLine("Enter Digits : ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    //Convert.ToInt32(Console.ReadLine(numbers[i]));
                    numbers[i] = Convert.ToInt32( Console.ReadLine  ());
                }

                for(int i=0; i < numbers.Length; i++)
                {
                    sum = sum + numbers[i];
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return sum;
        }

        public int sum_of_even_numbers()
        {
            int sum = 0;

            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {

                if (i % 2 == 1)
                {
                    continue;
                }
                else
                {
                    sum = sum + i;
                }
            }

            return sum;
            
        }

        public int sum_of_Odd_numbers()
        {
            int sum = 0;

            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    sum = sum + i;
                }
            }
            return sum;

        }


        public void swap_first_last_number()
        {
            // Logic :  number length = 5 division time =4  (length - 1)
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int first, last = 0;
            first = number;
            for (int i = 0; i < number.ToString().Length - 1; i++)
            {
                first = first / 10;
            }

            last = number % 10;

            // Swapping : 
            {
                int temp = first;
                first = last;
                last = temp;
            }
            
            Console.WriteLine("First : "+first);
            Console.WriteLine("Last : " +last);

        }

        public int sum_of_swap_numbers()
        {
            // Logic :  number length = 5 division time =4  (length - 1)
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int first, last = 0;
            first = number;

            for (int i = 0; i < number.ToString().Length - 1; i++)
            {
                first = first / 10;
            }

            last = number % 10;

            int sum = first + last;
            Console.WriteLine("Sum of First and Last Digit : ");
            return sum;

        }

        public void find_first_last_digit()
        {
            // Logic :  number length = 5 division time =4  (length - 1)
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int first, last = 0;
            first = number;

            for (int i = 0; i < number.ToString().Length - 1; i++)
            {
                first = first / 10;
            }

            last = number % 10;

            Console.WriteLine("First Number : " + first);
            Console.WriteLine("Last Number : " + last);

        }

        public int get_Product()
        {
            int answer = 1;
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            while (number != 0)
            {
                answer = answer * (number % 10);
                number = number / 10;
            }

            return answer;
        }

        public int reverse_digit()
        {
            int answer = 0;
            int last_digit;

            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                last_digit = number % 10;
                answer = (answer * 10) + last_digit;
                number /= 10;
            }
            return answer;
        }

        public int getPower()
        {
            int answer = 0;
           // int answer2 = 0;

            // 2,3 = 8

            Console.WriteLine("Enter Base Number : ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Power : ");
            int power = Convert.ToInt32(Console.ReadLine());

            // using For Loop :
            for (int i = 1; i <= power; i++)
            {
                answer = Base * i;
            }
            return answer;
           
        }

        public int find_factorial()
        {
            int answer = 1;
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            // 5 = 5 * 4 * 3 * 2 * 1 = 120

           for(int i = 2; i<=number; i++)
            {
                answer *= i;
            }
            return answer;
        } 

        public void check_Armstrong_number()
        {
            // Logic : 1^3 + 5^3 + 3^3 = 153.
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number;
            int p = 0;

            while (number > 0)
            {
                int rem = number % 10;
                p = (p) + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == p)
            {
                Console.WriteLine("Yes. It is Armstrong number.");
            }
            else
            {
                Console.WriteLine(
                    "No. It is not an Armstrong Number.");
            }


        }

        public int number_of_Armstrong_number()
        {
            // Logic : 1^3 + 5^3 + 3^3 = 153.
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            //int p = 0;

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int temp = i;
                while (temp > 0)
                {                   
                    int lastdigit = temp % 10;
                    
                    sum += (int)Math.Pow(lastdigit, 3);
                    temp /= 10;
                }
                
                if (sum == i)
                {
                    Console.Write(i + " ");
                    Console.WriteLine(" ");
                    counter++;
                }
            }
            return counter;
        }

        public double getCompoundInterest()
        {
            double result = 0;

            Console.WriteLine("Enter Principal : ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Rate : ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Year : ");
            double Year = Convert.ToDouble(Console.ReadLine());

            double Amount = principal * (Math.Pow((1 + rate / 100), + Year));

            double Compound_Interest = Amount - principal;

            result = Compound_Interest;
            return result;
        }

        public void isPrime()
        {
            Console.WriteLine("1. for For Loop : ");
            Console.WriteLine("2. While Loop : ");

            Console.WriteLine("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int counter = 0;

            switch (choice)
            {
                case 1:
                        for (int i = 1; i <= number; i++)
                        {
                            if (number % i == 0)
                            {                                
                                counter++;
                            }
                        }
                            if (counter <= 2)
                            {
                                Console.WriteLine(number + " is a PRIME NUMBER");
                            }
                            else
                            {
                                Console.WriteLine(number + " is NOT a PRIME NUMBER");
                            }

                    break;

                 case 2:
                        int loop = number;
                        while (loop != 0)
                        {

                            if (number % loop == 0)
                            {
                                counter++;
                            }

                            loop--;
                        }
                            if (counter <= 2)
                            {
                                Console.WriteLine(number + " is a PRIME NUMBER");
                            }
                            else
                            {
                                Console.WriteLine(number + " is NOT a PRIME NUMBER");
                            }

                    break;

                    default: Console.WriteLine("INVALID CHOICE.");
                    break;
            }
            
        }

        public void ispalindroome()
        {

            try
            {
                Console.WriteLine("Enter Number : ");
                int number = Convert.ToInt32(Console.ReadLine());

                int reverse = Convert.ToInt32(number.ToString().Reverse());

                if (reverse == number)
                {
                    Console.WriteLine(" is a Palindrome.");
                }
                else
                {
                    Console.WriteLine(" is NOT a Palindrome.");

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }


        public void Highest_Common_Factor()
        {
            int result = 0;

            Console.WriteLine("Enter Number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();



            Stack<int> num1 = new Stack<int>();

            for (int i = 1; i <= number1; i++)
            {
                if (number1 % i == 0)
                {
                    Console.WriteLine(i);
                    list1.Add(i);
                }

            }

            Stack<int> num2 = new Stack<int>();
            for (int i = 1; i <= number2; i++)
            {
                if (number2 % i == 0)
                {
                    list2.Add(i);
                }
            }
            list1.Reverse();
            list2.Reverse();

            for (int i = 1; i <= 5; i++)
            {

                for (int j = i; j <= 5; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list3.Add(i);
                        Console.WriteLine("Highest Common Factor : " + i);

                    }
                }

            }
            Console.WriteLine(list3.Max());

        }




        public void Lowest_Common_Factor()
        {
            int result = 0;

            Console.WriteLine("Enter Number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            
            Stack<int> num1 = new Stack<int>();
            
            for(int i=1; i <= number1; i++)
            {
                if(number1 % i == 0)
                {
                    list1.Add(i);
                }
                
            }

            Stack<int> num2 = new Stack<int>();
            for (int i = 1; i <= number2; i++)
            {
                if (number2 % i == 0)
                {
                    list2.Add(i);
                }

            }


            for (int i = 1; i<=5; i++)
            {

                for(int j=i; j<=5; j++)
                {
                    if (list1[i] == list2[j])
                    {  
                        Console.WriteLine("Lowest Common Factor : " + i);
                        
                    }
                }


                
                
            }

           
            
        }

        public void print_Words_of_Numbers()
        {
            Console.WriteLine("Enter Number 1 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int num = 0;
            while (number != 0)
            {
                number = (number * 10) + (number % 10);
                number /= 10;
            }

            //print corresponding digit in words till num becomes 0
            while (num != 0)
            {
                switch (num % 10)
                {
                    case 0:
                        Console.Write("zero ");
                        break;
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                }
                num = num / 10;



            }
        }


         
    }

}

