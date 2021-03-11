using System;
using System.Threading;

namespace ObjectPoolPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var NUM_OF_CLIENT = 15;
            var taxiPool = new TaxiPool();
            for (int i = 0; i < NUM_OF_CLIENT; i++)
            {
                var client = new Client(taxiPool);
                var thread = new Thread(client.TakeATaxi);
                thread.Name = "Client " + i;
                thread.Start();
            }
            Console.ReadLine();
        }
    }
}
