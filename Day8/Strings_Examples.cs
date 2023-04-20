using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Strings_Examples
    {
        public void Example_1(string name)
        {
             name = Console.ReadLine();

            Console.WriteLine("Welcome, "+ name);
        }

        public void Example_2(string name)
        {
            char[] seperator = { ' ', ',' };
            string[] data=  name.Split(seperator); 

            foreach(String s in data)
            {
                Console.WriteLine(s);
            }
        }

        public int Example_3()
        {
           string str = Console.ReadLine();

            int counter;
            counter = 0;

            for(int i=0; i<str.Length; i++)
            {
                counter++;
            }
            return counter;
        }

        public void Example_4()
        {
            string str = Console.ReadLine();

            int char_counter = 0;
            int digit_counter = 0;
            int special_counter = 0;


            for (int i = 0; i < str.Length; i++)
            {
                //91-96 123-126

                if (str[i] > 33 && str[i] < 48 || str[i] >=58 && str[i] <= 64 || str[i] >= 91 && str[i] <= 96 || str[i] >= 123 && str[i] <= 126)
                {
                    special_counter++;
                }

                if (str[i] >= 48 && str[i] <= 57)
                {
                    digit_counter++;
                }

                if (str[i] >= 65 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
                {
                    char_counter++;
                }

                
            }
            Console.WriteLine("Spcial character is  :" + special_counter + "\n" + "Digit is : " + digit_counter + "\n" + "Character is : " + char_counter + "\n");
        }

    }
}
