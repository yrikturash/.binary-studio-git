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
            Console.WriteLine("Type an integer:");
            string line = Console.ReadLine();
            double value;
            if (double.TryParse(line, out value))
            {
                Console.WriteLine("Sine of {0} is {1:##.00000}", value, Math.Sin(Math.PI * value / 180));
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
            Console.ReadKey();
        }
    }
}
