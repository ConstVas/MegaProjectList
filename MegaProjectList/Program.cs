using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaProjectList
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const decimal PI = 3.1415926535897932384626m;
        string input;
            do
            {
                do
                {
                    Console.Write("N?:");
                    input = Console.ReadLine();

                } while (CanConvert(input) == false);
                var c = Math.Round(PI, Convert.ToInt32(input)> 22 ? 22 : Convert.ToInt32(input));
                Console.WriteLine(c);
            } while (true);
            
        }

        private static bool CanConvert(string n)
        {
            foreach (var ni in n)
            {
                if ((ni < '0') || (ni > '9'))
                    return false;
            }
            if (n == "") return false;
            return true;
        }
    }
}
