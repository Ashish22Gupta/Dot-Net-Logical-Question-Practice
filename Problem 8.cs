// * Expected Output*
//     1 
//   1 2 1
// 1 2 3 1 2

using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program
{
    public static void Main(string[] args)
    {
        int i, j, l, m, limit = 3;
        for (i = 1; i <= limit; i++)
        {
            for (j = (limit - i); j != 0; j--)
            {
                Console.Write(" ");
            }

            for (l = 1; l <= i; l++)
            {
                Console.Write(l);
            }
            
            for (m = 1; m < i; m++)
            {
                Console.Write(m);
            }
            
            Console.WriteLine();
        }
    }
}
