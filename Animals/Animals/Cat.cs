using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : IAnimal, IMammal
    {
        public void MakeNoise()
        {
            Console.WriteLine("Meaawww!!!");
        }

        public void Run()
        {
            Console.WriteLine("Cat is Running");
        }

        public void Walk()
        {
            Console.WriteLine("Cat is Walking !!!");
        }
    }
}
