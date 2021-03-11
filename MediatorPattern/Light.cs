using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class Light
    {
        
        private string color;
        private LightMediator lightMediator;
        private State currentState;

        public Light(string color, LightMediator lightMediator)
        {
            this.color = color;
            this.lightMediator = lightMediator;
            lightMediator.RegisterLight(this);
        }
        public void TurnOn()
        {
            this.currentState = State.ON;
            lightMediator.NotifyMediator(this);
        }
        public void TurnOff()
        {
            this.currentState = State.OFF;
            lightMediator.NotifyMediator(this);
        }
        public string GetColor()
        {
            return this.color;
        }
        public State GetCurrentState()
        {
            return currentState;
        }
        public override int GetHashCode()
        {
            return color.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(this.GetType().Name != obj.GetType().Name)
            {
                return false;
            }
            var light = (Light)obj;
            return color.Equals(light.color);
        }

    }
    public enum State
    {
        ON, OFF
    }
}
