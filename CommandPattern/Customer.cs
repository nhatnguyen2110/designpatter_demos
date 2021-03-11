using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// Client
    /// </summary>
    public class Customer
    {
        private Waiter waiter;
        public Customer(Waiter waiter)
        {
            this.waiter = waiter;
        }
        public void Request(Dish dish)
        {
            IOrder order;
            switch (dish)
            {
                case Dish.Pizza:
                    order = new Pizza();
                    break;
                case Dish.Steak:
                    order = new Steak();
                    break;
                default:
                    throw new Exception("Invalid option");
            }
            waiter.TakeOrder(order);
        }
    }
    public enum Dish
    {
        Pizza,
        Steak
    }
}
