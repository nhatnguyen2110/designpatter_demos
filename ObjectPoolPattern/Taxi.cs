using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPoolPattern
{
    public class Taxi
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return "Taxi [Name=" + this.Name + "]";
        }
    }
}
