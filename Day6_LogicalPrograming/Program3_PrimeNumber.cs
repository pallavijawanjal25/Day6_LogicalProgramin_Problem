using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppPracticeBasic_Logical
{
    public static class Prime_Or_Not
    {
        public static void  CheckPrime_Or_Not()
        {
            int number = 7;
            int count = 0;
            for (int i = 1; i <= number; i++)
            { 
             if (number%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}

