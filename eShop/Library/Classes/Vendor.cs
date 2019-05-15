using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Vendor
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        private static int _count = 1;
        public int ID = _count++;


        public Vendor(string name, List<Product> products)
        {
            this.Name = name;
            this.Products = products;
        }
        public Vendor(string name)
        {
            this.Name = name;
        }
        public void AddProduct(List<Product> products)
        {
            this.Products = products;
        }
    }
}
