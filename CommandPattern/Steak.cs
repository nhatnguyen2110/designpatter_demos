using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class Steak : IOrder
    {
        private SteakChef chef;
        public Steak()
        {
            chef = new SteakChef();
        }
        public void execute()
        {
            chef.MakeSteak();
        }
        public override string ToString()
        {
            return "steak";
        }
    }
}
