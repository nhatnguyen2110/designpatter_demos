using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var savedStates = new List<Originator.Memento>();

            var originator = new Originator();
            originator.Set("State #1");
            originator.Set("State #2");
            savedStates.Add(originator.SaveToMemento());
            originator.Set("State #3");
            savedStates.Add(originator.SaveToMemento());
            originator.Set("State #4");

            originator.RestoreFromMemento(savedStates.Last());

            Console.ReadLine();
        }
    }
}
