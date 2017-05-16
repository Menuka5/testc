using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    class Bulb
    {
        private string name;
        private bool status;
        private string next;

        public string Name {
            get => name;
            set => name = value;
        }
        public bool Status {
            get => status;
            set => status = value;
        }
        public string Next { get => next;
            set => next = value;
        }
    }
}
