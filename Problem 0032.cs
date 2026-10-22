//1
//1 1
//1 2 1
//1 3 3 1
//1 4 6 4 1
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int i, j, limit, number;

        Console.Write("Enter the limit:- ");
        limit = Convert.ToInt32(Console.ReadLine());

        for (i = 0; i < limit; i++)
        {
            number = 1;
            for (j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
