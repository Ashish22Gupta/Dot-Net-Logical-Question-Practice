// * Expected Output*
//   *
//  ***
// *****
//*******
// *****
//  ***
//   *

using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program
{
    public static void Main(string[] args)
    {
        int i, j, k, limit = 7;

        int toplimit = (limit / 2) + 1;

        int bottomlimit = limit / 2;

        for (i = 1; i <= toplimit; i++)
        {
            for (j = 1; j <= (toplimit - i); j++)
            {
                Console.Write(" ");
            }

            for (k = 1; k <= ((i * 2) - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (i = 1; i <= bottomlimit; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(" ");
            }

            for (k = (limit - (i * 2)); k != 0; k--)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
