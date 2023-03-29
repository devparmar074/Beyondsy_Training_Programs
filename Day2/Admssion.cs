using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public  class Admssion : Student
    {
        //Object Creation : 
        Student dev = new Student();

       

        public void admission_for_engineering()
        {
           
            dev.getmarks();

           int total =  dev.total_marks();
            //int total = dev.DBMS + dev.DS + dev.OS;

            if (dev.DBMS > 60 && dev.DS > 65 && dev.OS > 70)
            {
                if ( total > 190)
                {
                    Console.WriteLine("Candidate is Eligible.");
                }
                else
                





                    Console.WriteLine("Candidate is NOT Eligible.");

                }
            }
            else
            {
                Console.WriteLine("Candidate is NOT Eligible.");

            }


        }
    }
}
