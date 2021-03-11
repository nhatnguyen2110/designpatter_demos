using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Component : IComponent
    {
        public string Operation()
        {
            return "Hello world! This is the original object";
        }
    }
}
