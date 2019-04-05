using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;
using MyLibrary.Extensions;

namespace GasStationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Bmw = new Car("Bmw", "3", "Black", 10, true);

            Console.WriteLine(Bmw.IsDrivable);

            Bmw.StartCar();
            Bmw.StartLights();
            Bmw.Drive();

            Car.GetCarStats(Bmw);

            GasStation.Refill(Bmw);
            GasStation.PumpUpTires(Bmw);

            

            Console.ReadLine();

        }
    }
}
