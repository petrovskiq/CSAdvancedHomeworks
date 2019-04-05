using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public partial class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Fuel { get; set; }



        public bool HaveKeys { get; set; }
        public bool IsDrivable { get; set; }

        public Car(string brand, string model, string color, int fuel, bool havekeys)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Fuel = fuel;
            HaveKeys = havekeys;
            if (havekeys)
            {
                if (fuel > 0)
                {
                    IsDrivable = true;
                }
            }
            else
            {
                IsDrivable = false;
                havekeys = false;
            }
        }

        public static void GetCarStats()
        {
            throw new NotImplementedException();
        }
    }

    public partial class Car
    {
        public void StartCar() {
            if (IsDrivable)
            {
                Console.WriteLine("Starting the car, ready to drive");
            }
            else
            {
                Console.WriteLine("You need the keys or your fuel is low");
            }

        }
        public void StartLights()
        {
            if (HaveKeys)
            {
                Console.WriteLine("Starting the lights");
            }
            else
            {
                Console.WriteLine("You can't start the lights unless to enter in the car");
            }
        }
        public static void GetCarStats(Car c)
        {
            Console.WriteLine($"{c.Brand} {c.Color} {c.Model}");
        }
    }

    

   
    
}
