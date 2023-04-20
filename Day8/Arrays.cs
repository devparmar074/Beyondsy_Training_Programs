using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Arrays
    {
        public void delete_duplicate()
        {
            Console.WriteLine("enter the size of array : ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;
            }

            int[] deleted_data = new int[size];

            int j = 0;

            for (int i = 0; i < size - 1; i++)
                                
                if (arr[i] != arr[i + 1])
                {
                    deleted_data[j++] = arr[i];

                    deleted_data[j++] = arr[size - 1];

                }


            for (int i = 0; i < j; i++)
            {
                arr[i] = deleted_data[i];
            }
               
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }


        }

    }
}
