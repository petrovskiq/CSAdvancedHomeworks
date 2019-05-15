using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public static class Methods
    {
        public static void PrintVendor(Vendor vendor)
        {
            Console.WriteLine($"---------- Store Name: *{vendor.Name.ToUpper()}* has these products available----------");
            foreach (var item in vendor.Products)
            {
                
                Console.WriteLine($"{item.ID} { item.Name } {item.Price}");
            }
        }

        public static User RegisterUser(string username)
        {
            

            if (!String.IsNullOrEmpty(username) && username.Length > 3)
            {
                User user = new User(username);
                Console.WriteLine($"------------------------You are registered , Welcome {username} ------------------------");
                return user;
            }
            else
            {
                Console.WriteLine("--------------------Registration was NOT succesfull , please try again!-------------------");
                string enterName = Console.ReadLine();
                return RegisterUser(enterName);
            }
        }

        public static void UsersActions(Dictionary<Vendor, List<Product>> somelist, User user)
        {
            double fullPrice = 0;
            Order ordering;
            string userAction = Console.ReadLine();
            switch (userAction)
            {
                case "1":
                    Console.WriteLine("---------------------------------List of all Vendors:------------------------------------");                    
                    foreach (var item in somelist)
                    {
                        Console.WriteLine($"{item.Key.ID} {item.Key.Name}");
                    }
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    int chosenVendor = int.Parse(Console.ReadLine());
                    foreach (var item in somelist)
                    {
                        item.Key.AddProduct(item.Value);
                        if (chosenVendor == item.Key.ID)
                        {

                            Methods.PrintVendor(item.Key);
                        }
                    }
                    goto case "3";

                case "2":          
                    foreach (var item in somelist)
                    {

                            item.Key.AddProduct(item.Value);
                            Methods.PrintVendor(item.Key);
                  
                    }
                    goto case "3";

                case "3":
                    Console.WriteLine("\nProvide product code and quantity");
                    string answer = "";
                    do
                    {
                        Console.Write("Product code: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity: ");

                        int quantity = int.Parse(Console.ReadLine());

                        
                        foreach (var item in somelist.Values)
                        {
                            foreach (var item1 in item)
                            {

                                ordering = new Order(id, item1.Name, item1.Price, quantity);

                                if (ordering.ID == item1.ID)
                                {
                                    Order.orders.Add(ordering);
                                    Console.WriteLine($"Your ordered products {item1.Name} Cost {item1.Price} \nThe total amount for {quantity} items is ${item1.Price * quantity}");

                                }
                            }

                        }

                        Console.WriteLine("Do you want to order more products\n 1. Yes 2. No");
                        answer = Console.ReadLine();

                    } while (answer == "1");

                    goto case "4";
                case "4":
                    

                    foreach (var item in Order.orders)
                    {
                        fullPrice += item.Price;
                        Console.WriteLine($" ID: {item.ID} Quantity: {item.Quantity} {item.Name}");
                    }

                    Console.WriteLine($"Full Price: {fullPrice}");
                    Console.WriteLine("1. Remove Order \n2. Finish Order");
                    string removeOrFinish = Console.ReadLine();

                    if (removeOrFinish == "1")
                    {
                        goto case "5";
                    }
                    else
                    {
                        goto case "6";
                    }

                    
                case "5":
                    bool flag = false;
                        Console.WriteLine("Enter order ID:");
                        int enterId = int.Parse(Console.ReadLine());
                        foreach (var item in Order.orders)
                        {
                            if (enterId == item.ID)
                            {
                                Order.orders.Remove(item);
                                Console.WriteLine($"The order {item.Name} was removed");
                                flag = true;
                                return;
                            }
                           
                        }
                        if (!flag)
                        {
                            Console.WriteLine("Invalid Input");
                            return;
                        }
                        Console.WriteLine("The Order Was Removed");
                   
                  
                    break;
                case "6":
                    Console.WriteLine($"Your order is finished : {user.UserName}");
                    foreach (var item in Order.orders)
                    {
                        Console.WriteLine($"Name: {item.Name} Quantity:{item.Quantity}");
                    }
                    Console.WriteLine($"${fullPrice}");
                    break;
                case "7":
                    Console.WriteLine("Thank you for your visit");
                    break;
                default:
                    Console.WriteLine("-------------------Invallid input , please enter number from 1 to 7-------------------");
                   
                    break;
            }
        }
    }
}
