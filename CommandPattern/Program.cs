using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var waiter = new Waiter();
            var customer = new Customer(waiter);
            customer.Request(Dish.Pizza);
            customer.Request(Dish.Steak);
            Console.ReadLine();
        }
    }
}
