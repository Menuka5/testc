using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight(new Bulb(), new Bulb(), new Bulb());
            trafficLight.Start();

            Console.ReadLine();
        }
    }
}
