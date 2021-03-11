using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ObjectPoolPattern
{
    public class Client
    {
        private TaxiPool taxiPool;
        public Client(TaxiPool taxiPool)
        {
            this.taxiPool = taxiPool;
        }
        public void TakeATaxi()
        {
            try
            {
                Console.WriteLine("New client: "+ Thread.CurrentThread.Name);
                var taxi = taxiPool.GetTaxi();
                var timeInUse = randInt(1000, 1500);
                Thread.Sleep(timeInUse);
                taxiPool.Release(taxi);
                Console.WriteLine(taxi.Name + " served the " + Thread.CurrentThread.Name + " in " + timeInUse + " milliseconds");
            }
            catch
            {
                Console.WriteLine(">>>Rejected the client: " + Thread.CurrentThread.Name);
            }
        }
        public static int randInt(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
