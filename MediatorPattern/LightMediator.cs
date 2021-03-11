using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class LightMediator
    {
        private List<Light> trafficSignals = new List<Light>();
        public void RegisterLight(Light light)
        {
            trafficSignals.Add(light);
        }
        public void UnregisterLight(Light light)
        {
            trafficSignals.Remove(light);
        }
        public void NotifyMediator(Light light)
        {
            Console.WriteLine(light.GetColor() + " is turned " + light.GetCurrentState());
            if (light.GetCurrentState() == State.ON)
            {
                TurnOffAllOtherLights(light);
            }
        }
        private void TurnOffAllOtherLights(Light light)
        {
            foreach (var item in trafficSignals)
            {
                if (!light.Equals(item))
                {
                    item.TurnOff();
                }
            }
            Console.WriteLine("---------------------------");
        }
    }
}
