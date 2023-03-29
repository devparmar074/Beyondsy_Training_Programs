using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Day2
{
    class Program : Student
    {
        static void Main(string[] args)
        {
            // Creating Objects.
            B obj1 = new B();
            Admssion admssion = new Admssion();
            Student student = new Student();
            CountNotes c1 = new CountNotes();
            Month m1 = new Month();

            vehicle v1;
            


            Console.WriteLine("Enter Program Number");
            int programs = Convert.ToInt32(Console.ReadLine());
            switch (programs)
            {
                case 15:
                    obj1.isEevnorOdd();
                    break;

                case 16:
                    obj1.Largest_number();
                    break;

                case 17:
                    obj1.Largest_Using_Conditional();
                    break;

                case 18:
                    obj1.IsLeap_year();
                    break;

                case 19:
                    obj1.IsVowel();
                    break;

                case 20:
                    obj1.IsNumberPositive();
                    break;

                case 21:
                    obj1.IsUpper_or_Lower_Case();
                    break;

                case 22:
                    obj1.Isalphabet_digit_special_char();
                    break;

                case 23:
                    obj1.IsNumberEqual();
                    break;

                case 24:
                    obj1.print_Day_Weeek();
                    break;

                case 25:
                    obj1.IsAgeValidate();
                    break;

                case 26:
                    
                    break;


                case 27:
                    obj1.IsAgeValidate();
                    break;

                case 28:
                    admssion.admission_for_engineering();
                    break;

                case 29:
                    student.CalculateDivision();
                    break;

                case 30:
                    student.CalculateDivision();
                    break;

                case 31:
                    c1.display_Notes();
                    break;

                case 32:
                    m1.Display_month();
                    break;

                case 33:
                    obj1.diplsay_Days();
                    break;

                case 34:
                    
                    break;
                    

                default: Console.WriteLine("INVALID");
                     break;

            }





            Console.ReadLine();
        }
    }





}

