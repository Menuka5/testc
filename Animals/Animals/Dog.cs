using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : IAnimal, IMammal
    {
        public void MakeNoise()
        {
            Console.WriteLine("Baawww");
        }

        public void Run()
        {
            Console.WriteLine("Doc is Running");
        }

        public void Walk()
        {
            Console.WriteLine("Dog is Walking");
        }
    }
}
