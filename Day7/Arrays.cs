using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Arrays
    {

        public void copy_array_elements()
        {
            try
            {
                Console.WriteLine("enter size of an array : ");
                int size = int.Parse(Console.ReadLine());
                int[] arr1 = new int[size];
                int[] arr2 = new int[size];


                for (int i = 0; i < size; i++)
                {
                    int data = int.Parse(Console.ReadLine());
                    arr1[i] = data;
                }

                for (int i = 0; i < size; i++)
                {     
                        arr2[i] = arr1[i];               
                }
                Console.WriteLine("Copied Array :\n");
                for(int i=0; i<arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i]+ "\t\n");
                }
            }

            catch(ArgumentNullException)
            {
                Console.WriteLine("Null in the new array.\n");
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Enter Valid Input.\n");
            }
          
        }


        public void get_count_of_each_character()
        {
            Console.WriteLine("enter size of an array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];


            int counter = 0;

            //int[] freq  = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; ;
            
            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            int[] freq = new int[arr.Length+1];
            //freq = { 0 };

               for(int i=0; i<size; i++)
                {
                freq[arr[i]]++;
                }

            /*for(int i=0; i<10; i++)
            {
                for(int j = 0; j<size; j++)
                {
                    if(i == arr[j])
                    {
                        //freq[i]++;
                        counter++;
                    }
                    else
                    {
                        j++;
                    }
                }*/
                    /*if (freq[i] == arr[i])
                    {
                        freq[i]++;
                    }
                else
                {
                    i++;
                }*/
                   
                //Console.WriteLine(freq[i]+"'s Count is : " + counter);
            }

        public void reverse_array()
        {
            Console.WriteLine("enter size of an array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for(int i=0; i<size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            int start = 0;
            int end = arr.Length-1;

            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            for (int i=0; i<size; i++)
            {
                Console.WriteLine(arr[i]+"\t");
            }
        }


        public int second_largest_element_in_Array()
        {
            int second = 0;

            Console.WriteLine("enter size of an array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
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

            second = arr[arr.Length - 2];
            return second;
        }


        public int total_Duplicate_numbers()
        {
            Console.WriteLine("enter size of an array : ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            int counter = 0;

            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            for(int i=0; i<arr.Length; i++)
            {
                for(int j =1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return counter;

        }
        }
    }

