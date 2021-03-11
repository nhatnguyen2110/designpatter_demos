using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlySoFast());
            model.PerformFly();
            Console.ReadLine();
        }
    }
}
