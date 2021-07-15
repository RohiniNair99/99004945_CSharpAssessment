using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne_IncorrectSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. The following code find the sum of all the numbers between 0 and 10000
            //2. The sum of the numbers should be for only numbers that are divisble by 3 or 5
            int result = 0;
            for (int i = 1; i <= 10000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    result +=i;
                }
            }
            Console.WriteLine("The sum of all number divisble by 3 and 5 between 1 and 10000 is "+ result);
            Console.ReadLine();
        }
    }
}
