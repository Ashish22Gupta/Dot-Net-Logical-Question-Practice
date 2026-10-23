//*
//* *
//*   *
//*     *
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

        for (i=1;i<=limit;i++)
        {
            for (j=1;j<=i;j++)
            {
                if(j==1 || j==i || i==limit){
                    Console.Write("* ");
                }else{
                   Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }
}
