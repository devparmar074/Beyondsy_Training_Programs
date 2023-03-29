using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class B
    {
        // 15
        public void isEevnorOdd()
        {

            try
            {
                Console.WriteLine("Enter the number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + "Number is EVEN.");

                }
                else
                {
                    Console.WriteLine(num + "Number is Odd.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // 16
        public void Largest_number()
        {

            // Logic : 
            //max = (num1 > num2) ? num1 : num2;
            //largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3) ;


            Console.WriteLine("Enter Three numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num1 + " is Greater among three numbers.");
                }

                else if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is Greater among three numbers.");
                }

                else
                {
                    Console.WriteLine(num3 + " is Greater among three numbers.");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        //17
        public void Largest_Using_Conditional()
        {
            // //largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
            Console.WriteLine("Enter Three numbers : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);

            Console.WriteLine(largest);

        }

        // 18
        public void IsLeap_year()
        {
            try
            {
                Console.WriteLine("Enter Year : ");
                int Year = Convert.ToInt32(Console.ReadLine());

                if (Year % 400 == 0)
                {
                    Console.WriteLine(Year + " is a leap year.");
                }

                else if (Year % 100 == 0)
                {
                    Console.WriteLine(Year + " is  not a leap year.");
                }

                else if (Year % 4 == 0)
                {
                    Console.WriteLine(Year + " is a leap year.");
                }

                else
                {
                    Console.WriteLine(Year + " is not a leap year.");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        // 20 
        public void IsVowel()
        {
            try
            {
                Console.WriteLine("Enter a Character : ");
                char ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'a' || ch == 'A' ||
                    ch == 'e' || ch == 'E' ||
                    ch == 'i' || ch == 'I' ||
                    ch == 'o' || ch == 'O' ||
                    ch == 'u' || ch == 'U')
                {
                    Console.WriteLine(ch + " is a Vowel");
                }
                else
                {
                    Console.WriteLine(ch + " is not a Vowel.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        // 21
        public void IsNumberPositive()
        {

            try
            {
                Console.WriteLine("Enter a Number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    Console.WriteLine(" Number is ZERO.");
                }

                if (num > 0)
                {
                    Console.WriteLine("Number is Postive");
                }
                if (num < 0)
                {
                    Console.WriteLine("Number is Negative.");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void IsUpper_or_Lower_Case()
        {
            // Logic : 
            // A-Z = 65- 96

            try
            {
                Console.WriteLine("Enter a Character : ");
                char ch = Convert.ToChar(Console.ReadLine());

                if ((int)ch >= 65 && (int)ch <= 90)
                {
                    Console.WriteLine(ch + " is in a UPPER CASE.");
                }

                else if ((int)ch >= 97 && (int)ch <= 122) ;
                {
                    Console.WriteLine(ch + " is in a LOWER CASE.");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void IsConsonant_or_Vowel()
        {

            try
            {
                Console.WriteLine("Enter a Character : ");
                char ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'a' || ch == 'A' ||
                    ch == 'e' || ch == 'E' ||
                    ch == 'i' || ch == 'I' ||
                    ch == 'o' || ch == 'O' ||
                    ch == 'u' || ch == 'U')
                {
                    Console.WriteLine(ch + " is a Vowel");
                }

                else
                {
                    Console.WriteLine(ch + " is a Consonant");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        public void Isalphabet_digit_special_char()
        {
            // Logic : 
            //48-57

            try
            {
                Console.WriteLine("Enter a Character : ");
                char ch = Convert.ToChar(Console.ReadLine());

                if ((int)ch >= 65 && (int)ch <= 90 || (int)ch >= 97 && (int)ch <= 122)
                {
                    Console.WriteLine(ch + " is a Alphabets.");
                }

                else if((int)ch >= 48 && ((int)ch <= 57))
                    {
                    Console.WriteLine(ch + " is a DIGIT.");
                    }

                else
                {
                    Console.WriteLine(ch + " is a SPECIAL Character.");
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void IsNumberEqual()
        {
            try
            {
                Console.WriteLine("Enter Three numbers : ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 == num2)
                {
                    Console.WriteLine("Numbers are Equal");
                }

                else
                {
                    Console.WriteLine("Numbers are NOT Same.");
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public void print_Day_Weeek()
        {

            try
            {
                Console.WriteLine("Enter Week Number");
                int week = Convert.ToInt32(Console.ReadLine());

                switch (week)
                {
                    case 1:
                        Console.WriteLine("It's Monday.");
                        break;

                    case 2:
                        Console.WriteLine("It's Tuesday.");
                        break;

                    case 3:
                        Console.WriteLine("It's Wednesday.");
                        break;


                    case 4:
                        Console.WriteLine("It's Thursday.");
                        break;

                    case 5:
                        Console.WriteLine("It's Friday.");
                        break;

                    case 6:
                        Console.WriteLine("It's Saturday.");
                        break;

                    case 7:
                        Console.WriteLine("It's Sunday.");
                        break;

                    default: Console.WriteLine("INVALID NUMBER Entered. ");
                        break;
                }

            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }


        public void IsAgeValidate()
        {

            try
            {
                Console.WriteLine("Enter Age : ");
                int Age = Convert.ToInt32(Console.ReadLine());

                if (Age < 18)
                {
                    Console.WriteLine("You are not Eligible.");
                }

                else
                {
                    Console.WriteLine("You are Eligible.");
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }


        public void admission_for_engineering()
        {
            Console.WriteLine("Enter DBMS : ");
            int DBMS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DS : ");
            int DS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter OS : ");
            int OS = Convert.ToInt32(Console.ReadLine());

            int total = DBMS + DS + OS;

            if(DBMS > 60 && DS > 65 && OS > 70)
            {
                if(total > 190)
                {
                    Console.WriteLine("Candidate is Eligible.");
                }
                else
                {
                    Console.WriteLine("Candidate is NOT Eligible.");

                }
            }
            else
            {
                Console.WriteLine("Candidate is NOT Eligible.");

            }


        }

        public void diplsay_Days()
        {
            int input;
            int days = 7;
            int year;
            int week;
            int day;

            input = Convert.ToInt32(Console.ReadLine());

            year = input / 365;
            week = (input % 365) / days;
            day = (input % 365) % days;

            Console.WriteLine("year : " + year);
            Console.WriteLine("Week : " + week);
            Console.WriteLine("day : "+day);


        }
        

        
    }
}
