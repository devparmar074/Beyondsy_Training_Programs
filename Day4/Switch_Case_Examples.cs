using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Switch_Case_Examples
    {
        public void print_days_in_month()
        {
            try
            {
                bool exit = true;
                while (exit)
                {
                    Console.WriteLine("1. Check Month : \n" +
                                      "2.Exit\n" +
                                      "Enter Option : \n");
                    int option = int.Parse(Console.ReadLine());
                    
                    if(option >= 1 && option <= 3)
                    {
                        if (option == 1)
                        {
                            display_month();
                        }

                        else if (option == 2)
                        {
                            exit = false;
                            break;
                        }
                    }

                    else
                    {
                        throw new MyException();
                        //Console.WriteLine("Invalid Number Entered.");
                    }

                   
                }
            }

            catch(MyException e)
            {
                e.numbers_only();
            }

            
           /// Console.ReadLine();
        }

        public void display_month()
        {




            Console.WriteLine("Enter a month : \n");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    Console.WriteLine(month + " has a 31 Days.\n");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:

                    Console.WriteLine(month + " has a 30 Days.\n");
                    break;

                case 2:
                    Console.WriteLine(month + " has a 28/29 days.\n");
                    break;
            }
        }

    }
        

}

