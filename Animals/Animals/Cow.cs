using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cow : IAnimal, IMammal
    {
        public void MakeNoise()
        {
            Console.WriteLine("Ummmmbbaaaa!!!");
        }

        public void Run()
        {
            Console.WriteLine("Cow is Running");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is Walking");
        }
    }
}
