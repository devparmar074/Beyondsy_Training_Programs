using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Bus
    {
        // Static variable used by all Bus instances.
        // Represents the time the first bus of the day starts its route.

        public static DateTime globalStartTime;

        // Property for the number of each bus.
        public string bus_name { get; set; }

        // Static constructor to initialize the static variable.
        // It is invoked before the first instance constructor is run.
        static Bus()
        {
            globalStartTime = DateTime.Now;

            // The following statement produces the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static constructor sets global start time to {0}",
                globalStartTime.ToLongTimeString());
        }

        // Instance constructor.
        public Bus(string bus_name)
        {
            bus_name = bus_name;
            Console.WriteLine("Bus {0} is created.", bus_name);
        }

        // Instance method.
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;
                        
            Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
                                    this.bus_name,
                                    elapsedTime.Milliseconds,
                                    globalStartTime.ToShortTimeString());
        }
    }
}
