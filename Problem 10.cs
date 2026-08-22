/* Expected Output */
//1 2 3 4 
//8 7 6 5 
//9 10 11 12 
//16 15 14 13 

using System;

namespace HelloWold;

public static class Problem10
{
    public static void Main(string[] args)
    {
        int limit = 4;
        int number = 1;

        for (int i = 0; i < limit; i++)
        {

            if (i % 2 == 0)
            {
                for (int j = 0; j < limit; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
            }
            else
            {
                int start = number + limit - 1;

                for (int j = 0; j < limit; j++)
                {
                    Console.Write(start - j + " ");
                }

                number += limit;
            }

            Console.WriteLine();
        }
    }
