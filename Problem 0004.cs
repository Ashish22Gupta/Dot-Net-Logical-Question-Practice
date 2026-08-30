// * Expected Output*
// 1 
// 1 2 
// 1 2 3 
// 1 2 3 4 
// 1 2 3 4 5 

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i, j, limit=5;
        for(i=1;i<=limit;i++){
            for(j=1;j<=i;j++){
               Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }
}
