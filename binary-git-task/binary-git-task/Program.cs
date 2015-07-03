using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_git_task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type an double for sine:");
                var line = Console.ReadLine();
                double value;
                if (double.TryParse(line, out value))
                {
                    Console.WriteLine("Sine of {0} is {1:##.00000}", value, Math.Sin(Math.PI * value / 180));
                    break;
                }
                else
                {
                    Console.WriteLine("Not an double!");
                }
            }

            while (true)
            {
                Console.WriteLine("\n\rType an integer for factorial:");
                var line = Console.ReadLine(); // Read string from console
                int intVal;
                if (int.TryParse(line, out intVal))
                {
                    Console.WriteLine("Sine of {0} is {1}", intVal, Factorial(intVal));
                    break;
                }
                else
                {
                    Console.WriteLine("Not an integer!");
                }
            }

            Console.ReadKey();
        }

        static int Factorial(int x)
        {
            if (x < 0)
            {
                return -1;
            }
            else if (x == 1 || x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}
