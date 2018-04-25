using System;
using System.Collections.Generic;
using System.Text;

namespace _06.TrafficLight
{
    public interface ITrafficLight
    {
        Lights light { get; set; }

        void ChangeLights();
    }
}
