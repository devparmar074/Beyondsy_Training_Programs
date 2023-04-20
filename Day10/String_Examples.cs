using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class String_Examples
    {

        public void sort_string()
        {
            {
                string str = Console.ReadLine();

                char[] strchar = str.ToCharArray();

                for(int i=0; i<strchar.Length; i++)
                {
                    for(int j = 0; j < strchar.Length; j++)
                    {
                        if (strchar[j]  > strchar[j+1])
                        {
                            char temp = strchar[j];
                            strchar[j] = strchar[j+1];
                            strchar[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine(strchar);
            }
        }

        public void sort_string_array()
        {
            string[] strarray = new string[10];

            for(int i=0; i<strarray.Length; i++)
            {
                strarray[i] = Console.ReadLine();

             //   string temp = Console.ReadLine();
              //  strarray[i] = temp;
            }


          //  Array.Sort<char>(array);

            Array.Sort<string>(strarray);

            for(int i=0; i<strarray.Length; i++)
            {
                Console.WriteLine(strarray[i]+"\n");
                Console.WriteLine("____________");
            }


        }

        public void Compare_string()
        {
            Console.WriteLine("Enter String 1: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter String 2: ");
            string str2 = Console.ReadLine();

            string str;
            int result;

            result = String.Compare(str1, 3, str2, 3, 3);

            if(result != 0)
            {
                Console.WriteLine("Substring are Different.");
            }
            else
            {
                Console.WriteLine("Substring are same.");
            }
            
            
        }

        public void find_substring()
        {
            Console.WriteLine("Please Enter string");
            string str = Console.ReadLine();

            Console.WriteLine("Enter Substring you want to find : ");
            string sub = Console.ReadLine();


            int counter = -1;
            int index = -1;
            int start = 0;  


            while (start != -1)
            {
                start = str.IndexOf(sub, index + 1);
                counter += 1;
                index = start;
            }

            Console.WriteLine(sub + " is Occured " + counter + "times.");
        }

        public void check_username_password()
        {          
            int counter = 3;

            while (counter > 0)
            {
                Console.WriteLine("Enter Username : ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string password = Console.ReadLine();


                if (username == "dev074" && password == "Dev@123")
                {
                    Console.WriteLine("You are Logged in at " + DateTime.Now + "\n");
                    goto exit;
                }
                else
                    counter--;
                {
                    Console.WriteLine("You entered Wrong password...You have " + counter + " try left.\n");                   
                }
               
            }
                exit: Console.WriteLine(" ");
           
        }

        public void convert_case()
        {
            Console.WriteLine("Enter String");

            string str = Console.ReadLine();


            Console.WriteLine("1.Convert to Lower Case.\n"+ "2.Convert to Upper Case\n");
            Console.WriteLine("Enter option : ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(str.ToLower()); 
                    break;

                case 2:
                    Console.WriteLine(str.ToUpper()); 
                    break;
            }
        }

        public void check_substring_present()
        {
            Console.WriteLine("Enter String : ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter substring you want to check : ");
            string sub = Console.ReadLine();

            int counter = -1;
            int index = -1;
            int start = 0;


            while (start != -1)
            {
                start = str.IndexOf(sub, index + 1);
                counter += 1;
                index = start;
            }

            if(counter >=1)
            {
                Console.WriteLine("SUBSTRING IS PRESENT...");
            }
            else
            {
                Console.WriteLine("MISSSING....");
            }
        }
    }
}
