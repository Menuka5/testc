using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : IAnimal, IAmphibia
    {
        public void Swim()
        {
            Console.WriteLine("Frog is Swimming");
        }
        

        public void Walk()
        {
            Console.WriteLine("Frog is walking");
        }
    }
}
