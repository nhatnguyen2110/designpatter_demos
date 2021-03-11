using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DecoratorA : IComponent
    {
        private readonly IComponent _component;
        public DecoratorA(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            return _component.Operation();
        }
        public string AddedBehavior()
        {
            return "This is the A Decorator object";
        }
    }
}
