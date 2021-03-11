using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class Pizza : IOrder
    {
        private PizzaChef chef;
        public Pizza()
        {
            chef = new PizzaChef();
        }
        public void execute()
        {
            chef.MakePizza();
        }
        public override string ToString()
        {
            return "pizza";
        }
    }
}
