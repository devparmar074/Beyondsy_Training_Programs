using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class String_Examples
    {
        public void reverse_string()
        {
            string str = Console.ReadLine();
            int end = str.Length - 1;

            while (end >= 0)
            {
                Console.Write(str[end] + " ");
                end--;
            }
        }


        public void copy_string()
        {
            string str = Console.ReadLine();

            string copied_string;

            copied_string = str;


            Console.WriteLine(copied_string);



        }

        public void total_number_of_vowel_Consonant()
        {
            string str = Console.ReadLine();
            int vowel_counter = 0;
            int Consonant_counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'i' || str[i] == 'I' || str[i] == 'e' || str[i] == 'E' ||
                   str[i] == 'a' || str[i] == 'A' || str[i] == 'o' || str[i] == 'O' ||
                   str[i] == 'u' || str[i] == 'U')

                {
                    vowel_counter++;
                }

                else
                {
                    Consonant_counter++;
                }
            }

            Console.WriteLine("Vowels are : " + vowel_counter + "\n" + "Consonant are : " + Consonant_counter);
        }


        public void maximum_occuring_char()
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {

            }

            int[] freq = new int[str.Length + 1];
            //freq = { 0 };

            for (int i = 0; i < str.Length; i++)
            {
                freq[str[i]]++;
            }

            Console.WriteLine(freq.Max());
        }

        public void Maximum_char_in_string()
        {
            string str = Console.ReadLine();

            int[] countArray = new int[256];
            int maxValue = 0;
            char resultChar = '\0';

            for (int i = 0; i < str.Length; i++)
            {
                countArray[str[i]]++;

                if (countArray[str[i]] > maxValue)
                {
                    maxValue = countArray[str[i]];
                    resultChar = str[i];
                }

                
            }

            Console.WriteLine(resultChar);
        }

    }
}
