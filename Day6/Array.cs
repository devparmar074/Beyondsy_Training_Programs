using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day6
{
    //internal class Array
    public class Array
    {

        public void read_array()
        {
            Console.WriteLine("Enter number of element you want to Add : \n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sample = new int[size];

            for (int i = 0; i < size; i++)
            {
                sample[i] = int.Parse(Console.ReadLine());
            }
        }



        public void getArraylength()
        {
            try
            {
                Console.WriteLine("Enter the size you want to Enter : \n");
                int size = int.Parse(Console.ReadLine());

                int[] sample = new int[size];
                for(int i = 0; i < size; i++)
                {
                    int temp = int.Parse(Console.ReadLine());
                    sample[i] = temp;
                }
                int length = sample.Length;

                if (length <= 0)
                {
                    Console.WriteLine("Please Enter value in array.\n");
                }
                else
                Console.WriteLine("\n" + length);

                // For Input Range exception : 
               // Console.WriteLine(sample[10]);

            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.numbers_only);
            }

            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Please Enter inputs in Range...");
            }


        }


        public void min_max_in_array()
        {

            try
            {
                Console.WriteLine("Please enter size of array : ");
                int size = int.Parse(Console.ReadLine());

                int[] numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    
                    int data = int.Parse(Console.ReadLine());
                    if(data == null)
                    {
                        throw new MyException();
                    }
                    numbers[i] = data;
                }

                // for find MAX in Array.
                int max = numbers.Max();

                // MIN
                int min = numbers.Min();


                Console.WriteLine("Maximum number is : " + max + "\n Minimum number is : " + min);
            }

            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Please Enter valid size of input array.");
            }

            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine(" ");
            }

            catch(NullReferenceException)
            {
                Console.WriteLine("Null is Not Allowed.");
            }

            catch(FormatException)
            {
                Console.WriteLine("Characters and Strings are not Allowed.\n Please provide Correct Input.");
            }

            catch(MyException ex)
            {
                ex.null_is_not_Allowed();
            }

        }


        public void _2D_to_1D()
        {
            try
            {
                int row, column;
                int k = 0;

                Console.WriteLine("Enter row : \n");
                row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Column : \n");
                column = int.Parse(Console.ReadLine());

                int[,] _2d = new int[row, column];
                int[] _1d = new int[row * column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        _2d[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        _1d[k++] = _2d[i, j];
                    }
                }

                for (int i = 0; i < row * column; i++)
                {
                    Console.WriteLine("\t" + _1d[i]);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please provide Valid Input.\n");
            }

            catch(NullReferenceException)
            {
                Console.WriteLine("Null are NOT Allowed\n");
            }
            
            Console.ReadLine();
        }

        public void print_negative_numbers()
        {
            Console.WriteLine("Enter number of element you want to Add : \n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sample = new int[size];
            
            for(int i=0; i<size; i++)
            {
                sample[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative numbers are : \n");
            
            for (int i=0; i<size; i++)
            {
                if (sample[i] < 0)
                {
                    
                    Console.WriteLine(sample[i]);
                }
                else
                {
                    continue;
                }
            }
        }

        public int print_Sum()
        {
            int sum = 0;

            Console.WriteLine("Enter number of element you want to Add : \n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sample = new int[size];

            for (int i = 0; i < size; i++)
            {
                sample[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<size; i++)
            {
                sum  += sample[i]; 
            }
            Console.WriteLine("the sum of Array's Element : ");
            return sum;
        }


        public void count_odd_even_Numbers()
        {
            int odd_counter = 0;
            int even_counter = 0;

            Console.WriteLine("Enter number of element you want to Add : \n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sample = new int[size];

            for (int i = 0; i < size; i++)
            {
                sample[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i<size; i++)
            {
                if (sample[i] % 2 == 0)
                {
                    even_counter++;
                }
                else
                {
                    odd_counter++;
                }
            }
            Console.WriteLine("Odd numbers Count : "+ odd_counter+"\n"+ "Even Numbers Count : "+ even_counter);
        }


        public void add_element()
        {
            try
            {
                Console.WriteLine("Enter number of element you want to Add : \n");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                int[] sample = new int[size];

                for (int i = 0; i < size; i++)
                {
                    sample[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Before adding Element : ");
                for(int i=0; i<size;i++)
                {
                    Console.WriteLine(sample[i]+ "\n");
                }

                Console.WriteLine("Enter Element you want to Insert : ");
                int element = int.Parse(Console.ReadLine());

                for (int i = 0; i < size; i++)
                {
                    if (sample[i] == ' ')
                    {
                        sample[i] = element;
                    }
                    else
                    {
                        throw new MyException();
                    }
                }

                Console.WriteLine("After adding Element : ");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(sample[i] + "\n");
                }
            }

            catch(MyException ex)
            {
                ex.indexoutofbound();
            }

            catch(FormatException)
            {
                Console.WriteLine("Please Enter valid Input");
            }
        }
        // case 2 :

        public void add_element_arrayList()
        {
            Console.WriteLine("Enter size : ");
            int size = int.Parse(Console.ReadLine()); 
           
            ArrayList sample = new ArrayList();

            Console.WriteLine("enter Array Elements : \n");

            for(int i=0; i <size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                sample[i] = data;
            }

            Console.WriteLine("BEFORE : \n");
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(sample[i]+"\n");
            }

            Console.WriteLine("Add Element : ");
            int element = int.Parse(Console.ReadLine());

            sample.Add(element);

            Console.WriteLine("AFTER : \n");
            for(int i=0; i<size; i++)
            {
                Console.WriteLine(sample[i]+"\n");
            }

        }

        public void print_unique_element()
        {
            Console.WriteLine("Enter number of element you want to Add : \n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sample = new int[size];

            for (int i = 0; i < size; i++)
            {
                sample[i] = int.Parse(Console.ReadLine());
            }

            int[] unique = new int[size];

            Console.WriteLine("Unique Elements are : \n");
            for (int i = 0; i<size; i++)
            {
              for(int j=i+1; j<size; j++)
                {
                    if (sample[i] == sample[j])
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Unique Element is : " + sample[i]);
                    }
                }
            }

            //Console.WriteLine("Unique Elments Are : ");
            
        }

        public void sort_Array(int[] arr)
        {
            /// Dynamic Array Creation : 
            Console.WriteLine("Enter number of element you want to Add : \n");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int[] sample = new int[size];

            for (int i = 0; i < size; i++)
            {
                sample[i] = int.Parse(Console.ReadLine());
            }

            //// Sort Logic : 
            for (int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        continue;
                    }

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ "\n");
            }

        }


    }

}







