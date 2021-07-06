using System;
using System.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Good iPhone12 = new Good("IPhone 12");
            Good iPhone11 = new Good("IPhone 11");

            Warehouse warehouse = new Warehouse();

            Shop shop = new Shop(warehouse);

            warehouse.Delive(new GoodPortion(iPhone12, 10));
            warehouse.Delive(new GoodPortion(iPhone11, 1));

            Console.WriteLine(warehouse.ToString());

            Cart cart = shop.Cart();

          
            cart.Add(iPhone12, 4);
            cart.Add(iPhone11, 3);
            

            Console.WriteLine(cart.ToString());

            Console.WriteLine(cart.Order().Paylink);
        }
    }

}
