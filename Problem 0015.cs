/* Expected Output */
//4 3 2 1
//5 6 7 8
//12 11 10 9
//13 14 15 16

using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int limit = 4;
        int number = 1;
        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 != 0)
            {
                number = limit * i;
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write(number + " ");
                    number--;
                }
            }
            else
            {
                int start = (limit * i) - (limit - 1);
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write(start + " ");
                    start++;
                }
                number += limit;
            }
            Console.WriteLine();
        }
    }
}
