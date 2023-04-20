using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class LINQ_Examples
    {
        public void Example_1()
        {
            List<int> numbers = new List<int> { -30,30,4,-1,487,-545,8,84,545,-5,8,4,2,5,54,-87,54,5,85 };

            var result  = from number in numbers
                          where number > 0
                          select number;

            foreach(var items in result)
            {
                Console.WriteLine(items);
            }
        }


        public void Example_2()
        {
            string[] days = { "sunday", "monday", "wednesday", "thursday", "friday", "saturday" };

            var result = from day in days
                         select day;

            foreach(var item in result) 
            {
                Console.WriteLine(item); 
            }

           
        }


        public void Example_3()
        {
            List<int> numbers = new List<int> { 54,01,30,02,6,40,21,00,09,44,60,23,75,99,16,19,85,70 };

            var results = from number in numbers
                          where number >= 20
                          select number;

            Console.WriteLine("___\n");
            foreach(int item in results)
            {
                Console.WriteLine(item);
            }
        }

        public void Example_4()
        {
            Console.WriteLine("enter the size of array : ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("enter element of array :");
            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }

            var sqr = from number in numbers
                      let square = number * number
                      where square > 0

                      select new { number, square };

            foreach(var item in sqr)
            {
                Console.WriteLine(item+"\n");
            }
        }


        public void Example_5()
        {
            List<int> numbers = new List<int> { 54, 01, 30, 02, 6, 40, 21, 00, 09, 44, 60, 23, 75, 99, 16, 19, 85, 70 };

            Console.Write("How many records you want to display ? : ");
            int n = Convert.ToInt32(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            foreach (int top_n in numbers.Take(n))
            {
                Console.WriteLine(top_n);
            }
        }

        public void Example_6()
        {
            // List<int> numbers = new List<int> { 54, 01, 30, 02, 6, 40, 21, 00, 09, 44, 60, 23, 75, 99, 16, 19, 85, 70 };

            Console.WriteLine("enter the size of array : ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("enter element of array :");
            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                numbers[i] = data;
            }
            var n = from x in numbers
                    group x by x into y
                    select y;
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
        }


        




    }


        
}
