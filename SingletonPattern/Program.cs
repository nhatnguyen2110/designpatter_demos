using System;
using System.Runtime.CompilerServices;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = MySingleton.getInstance();
            var s2 = MySingleton.getInstance();
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            Console.ReadLine();
        }
    }
    public class MySingleton
    {
        private MySingleton() { }
        private static MySingleton instance;
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static MySingleton getInstance()
        {
            if (instance == null)
            {
                instance = new MySingleton();
            }
            return instance;
        }
    }
}
