using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            do
            {
                Console.WriteLine("Write the number of Fibonacci Sequence:");
                input = Console.ReadLine();
                Console.WriteLine(GetFibonacciSequence(input));
                Console.WriteLine("Done!");
            } while (input != "q");
        }

        private static string GetFibonacciSequence(string input)
        {
            if (!Int32.TryParse(input, out int number))
                return "Must be number!";

            if (number < 0)
                return "Must be more then 0";

            var result = string.Empty;
            for (var i = 2; i < number; i++)
            {
                result = result + GetSumm(i - 1, i - 2);
            }

            return result;
        }

        private static string GetSumm(int i, int v)
        {
            return (i + v).ToString() + " ";
        }
    }
}
