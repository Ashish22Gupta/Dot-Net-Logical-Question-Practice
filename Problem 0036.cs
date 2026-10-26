//* * * * *
// * * * *
//  * * *
//   * *
//    *
//   * *
//  * * *
// * * * *
//* * * * *
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int i, j, limit;

        Console.Write("Enter the limit:- ");
        limit = Convert.ToInt32(Console.ReadLine());

        for (i=1;i<limit;i++)
        {
            for (j=1;j<i;j++){
                Console.Write(" ");
            }
            
            for (j=1;j<=limit-(i-1);j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        
        for (i=1;i<=limit;i++)
        {
            for (j=1;j<=(limit-i);j++){
                Console.Write(" ");
            }
            
            for (j=1;j<=i;j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
