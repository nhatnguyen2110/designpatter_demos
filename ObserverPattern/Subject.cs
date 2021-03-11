using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyChange(string message)
        {
            foreach (var item in observers)
            {
                item.update(message);
            }
        }
    }
}
