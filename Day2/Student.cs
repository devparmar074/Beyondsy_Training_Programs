using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Student 
    {
        public int DBMS, DS, OS;

        public void getmarks()
        {
            try
            {
                Console.WriteLine("Enter DBMS : ");
                DBMS = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter DS : ");
                DS = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter OS : ");
                OS = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public int total_marks()
        {
            int total = DBMS + DS + OS;
            return total;
        }

        public double percentage()
        {
            double percentage = 0;
            
            percentage = Convert.ToDouble( total_marks() / 3);
        
            return percentage;
        }

        public void CalculateDivision()
        {
            getmarks();
            //total_marks();
          //double per =   percentage();
          percentage();

            if(percentage() >= 85 && percentage() <= 99.99)
            {
                Console.WriteLine("Class A");
            }

            else if (percentage() >= 70 && percentage() < 85)
            {
                Console.WriteLine("Class B");
            }

            else if (percentage() >= 55 && percentage() < 70)
            {
                Console.WriteLine("Class C");
            }

            else if (percentage() >= 36 && percentage() < 55)
            {
                Console.WriteLine("Class D");
            }

            else
            {
                Console.WriteLine("FAIL!!!");
            }

        }



    }
}
