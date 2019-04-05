using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;
using MyLibrary.Extensions;

namespace MyLibrary.Classes
{
    public static class GasStation
    {
      
        
        public static void Refill(Car c)
        {
            Random rnd = new Random();

            Console.WriteLine($"{rnd.Next(1, 5) + c.Fuel}l fuel added");
        }
        public static void PumpUpTires(Car c)
        {
            if (!c.IsDrivable)
            {
                c.IsDrivable = true;
                Console.WriteLine("Car Tyres Pumped Up");
            }
            else
            {
                Console.WriteLine("No Need For Intervention");
            }
        }
        
    }
}
