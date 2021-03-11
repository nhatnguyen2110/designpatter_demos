using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Waiter
    {
        public void TakeOrder(IOrder order)
        {
            Console.WriteLine("Waiter take new order " + order.ToString());
            order.execute();
        }
    }
}
