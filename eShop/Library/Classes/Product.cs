using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Product:IItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        private static int _count = 1;
        public int ID = _count++;
    
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
