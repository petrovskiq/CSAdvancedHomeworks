using Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-----------------------------------Welcome to the E-Shop!-----------------------------------");
            Console.WriteLine("-----------------------Please register , enter your desired username:-----------------------");
            string username = Console.ReadLine();
            


            #region Products
            Dictionary<Vendor, List<Product>> VendorsAndProducts = new Dictionary<Vendor, List<Product>>()
            {
                [new Vendor("Nike")] = new List<Product>
            {
                new Product("NIKE AIR MAX COMMAND LEATHER", 8000),
                new Product("NIKE METCON 4", 5000),
                new Product("NIKE FLYKNIT MAX", 12000),
                new Product("NIKE ODYSSEY REACT 2 FLYKNIT", 9500),
                new Product("NIKE AIR MAX 2016", 8500),
                new Product("NIKE AIR ZOOM PEGASUS 35", 10500)
            },
                [new Vendor("SportVision")] = new List<Product>
            {
                new Product("ADIDAS BARRICADE 2018 CLAY" , 5000),
                new Product("UA VERGE 2.0 MID GTX" , 4500),
                new Product("UA CURRY 5" , 7000),
                new Product("UA CHARGED ULTIMATE 3.0" , 5700),
                new Product("UA NEWELL RIDGE LOW" , 10000),
                new Product("NIKE AIR MAX 2018", 8500),
                new Product("UA SPEEDFORM GEMINI 3" , 6000)
            },
                [new Vendor("BuzzShop")] = new List<Product>
            {
                new Product("ADIDAS SOLAR BOOST M" , 9500),
                new Product("ADIDAS ULTRABOOST" , 8800),
                new Product("ADIDAS SPRINGBLADE SOLYCE M" , 7000),
                new Product("ADIDAS BARRICADE 2018 CLAY" , 7700),
                new Product("ADIDAS HARDEN VOL. 2" , 10000),
                new Product("ADIDAS PUREBOOST XPOSE", 8500),
                new Product("ADIDAS CRAZY EXPLOSIVE 201" , 6000)
            }
            };

            #endregion

            User someUser = Methods.RegisterUser(username);

            Console.WriteLine("--------------------------Please choose one of the following actions:--------------------------");
            Console.WriteLine("1.Get the full list of vendors");
            Console.WriteLine("2.Search all products based on Vendors name with name and price");
            Console.WriteLine("3.Create a new order by providing product code and quantity and add to user orders");
            Console.WriteLine("4.Get state of shopping cart (name / quantity / price)");
            Console.WriteLine("5.Remove existing order by index");
            Console.WriteLine("6.Finish oreder with order receipt including username , products name quantity and price and total price");
            Console.WriteLine("7.Exit shop");
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Methods.UsersActions(VendorsAndProducts, someUser);

















            Console.ReadLine();
        }
    }
}
