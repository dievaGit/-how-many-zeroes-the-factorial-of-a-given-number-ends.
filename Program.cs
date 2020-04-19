using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            uint n = 0, count = 0;
            BigInteger f = 1, module = 0;

            //Requesting number
            Console.Write(" Enter the positive number: ");
            n = Convert.ToUInt32(Console.ReadLine());

            //factorial
            for (uint i = n; i > 0; i--)
            {
                f *= i;
            }

            //Looking for zeros at the end of the factorial
            module = f;
            while((module %10) == 0)
            {
                count++;
                module /= 10;
            }

            Console.Write(" N = {0} -> N! = {1} -> Have {2} Zeros.", n, f, count);

            Console.ReadKey();
        }
    }
}
