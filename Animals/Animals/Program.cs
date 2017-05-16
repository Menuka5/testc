using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Cow cow = new Cow();
            YellowBird yellowBird = new YellowBird();
            GoldFish goldFish = new GoldFish();
            Frog frog = new Frog();

            cat.MakeNoise();
            cat.Walk();
            cat.Run();

            dog.MakeNoise();
            dog.Walk();
            dog.Run();

            yellowBird.MakeNoise();
            yellowBird.Fly();

            goldFish.Swim();

            frog.Swim();
            frog.Walk();

            Console.ReadLine();
            
        }
    }
}
