// * Expected Output*
//     1 
//   2 3 4
// 5 6 7 8 9

using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program
{
    public static void Main(string[] args)
    {
        int i, j, k, limit = 3, increment = 1;
        for (i = 1; i <= limit; i++)
        {
            for (j = (limit - i); j != 0; j--)
            {
                Console.Write(" ");
            }

            for (k = 1; k <= (((limit * i) - i) - 1); k++)
            {
                Console.Write(increment);
                increment++;
            }
            Console.WriteLine();
        }
    }
}
