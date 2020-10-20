using System;
using SufferShopDB;
using SufferShopLib;

namespace SufferShopUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerSample obj0 = new CustomerSample("");
            CustomerSample obj1 = new CustomerSample("Loser Boboser");
            CustomerSample obj2 = new CustomerSample("Winner Bobinner Chicken Dinner");
            Console.WriteLine($"{obj1.ID} {obj1.Name}");
            Console.WriteLine($"{obj2.ID} {obj2.Name}");
        }
    }
}
