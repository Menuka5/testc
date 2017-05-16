using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class YellowBird : IAnimal, IBird
    {
        public void Fly()
        {
            Console.WriteLine("Flying!!!");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Birnd Noices");
        }
    }
}
