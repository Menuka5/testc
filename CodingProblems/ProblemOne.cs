using System;

namespace CodingProblems
{
    class ProblemOne
    {

        static void Main(string[] args)
        {
            String name = "Menuka Ishan";
            int age = 26;
            String school = "St. Thomas' College";

            {
                for (int i = 5; i > 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Age = " + age);
                Console.WriteLine("School = " + school);
                Console.WriteLine();
                int b = 1;
                while (b < 6)
                {
                    for (int z = 0; z < b; z++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    b++;
                }


                Console.ReadLine();
            }
        }
    }
}