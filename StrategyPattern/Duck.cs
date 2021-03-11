using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this.flyBehavior = fb;
        }
        public void Swim()
        {
            Console.WriteLine("All ducks can float");
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}
