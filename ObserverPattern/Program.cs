using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observer1 = new Observer1();
            var observer2 = new Observer2();
            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.NotifyChange("Test change state 1");
            subject.Detach(observer2);
            subject.NotifyChange("Test change state 2");

            Console.ReadLine();
        }
    }
}
