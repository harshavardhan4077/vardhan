using System;
using System.Collections.Generic;

namespace product_store_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<product1> products = new List<product1>();
            product_controller controller = new product_controller();

            Console.WriteLine("................PRODUCT STORE 1..................\n");

            bool showMenu = true;

            Console.WriteLine("........console app...........\n");

            while (showMenu)
            {
                Console.WriteLine("........select a option...........\n");
                Console.WriteLine("........1. add product...........\n");
                Console.WriteLine("........2. display all products...........\n");
                Console.WriteLine("........3. delete a product...........\n");
                Console.WriteLine("........4. exit...........\n");
                Console.WriteLine("........enter a option ...........\n");
                int key = Int16.Parse(Console.ReadLine());

                if(key == 1)
                {
                    Console.WriteLine("enter product id:");
                    int id = Int16.Parse(Console.ReadLine());

                    Console.WriteLine("enter product name:");
                    String name = (Console.ReadLine());
                     
                    Console.WriteLine("enter product price:");
                    int price = Int32.Parse(Console.ReadLine());


                    controller.additem(new product1(){ id = id, name = name, price = price });
                    Console.WriteLine("product added successfully");
                    Console.ReadLine();
                }
                else if(key == 2)
                {
                    controller.display();
                    Console.ReadLine();

                }
                else if(key == 3)
                {
                    Console.WriteLine("enter a product id:");
                    int position = Int16.Parse(Console.ReadLine());
                    products.RemoveAt(position);
                    Console.WriteLine("product deleted successfully");
                    Console.ReadLine();
                }
                else if(key == 4)
                {
                    Environment.Exit(0);

                }
                
            }
        }
    }
}
