
using System;

namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order() { Price=12 , ProductCount=3 };
            Order order2 = new Order() { Price=2 , ProductCount=3 };
            Order order3 = new Order() { Price=52 , ProductCount=3 };
            Order order4 = new Order() { Price=32 , ProductCount=3 };
            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            shop.AddOrder(order3);
            shop.AddOrder(order4);
            Console.WriteLine(shop.GetOrdersAvg());
            var ss = shop.GetOrderByPrice(12, 40);
            foreach (var item in ss)
            {
                Console.WriteLine(item.dateTime);
            }


        }
    }
}
