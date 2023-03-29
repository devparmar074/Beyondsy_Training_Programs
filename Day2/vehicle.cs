using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day2
{
    public class vehicle
    {
        private string company_name;
        private int Engine;
        private string Model;

        vehicle(string c_name, int engine, string model)
        {
            company_name = c_name;
            Engine = engine;
            Model = model;

            Console.WriteLine(c_name,engine,model);
        }

        vehicle()
        {
            Console.WriteLine("Default Called");
        }





    }
}
