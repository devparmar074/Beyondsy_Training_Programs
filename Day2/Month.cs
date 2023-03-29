using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Month
    {
        private int month;

        public void Check_Month(int month)
        {
            if(month == 1)
            {
                Console.WriteLine("It's January");
            }

            else if (month == 2)
            {
                Console.WriteLine("It's February");
            }

            else if (month == 3)
            {
                Console.WriteLine("It's March");
            }
            else if (month == 4)
            {
                Console.WriteLine("It's April");
            }

            else if (month == 5)
            {
                Console.WriteLine("It's May");
            }

            else if (month == 6)
            {
                Console.WriteLine("It's June");
            }

            else if (month == 7)
            {
                Console.WriteLine("It's July");
            }

            else if (month == 8)
            {
                Console.WriteLine("It's August");
            }

            else if (month == 9)
            {
                Console.WriteLine("It's September");
            }
            else if (month == 10)
            {
                Console.WriteLine("It's October");
            }

            else if (month == 11)
            {
                Console.WriteLine("It's November");
            }

            else if (month == 12)
            {
                Console.WriteLine("It's December");
            }
            else
            {
                Console.WriteLine("You have Entered Invalid Number");
            }
        }

        public void Display_month()
        {
            Console.WriteLine("Enter Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Check_Month(month);
        }
    }
}
