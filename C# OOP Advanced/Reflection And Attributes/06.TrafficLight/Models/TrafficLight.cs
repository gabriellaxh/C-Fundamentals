using System;
using System.Collections.Generic;

namespace _06.TrafficLight
{
    public class TrafficLight : ITrafficLight
    {
        public Lights light { get; set; }

        public TrafficLight(string light)
        {
            this.Light = (Lights)Enum.Parse(typeof(Lights), light);
        }

        public Lights Light
        {
            get => this.light;
            private set => this.light = value;
        }

        public void ChangeLights()
        {
            this.Light += 1;

            this.Light = (int)this.Light > 2 ? 0 : this.Light;
        }

        public override string ToString()
        {
            return $"{this.Light}";
        }
    }
}
