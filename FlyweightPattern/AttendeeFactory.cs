using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    public class AttendeeFactory
    {
        public static Dictionary<string, IAttendee> attendees = new Dictionary<string, IAttendee>();
        public static IAttendee GetAttendee(string name)
        {
            IAttendee attendeeImpl;
            attendees.TryGetValue(name, out attendeeImpl);
            if (attendeeImpl == null)
            {
                attendeeImpl = new AttendeeImpl() { Name = name };
                attendees.Add(name, attendeeImpl);
                Console.WriteLine("New attendee: " + name);
            }
            return attendeeImpl;
        }
    }
}
