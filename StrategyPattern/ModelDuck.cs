using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.flyBehavior = new FlyNoWay();
        }
    }
}
