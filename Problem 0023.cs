//1 2 3 = 6
//4 5 6 = 15
//7 8 9 = 24
//= = =
//12 15 18
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter matrix size: ");
        
        int i, j, limit, total, index;
        
        limit = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[limit * limit];

        Console.WriteLine("Enter " + (limit * limit) + " numbers:");
        for (i = 0; i < limit * limit; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < limit; i++)
        {
            total = 0;
            for (j = 0; j < limit; j++)
            {
                index = i * limit + j;
                Console.Write(array[index] + " ");
                total += array[index];
            }
            Console.WriteLine(" = " + total);
        }

        for (i = 0; i < limit; i++)
        {
            Console.Write("= ");
        }
        Console.WriteLine();

        for (i = 0; i < limit; i++)
        {
            total = 0;
            for (j = 0; j < limit; j++)
            {
                index = j * limit + i;
                total += array[index];
            }
            Console.Write(total + " ");
        }
        Console.WriteLine();
    }
}
