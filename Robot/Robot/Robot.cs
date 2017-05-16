//Menuka Ishan 
using System;
using System.Collections.Generic;
using System.Text;
namespace Robot
{
    class Robot
    {
        //This input to store variables through scope 
        string input;
        //this method check whether entered value is int or not.
        public bool isCorrectStrengh(string newStrength)
        {
            int n;
            bool isInt = int.TryParse(newStrength, out n);

            if (isInt)
            {
                if (n > 0 && n <= 50)
                {
                    return true;
                }
            }
            return false;
        }


        static void Main(string[] args)
        {
            int health = 100;
            int strength = 75;
            int storeStrength = 0;
            Console.WriteLine("Robot started!!!");
            Console.WriteLine("Initial Health = " + health + " Initial Strength = " + strength);

            //Intialising robot instance mainly for data store
            Robot newRobot = new Robot();

            while(health >= 0)
            {
                if(health == 100)
                {
                    Console.WriteLine("* Robot shoots = " + (strength - 50) + " health = " + (health - 5));
                    strength -= (strength - 50);
                }
                //in this bracket we do all the calculation within Intial status and end.
                else if (health > 0 && strength == 50)
                {

                    Console.WriteLine("Robot needs strength!!!\nGive strength equal or lower than 50");
                    newRobot.input = Console.ReadLine();

                    //Loop checks whether correct input is entered or not.
                    while (!newRobot.isCorrectStrengh(newRobot.input))
                    {
                        Console.WriteLine("Please Enter Integer value within 0 and 50");
                        newRobot.input = Console.ReadLine();
                    }

                    //calculation for corrected input 
                    if (newRobot.isCorrectStrengh(newRobot.input))
                    {
                        int.TryParse(newRobot.input, out storeStrength);
                        strength += storeStrength;

                        Console.WriteLine("* Robot shoots = " + (strength - 50) + " health = " + (health - 5));
                        strength -= (strength - 50);
                    }

                }
                else
                {
                    Console.WriteLine("****### Robot is dead ###****");
                }
                //Here we deduct health by 5 point for every succesful shooting
                health -= 5;
            }
                
            
            Console.ReadLine();
        }
    }
}
