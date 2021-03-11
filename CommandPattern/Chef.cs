using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Receiver
    /// </summary>
    public class PizzaChef
    {
        public void MakePizza()
        {
            Console.WriteLine("I'm making Pizza");
        }
    }
    public class SteakChef
    {
        public void MakeSteak()
        {
            Console.WriteLine("I'm making Steak");
        }
    }

}
