using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.AddItem(new Item("Home", "/home"));
            menu.AddItem(new Item("Java", "/java"));
            menu.AddItem(new Item("Spring Boot", "/spring-boot"));
            var iterator = menu.Iterator();
            while (iterator.HasNext())
            {
                var item = iterator.Next();
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
