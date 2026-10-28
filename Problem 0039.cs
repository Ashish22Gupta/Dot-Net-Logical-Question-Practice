//5 4 3 2 1
//4 3 2 1
//3 2 1
//2 1
//1
         
using System;
namespace HelloWorld;
class Program
{
    public static void Main(string[] args)
    {
        int i, j, limit;

        Console.Write("Enter the limit:- ");
        limit = Convert.ToInt32(Console.ReadLine());
        
        for(i=1;i<=limit;i++){
            for(j=limit-(i-1);j!=0;j--){
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
