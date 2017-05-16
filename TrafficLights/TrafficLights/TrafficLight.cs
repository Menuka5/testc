using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    class TrafficLight
    {
        Bulb red;
        Bulb yellow;
        Bulb green;

        public TrafficLight(Bulb red, Bulb yellow, Bulb green)
        {
            this.red = red;
            this.yellow = yellow;
            this.green = green;
        }

        public void Start()
        {
            red.Name = "Red";
            red.Next = "first";
            red.Status = true;
            yellow.Name = "Yellow";
            green.Name = "Green";

            int x;
            Console.WriteLine("Please enter number of loops need to run traffic lights?");
            if (Int32.TryParse(Console.ReadLine(), out x))
            {
                LoopRunner(x);
            }
            else
            {
                Console.WriteLine("You have entered wrong input!!!");
                Start();
            }

        }

        private void PrintLight(params string[] lights)
        {
            string msg = "Signals on ->";
            for (int i = 0; i < lights.Length; i++)
            {
                msg = msg + " " + lights[i];
            }

            Console.WriteLine(msg);

        }

        public void LoopRunner(int numOfLoops)
        {
            //if (red.Status && !yellow.Status && breaker == 0)
            //Console.WriteLine("Number of loops = " + yellow.Status);
            for (int i = 0; i < numOfLoops; i++)
            {
                
                for (int k = 0; k < 4; k++)
                {
                    if (red.Status && !yellow.Status)
                    {
                        PrintLight(red.Name);
                        yellow.Status = true;
                    }
                    else if (red.Status && yellow.Status)
                    {
                        PrintLight(red.Name, yellow.Name);
                        red.Status = false;
                        yellow.Status = false;
                        green.Status = true;

                    }
                    else if (green.Status)
                    {
                        PrintLight(green.Name);
                        green.Status = false;
                        yellow.Status = true;

                    }
                    else if (!red.Status && yellow.Status)
                    {
                        PrintLight(yellow.Name);
                        red.Status = true;
                        yellow.Status = false;

                    }
                    else
                    {
                        break;
                    }

                }
            }
        }
    }
}
;