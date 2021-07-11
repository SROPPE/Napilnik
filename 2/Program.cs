using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var iPhone12 = new Good("IPhone 12");
            var iPhone11 = new Good("IPhone 11");

            var warehouse = new Warehouse();

            var shop = new Shop(warehouse);

            warehouse.Delive(new GoodPortion(iPhone12, 10));
            warehouse.Delive(new GoodPortion(iPhone11, 1));

            DisplayGoodsPortions(warehouse.Goods);

            Cart cart = shop.Cart();

            try
            {
                cart.Add(iPhone12, 4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                cart.Add(iPhone11, 3);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DisplayGoodsPortions(cart.ReservedGoods);

            Console.WriteLine(cart.Order().Paylink);
        }

        static private void DisplayGoodsPortions(IReadOnlyList<GoodPortion> portions)
        {
            var stringBuilder = new StringBuilder();
         
            foreach (var portion in portions)
            {
                stringBuilder.AppendLine($"Name: {portion.Good.Name} Amount: {portion.Amount}");
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
