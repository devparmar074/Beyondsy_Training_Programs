using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class example
    {
        public void merge_2_sorted_arrays()
        {
            int l = 0;
            int j = 0;
            int k = 0;

            Console.WriteLine("enter the size of array 1 : ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("enter element of array 1 :");
            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            Console.WriteLine("enter the size of array 2 : ");
            int size2 = int.Parse(Console.ReadLine());

            int[] arr2 = new int[size2];
            Console.WriteLine("enter element of array 2 :");
            for (int i = 0; i < size2; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr2[i] = data;
            }
            // int total_size = size + size2;

            int[] arr3 = new int[size + size2];


            while (l < size && j < size2)
            {
                if (arr[l] < arr2[j])
                {
                    arr3[k] = arr[l];
                    k++;
                    l++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    k++;
                    j++;
                }

            }

            while (l < size)
            {
                arr3[k] = arr[l];
                k++;
                l++;
            }

            while (j < size2)
            {
                arr3[k] = arr2[j];
                k++;
                j++;
            }

            Console.WriteLine("array 3 : \n");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine("       " + arr3[i] + "\t" + "\n");
            }

        }


        public void jagged_array()
        {
            int[][] jagged_arr = new int[6][];


            jagged_arr[0] = new int[] { 30, 45, 25, 63 };
            jagged_arr[1] = new int[] { 47, 30, 78 };
            jagged_arr[2] = new int[] { 72, 31 };
            jagged_arr[3] = new int[] { 03, 71, 64, 23, 99 };
            jagged_arr[4] = new int[] { 14, 39, 41, 33, 79 };
            jagged_arr[5] = new int[] { 68, 58, 45, 50 };



            for (int n = 0; n < jagged_arr.Length; n++)
            {
                System.Console.Write("Row({0}): ", n);

                for (int k = 0; k < jagged_arr[n].Length; k++)
                {
                    System.Console.Write(jagged_arr[n][k]+"\n");
                }

            }

        }

        public void average_of_all_element()
        {
            Console.WriteLine("enter the size of array  : ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("enter element of array  :");
            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            int sum = 0;

          
                for (int i = 0; i < size; i++)
                {
                    sum = sum + arr[i];

                }
                int average = sum / size;
            Console.WriteLine("___\n");
                Console.WriteLine(average);         
        }


    }
}
