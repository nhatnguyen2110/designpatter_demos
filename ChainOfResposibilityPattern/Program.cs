using System;

namespace ChainOfResposibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup ATM
            var atm = new ATMMachine(5, 5, 5, 5);

            //khach 1 rut 1000k
            Console.WriteLine("Khach 1 rut 1.000.000");
            atm.WithDraw(1000000);
            Console.WriteLine("-----------------------------");
            atm.ShowStatus();
            Console.WriteLine("*******************************");
            //khach 2 rut 2500k
            Console.WriteLine("Khach 2 rut 2.500.000");
            atm.WithDraw(2500000);
            Console.WriteLine("-----------------------------");
            atm.ShowStatus();
            Console.WriteLine("*******************************");
            //khach 3 rut 350k
            Console.WriteLine("Khach 3 rut 350.000");
            atm.WithDraw(350000);
            Console.WriteLine("-----------------------------");
            atm.ShowStatus();
            Console.ReadLine();
        }
    }
}
