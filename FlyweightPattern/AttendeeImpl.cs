using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class AttendeeImpl : IAttendee
    {
        public string Name;
        public int Age;
        public void ListenToConcert()
        {
            Console.WriteLine($"{Name} ({Age} year old) is listening the concert");
        }
    }
}
