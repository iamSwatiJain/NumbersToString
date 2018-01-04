using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToString
{
    class Program
    {
        static void Main(string[] args)
        {
            NumToStringCount numberCount = new NumToStringCount();
            int sum = 0;
            for (int i=1; i<=1000; i++)
            {
                sum+= numberCount.CountLetters(i);
            }

            Console.WriteLine("The number of letters to write words between one to one thousand are "+sum);
        }
    }
}
