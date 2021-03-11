using System;

namespace FlyweightPattern
{
    class Program
    {
        private static string[] names = { "Ann", "Lee", "John", "Mary", "Peter" };
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var attendeeImpl = (AttendeeImpl)AttendeeFactory.GetAttendee(GetRandomName());
                attendeeImpl.Age = GetRandomAge();
                attendeeImpl.ListenToConcert();
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.ReadLine();
        }
        private static string GetRandomName()
        {
            int randomIndex = new Random().Next(names.Length);
            return names[randomIndex];
        }
        private static int GetRandomAge()
        {
            return new Random().Next(80);
        }
    }
}
