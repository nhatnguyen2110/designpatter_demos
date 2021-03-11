using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ObjectPoolPattern
{
    public class TaxiPool
    {
        private int EXPIRED_TIME_IN_MILISECOND = 2000;
        private int NUMBER_OF_TAXI = 4;

        private List<Taxi> available = new List<Taxi>();
        private List<Taxi> inUse = new List<Taxi>();

        private static int count = 0;
        private static bool waiting = false;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public Taxi GetTaxi()
        {
            if (available.Count != 0)
            {
                var taxi = available[0];
                inUse.Add(taxi);
                return taxi;
            }
            if (count == NUMBER_OF_TAXI)
            {
                this.WaitingUntilTaxiAvailable();
                return this.GetTaxi();
            }
            var newTaxi = this.CreateTaxi();
            inUse.Add(newTaxi);
            return newTaxi;
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Release(Taxi taxi)
        {
            inUse.Remove(taxi);
            available.Add(taxi);
            Console.WriteLine(taxi.Name + " is free");
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        private Taxi CreateTaxi()
        {
            this.Waiting(200); // The time to create a taxi
            var taxi = new Taxi() { Name = "Taxi " + count };
            count++;
            Console.WriteLine(taxi.Name + " is created");
            return taxi;
        }
        private void WaitingUntilTaxiAvailable()
        {
            lock (this)
            {
                if (waiting)
                {
                    waiting = false;
                    throw new Exception("No taxi available");
                }
                waiting = true;
            }
            
            Waiting(EXPIRED_TIME_IN_MILISECOND);
        }

        private void Waiting(int numberOfSecond)
        {
            Thread.Sleep(numberOfSecond);
        }
    }
}
