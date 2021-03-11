using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Observer1 : IObserver
    {
        public void update(string message)
        {
            Console.WriteLine("Message 1 changed: " + message);
        }
    }
    public class Observer2 : IObserver
    {
        public void update(string message)
        {
            Console.WriteLine("Message 2 changed: " + message);
        }
    }
}
