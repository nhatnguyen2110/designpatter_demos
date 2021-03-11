using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init proxy image: ");
            var proxyImage = new ProxyImage("http://image.abc.com");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Call real service 1st: ");
            proxyImage.ShowImage();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Call real service 2nd:");
            proxyImage.ShowImage();
            Console.ReadLine();
        }
    }
}
