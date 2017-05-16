using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class GoldFish : IAnimal, IFish
    {
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
