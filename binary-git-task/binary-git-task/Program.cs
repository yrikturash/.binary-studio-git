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
            Console.WriteLine("Enter number for calculations:");
            int num = Console.Read();
            Console.WriteLine("Sine of {0} is {1}", num, Math.Sin(num));
        }
    }
}
