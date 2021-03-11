using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IFlyBehavior
    {
        void Fly();
    }
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
    public class FlySoFast : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying so fast");
        }
    }
}
