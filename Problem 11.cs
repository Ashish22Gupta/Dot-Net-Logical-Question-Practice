//* Expected Output */
//1 5 9 13
//2 6 10 14
//3 7 11 15
//4 8 12 16

using System;

namespace HelloWold;

public static class Problem11
{
    public static void Main(string[] args)
    {
        int limit = 4;
        int number = 1;
        int i, j, incrementvalue;

        for (i = 0; i < limit; i++)
        {
            incrementvalue = 0;
            for (j = 0; j < limit; j++)
            {
                Console.Write(i + 1 + incrementvalue + " ");
                incrementvalue += limit;
            }
            Console.WriteLine();
        }
    }
