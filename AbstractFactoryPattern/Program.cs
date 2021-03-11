using AbstractFactoryPattern.Factory;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = FurnitureFactory.GetFactory(MaterialType.WOOD);
            var chair = factory.CreateChair();
            chair.Create();

            var table = factory.CreateTable();
            table.Create();
            Console.ReadLine();
        }
    }
}
