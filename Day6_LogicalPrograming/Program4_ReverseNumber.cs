using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalPrograming
{
  static class Program4_ReverseNumber
    {
        public static void ReverseNumber()
        {
            Console.Write("Enter a number:   ");
            int num = Convert.ToInt32(Console.ReadLine());

            int remainder;

            int reversed = 0;

            while (num > 0)
            {
                remainder = num % 10;
                reversed = reversed * 10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("\n\nReversed Number :   " + reversed);
        }
    }
}
