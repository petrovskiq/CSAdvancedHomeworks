using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;

namespace MyLibrary.Extensions
{
    public  static class Extensions
    {

        public static void Drive(this Car c)
        {
            Console.WriteLine("Driving");
            Console.WriteLine(c.Fuel + " " + "Before");
            c.Fuel -= 1;
            Console.WriteLine(c.Fuel + " " + "After");
          
        }

        public static class CarExtensions
        {

            

        }
    }
}
