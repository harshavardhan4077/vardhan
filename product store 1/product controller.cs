using System;
using System.Collections.Generic;
using System.Text;

namespace product_store_1
{
    class product_controller
    {
        private List<product1> products;

        public product_controller()
        {
            products = new List<product1>();
        }

        public void additem(product1 product1)
        {
            products.Add(product1);
        }

        public void display()
        {
            foreach (product1 p in products)
            {
                Console.WriteLine(".......................");

                Console.WriteLine("id : " + p.id);
                Console.WriteLine("name : " + p.name);
                Console.WriteLine("price : " + p.price);

                Console.WriteLine(".......................");
            }
        }
    }
}
