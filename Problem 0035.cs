//    1
//   121
//  12321
// 1234321
//123454321
// 1234321
//  12321
//   121
//    1
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int i, j, k, limit;

        Console.Write("Enter the limit:- ");
        limit = Convert.ToInt32(Console.ReadLine());

        for (i=1;i<=limit;i++)
        {
            for (j=1;j<=(limit-i);j++){
                Console.Write(" ");
            }
            for (k=1;k<=i;k++)
            {
                Console.Write(k);
            }
            for (k=(i-1);k!=0;k--)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
        
        for(i=1;i<limit;i++){
            for(j=1;j<=i;j++){
               Console.Write(" ");
            }
            for(k=1;k<=(limit-i);k++){
                Console.Write(k);
            }
            for (k=((limit-i)-1);k!=0;k--)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
    }
}
