using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new IItem[]
            {
              new Pen(){Price=5, Model="Pen 1"},
              new Pen(){Price=10, Model="Pen 2"},
              new Notebook(){Price=50, NumberOfPages=150},
              new Notebook(){Price=70, NumberOfPages=300}
            };
            var total = GetTotalPrice(items);
            Console.WriteLine("Total price is " + total);
            Console.ReadLine();
        }
        private static int GetTotalPrice(IItem[] items)
        {
            var visitor = new Visitor();
            int result = 0;
            foreach (var item in items)
            {
                result += item.Accept(visitor);
            }
            return result;
        }
    }
}
