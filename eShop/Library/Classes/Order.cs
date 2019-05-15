using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Order :IItem
    {
        public int Quantity { get; set; }

        public string Name { get; set; }

        public int ID { get; set; }

        public double Price { get; set; }

        public static List<Order> orders = new List<Order>();

        

        public Order(int id,string name, double price, int quantity)
        {
            ID = id;
            Quantity = quantity;
            Name = name;
            Price = price;
         
            PrintOrderPrice();
        }

        public void PrintOrderPrice()
        {
            Price = Price* Quantity;

        }

    
        

        
    }
}
