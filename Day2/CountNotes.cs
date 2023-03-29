using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class CountNotes
    {
        private int Amount ;

        public void CalculateNotes(int Amount)
        {
          
           //int Amount = Convert.ToInt32((Console.ReadLine));

            //int[] notes = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 2000 };
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(notes[i] + " Note is : " +  (Amount / notes[i]));
                Amount = Amount % notes[i];
            }
        }

        public void display_Notes()
        {
            Console.WriteLine("Enter Amount : ");
            int amount = Convert.ToInt32( Console.ReadLine());
            CalculateNotes(amount);
        }
       

    }
}
