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
            Console.WriteLine("Type an double for sine:");
            string line = Console.ReadLine();
            double value;
            if (double.TryParse(line, out value))
            {
                Console.WriteLine("Sine of {0} is {1:##.00000}", value, Math.Sin(Math.PI * value / 180));
            }
            else
            {
                Console.WriteLine("Not an double!");
            }
            Console.ReadKey();

            Console.WriteLine("\n\rType an integer for factorial:");
            line = Console.ReadLine(); // Read string from console
            int intVal;
            if (int.TryParse(line, out intVal))
            {
                Console.WriteLine("Sine of {0} is {1}", intVal, Factorial(intVal));
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
            line = Console.ReadLine(); // Read string from console
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
