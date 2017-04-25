using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //07:05:45PM
            var Format12Time = Console.ReadLine();

            //19:05:45
            var Format24Time = Convert12To24Time(Format12Time);

            Console.WriteLine(Format24Time);
            Console.ReadKey();
        }

        private static string Convert12To24Time(string time12)
        {
            var result = time12.Remove(time12.Length-2, 2);
            string[] time12parts = time12.Split(':');
            var dayPart = time12parts[2].Remove(0,2);
            if (dayPart == "PM" && time12parts[0] != "12")
            {
                time12parts[0] = (Convert.ToInt32(time12parts[0]) + 12).ToString();
                time12parts[2] = time12parts[2].Remove(2, 2);
                result =  string.Join(":", time12parts);
            }else if (dayPart == "AM" && time12parts[0] == "12")
            {
                time12parts[0] = "00";
                time12parts[2] = time12parts[2].Remove(2, 2);
                result = string.Join(":", time12parts);
            }
            return result;
        }
        
    }
}
