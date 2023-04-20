using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//using System.Exception;

namespace Day6
{
    public class Switch_Examples
    {
        public void check_vowel()
        {
            try
            {
                Console.WriteLine("Enter Character : ");
                char input = char.Parse(Console.ReadLine());

                if (char.IsDigit(input))
                {
                    throw new MyException();
                }

                if (char.IsWhiteSpace(input))
                {
                    Console.WriteLine("White sapce is NOT Allowed.");
                    goto exit;
                }

                if (input.ToString().Length > 0)
                {
                   
                    Console.WriteLine("Only Character is Allowed.\n" + "String is NOT Allowed.\n");
                    goto exit;
                }

                switch (input)
                {
                                        
                    case 'a':
                        Console.WriteLine("vowel");
                        break;
                    case 'e':
                        Console.WriteLine("vowel");
                        break;
                    case 'i':
                        Console.WriteLine("vowel");
                        break;
                    case 'o':
                        Console.WriteLine("vowel");
                        break;
                    case 'u':
                        Console.WriteLine("vowel");
                        break;
                    case 'A':
                        Console.WriteLine("vowel");
                        break;
                    case 'E':
                        Console.WriteLine("vowel");
                        break;
                    case 'I':
                        Console.WriteLine("vowel");
                        break;
                    case 'O':
                        Console.WriteLine("vowel");
                        break;
                    case 'U':
                        Console.WriteLine("vowel");
                        break;

                    default:
                        Console.WriteLine(input + " is a Consonant.");
                        break;
                }
            }

            catch(MyException ex)
            {
                ex.character_Only();
            }
            catch(FormatException)
            {
                MyException ex2 = new MyException();
                ex2.string_not_Allowed();
               // Console.WriteLine("Only Character is Allowed.\n" + "String is NOT Allowed.\n");
            }

        exit:

            //throw new MyException.is_white_space_Entered();
            Console.ReadLine();
            
        }


        public void isEven_odd()
        {
            try
            {
                Console.WriteLine("Enter Number : ");
                int number = int.Parse(Console.ReadLine());

               /* if(number > int.MaxValue)
                {
                    
                }*/

                switch(number % 2)
                {
                    case 0: Console.WriteLine(number + " is a Even.");
                        break;

                    case 1: Console.WriteLine(number + " is a Odd.");
                        break;

                }              
            }

            catch(NotSupportedException )
            {
                Console.WriteLine("Please Enter a Number Between INT Range.");
            }

            catch(FormatException )
            {
                Console.WriteLine("Please Enter Valid Input.\n" + "Only Numbers are Allowed.");
            }
            catch(OverflowException )
            {
                Console.WriteLine("Entered Number is out of Range INT.\n");
            }
        }

        

    }
}
