using System;

namespace CodingProblems
{
    class ProblemTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome\nEnter Calculation");
            if (args.Length > 2)
            {
                int n;
                int m;

                bool isNumeric;
                bool firValInt = int.TryParse(args[0], out n);
                bool secValInt = int.TryParse(args[2], out m);
                isNumeric = firValInt && secValInt;
                
                if (isNumeric)
                {
                    switch (args[1])
                    {
                        case "+":
                            Console.WriteLine("Number 1 = " + n);
                            Console.WriteLine("Operator = " + args[1]);
                            Console.WriteLine("Number 2 = " + m);
                            Console.WriteLine("Answer = " + (n + m) );
                            break;
                        case "-":
                            Console.WriteLine("Number 1 = " + n);
                            Console.WriteLine("Operator = " + args[1]);
                            Console.WriteLine("Number 2 = " + m);
                            Console.WriteLine("Answer = " + (n - m));
                            break;
                        case "*":
                            Console.WriteLine("Number 1 = " + n);
                            Console.WriteLine("Operator = " + args[1]);
                            Console.WriteLine("Number 2 = " + m);
                            Console.WriteLine("Answer = " + (n * m));
                            break;
                        case "/":
                            Console.WriteLine("Number 1 = " + n);
                            Console.WriteLine("Operator = " + args[1]);
                            Console.WriteLine("Number 2 = " + m);
                            Console.WriteLine("Answer = " + ((float)n / (float)m));
                            break;
                        default:
                            Console.WriteLine("Invalid Operator added");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number has entered");
                }
               
            }
           
            Console.ReadLine();
        }
    }
}
