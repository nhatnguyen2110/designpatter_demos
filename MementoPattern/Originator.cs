using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Originator
    {
        private string state;
        public void Set(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            this.state = state;
        }
        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento");
            return new Memento(this.state);
        }
        public void RestoreFromMemento(Memento memento)
        {
            this.state = memento.GetSavedState();
            Console.WriteLine("Originator: State after restoring from Memento: " + state);
        }
        public class Memento
        {
            private string state;
            public Memento(string stateToSave)
            {
                state = stateToSave;
            }
            public string GetSavedState()
            {
                return state;
            }
        }
    }
}
