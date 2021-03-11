using System;
using System.Threading;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var lightMediator = new LightMediator();
            var lights = new Light[] {
                new Light("Red",lightMediator),
                new Light("Green",lightMediator),
                new Light("Yellow",lightMediator),

            };
            int currentLightIndex = 0;
            Light light;
            while (true)
            {
                if (currentLightIndex >= lights.Length)
                {
                    currentLightIndex = 0;
                }
                light = lights[currentLightIndex];
                light.TurnOn();
                timer();
                currentLightIndex++;
            }
        }
        private static void timer()
        {
            Thread.Sleep(3000);
        }
    }
}
