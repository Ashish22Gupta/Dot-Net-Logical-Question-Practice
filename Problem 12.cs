//* Expected Output */
//1 8 9 16
//2 7 10 15
//3 6 11 14
//4 5 12 13

using System;
namespace HelloWold;
public static class Program
{
    public static void Main(string[] args)
    {
        int limit = 4;
        for (int i = 0; i < limit; i++)
        {
            for (int j = 0; j < limit; j++)
            {
                Console.Write(j % 2);
                if (j % 2 == 0)
                {
                    //Console.Write((j * limit) + i + 1 + " ");
                }
                else
                {
                    //Console.Write(((j + 1) * limit) - i + " ");
                }
            }
            Console.WriteLine();
        }
    }
