using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);

            var tallestCandlesHeight = GetTallestCandlesHeight(height);
            var countOfTallestCandles = GetCountOfTallestCandles(tallestCandlesHeight, height);
            Console.WriteLine(countOfTallestCandles);
            Console.ReadKey();
        }

        private static int GetCountOfTallestCandles(int tallestCandlesHeight, int[] heightTemp)
        {
            var result = 0;
            for (int i = 0; i < heightTemp.Length; i++)
            {
                if (heightTemp[i] == tallestCandlesHeight)
                {
                    result++;
                }
            }
            return result;
        }

        private static int GetTallestCandlesHeight(int[] candlesHeight)
        {
            var result = 0;
            for (int i = 0; i < candlesHeight.Length; i++)
            {
                if (candlesHeight[i] > result)
                {
                    result = candlesHeight[i];
                }
            }
            return result;
        }
    }
}
