using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Program
    {
        static void Main()
        {
            //  object creation : 
            String_Examples string_object = new String_Examples();
                

            Console.WriteLine("Enter Program number : ");
            int program = int.Parse(Console.ReadLine());

            switch (program)
            {

                case 110:
                    string_object.sort_string();
                    break;

                case 111: 
                    string_object.sort_string_array();
                    break;

                case 112:
                    string_object.Compare_string();
                    break;

                case 113:
                    string_object.find_substring();
                    break;

                case 114:
                    string_object.check_username_password();
                    break;

                case 115:
                    string_object.convert_case();
                    break;

                case 116:
                    string_object.check_substring_present();
                    break;
            }
        }
    }
}
