using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class DecoratorB : IComponent
    {
        private readonly IComponent _component;
        public DecoratorB(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            var s = _component.Operation();
            return $"{s}. But I was the 'override'";
        }
    }
}
